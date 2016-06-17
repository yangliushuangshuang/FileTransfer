using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace FT_PC
{
    class NetConnect
    {
        public NetConnect()
        {

        }
        //------------------------------------------------------------
        private static Socket socketWatch = null, socketChat = null;
        private static Thread listenThread = null, receiveThread = null, sendThread = null, fileSendThread = null;

        private static String fileName = null, fileLength = null; // 要接收的文件的信息
        private static String fpath = null, flength = null;//要发送的文件的信息
        private static Boolean send_over = false;
        private static Boolean go_on = true;

        private static FileStream fs = null;

        private static Boolean isListening = false;

        public Boolean GetListenState()
        {
            return isListening;
        }

        public void SetListenSate(Boolean state)
        {
            isListening = state;
        }


        /// <summary>
        /// 将要发送的文件的信息传递经来
        /// </summary>
        /// <param name="fpath"></param>
        /// <param name="flength1"></param>
        public static void setFileInfo(String fpath1, String flength1)
        {
            fpath = fpath1;
            flength = flength1;
        }

        public void StartListen()
        {
            ///创建终结点（EndPoint）
            //IPAddress ip = IPAddress.Parse(host);//把ip地址字符串转换为IPAddress类型的实例
            IPAddress ip = IPAddress.Any;
            IPEndPoint ipe = new IPEndPoint(ip, Config.PORT);//用指定的端口和ip初始化IPEndPoint类的新实例

            ///创建socket并开始监听
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个socket对像，如果用udp协议，则要用SocketType.Dgram类型的套接字
            socketWatch.Bind(ipe);//绑定EndPoint对像（2000端口和ip地址）
            socketWatch.Listen(0);//开始监听

            listenThread = new Thread(Listen);
            listenThread.IsBackground = true;
            listenThread.Start();

            isListening = true;

        }

        /// <summary>
        /// 监听客户端的连接，并创建与客户端通信的socket，
        /// </summary>
        public void Listen()
        {
            while (true)
            {
                try
                {
                    ///接受到client连接，为此连接建立新的socket，并接受信息
                    socketChat = socketWatch.Accept();//为新建连接创建新的

                    StartReceive(socketChat);
                }
                catch
                { }
            }
        }

        /// <summary>
        /// 开启接收消息的线程
        /// </summary>
        /// <param name="o"></param>
        public void StartReceive(object o)
        {
            receiveThread = new Thread(Receive);
            receiveThread.IsBackground = true;
            receiveThread.Start(socketChat);
        }

        /// <summary>
        /// 接收客户端发过来的消息
        /// </summary>
        /// <param name="o"></param>
        private void Receive(object o)
        {
            Socket socketChat = o as Socket;
            while (true)
            {
                try
                {
                    //从客户端接收发过来的消息
                    byte[] buffer = new byte[Config.BUFFER_SIZE];//设置一个2M的缓冲区，存储从socket中读取的数据
                    int r = socketChat.Receive(buffer);//在接收socket中的数据的同时得到数据的长度
                    if (r == 0)
                    {
                        break;
                    }

                    if (buffer[0] == Config.VALUE_TYPE_FILE_INFO)
                    {
                        #region 接收文件信息
                        string str = Encoding.UTF8.GetString(buffer, 1, r - 1);//读出缓冲区中的数据，放入到一个数组中
                        Dictionary<String, String> dic = JsonUtil.parserStr(str);
                        if (dic[Config.KEY_HEAD].Equals(Config.HEAD_CON_OK))
                        {
                            // 连接成功，发送文件信息，等待对方发送开始传输文件的指令就开始传输文件
                            String fname = FileHelper.GetFileName(fpath);
                            StartSend(JsonUtil.EncodeStr(Config.KEY_HEAD, Config.HEAD_FILE_INFO, Config.KEY_FILE_NAME, fname, Config.KEY_FILE_LENGTH, flength));
                        }
                        else if (dic[Config.KEY_HEAD].Equals(Config.HEAD_CON_ASK))
                        {
                            Boolean threadIsalive = false;
                            if (sendThread != null)
                            {
                                if (sendThread.IsAlive)
                                {
                                    //正在发送信息，请稍候重试
                                    threadIsalive = true;
                                }
                            }
                            if (!threadIsalive)
                            {
                                String message = JsonUtil.EncodeStr(Config.KEY_HEAD, Config.HEAD_CON_OK);
                                StartSend(message);
                            }
                        }
                        else if (dic[Config.KEY_HEAD].Equals(Config.HEAD_FILE_INFO))
                        {
                            //接收的是文件信息
                            fileName = dic[Config.KEY_FILE_NAME];
                            fileLength = dic[Config.KEY_FILE_LENGTH];

                            String mes = JsonUtil.EncodeStr(Config.KEY_HEAD, Config.HEAD_SEND_START);//告诉对方开始传输
                            StartSend(mes);
                        }
                        else if (dic[Config.KEY_HEAD].Equals(Config.HEAD_SEND_OVER))
                        {
                            //通知服务器文件发送完毕
                            send_over = true;
                        }
                        else if (dic[Config.KEY_HEAD].Equals(Config.HEAD_GO_ON))
                        {
                            //通知对方继续发送文件内容
                            go_on = true;
                        }
                        else if (dic[Config.KEY_HEAD].Equals(Config.HEAD_SEND_START))
                        {
                            //开始发送文件


                            StartFileSend(fpath);
                        }

                        #endregion
                    }
                    else if (buffer[0] == Config.VALUE_TYPE_FILE_CONT)
                    {
                        #region 接收文件

                        String path = @"C:\Users\Cui\Desktop\" + fileName;
                        if (fs == null)
                        {
                            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                        }

                        fs.Write(buffer, 1, r - 1);
                        FileHelper.setReceivedLength(r - 1);

                        if (FileHelper.getReceivedLength() == long.Parse(fileLength))
                        {
                            StartSend(JsonUtil.EncodeStr(Config.KEY_HEAD, Config.HEAD_SEND_OVER));
                            if (fs != null)
                            {
                                fs.Close();
                                fs = null;
                            }
                            FileHelper.resetreceivedLength();
                        }
                        else
                        {
                            StartSend(JsonUtil.EncodeStr(Config.KEY_HEAD, Config.HEAD_GO_ON));
                        }

                        #endregion
                    }
                }
                catch { }
                finally
                {

                }
            }
        }

        public void StartSend(String str)
        {
            Thread sendThread = new Thread(Send);
            sendThread.IsBackground = true;
            sendThread.Start(str);
        }

        /// <summary>
        /// 服务器向客户端发送文本消息
        /// </summary>
        /// <param name="o"></param>
        private void Send(object obj)
        {
            String mes = obj.ToString();

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(mes);
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newBuffer = list.ToArray();
            int messageLength = socketChat.Send(newBuffer);

        }

        /// <summary>
        /// 开启线程开始发送文件
        /// </summary>
        /// <param name="filePath"></param>
        public void StartFileSend(String filePath)
        {
            Thread fileSendTh = new Thread(FileSend);
            fileSendTh.IsBackground = true;
            fileSendTh.Start(filePath);
        }

        /// <summary>
        /// 发送文件
        /// </summary>
        private void FileSend(object obj)
        {
            String filePath = obj.ToString();
            using (FileStream fsRead = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[Config.BUFFER_SIZE];
                int r;
                while ((r = fsRead.Read(buffer, 0, buffer.Length - 1)) > 0)
                {
                    if (!send_over)
                    {
                        while (true)
                        {
                            if (go_on)
                            {
                                break;
                            }
                        }
                        List<byte> list = new List<byte>();
                        list.Add(1);
                        list.AddRange(buffer);
                        byte[] newBuffer = list.ToArray();
                        socketChat.Send(newBuffer, 0, r + 1, SocketFlags.None);

                        go_on = false;
                    }
                }
            }

        }

        /// <summary>
        /// 退出程序，关闭socket
        /// </summary>
        public void Exit()
        {
            if (socketWatch != null)
            {
                socketWatch.Close();
            }
            if (listenThread != null && listenThread.IsAlive)
            {
                listenThread.Abort();
            }
        }

    }
}
