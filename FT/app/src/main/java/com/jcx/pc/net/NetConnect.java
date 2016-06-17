package com.jcx.pc.net;

import android.content.Context;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Environment;
import android.os.Message;
import android.widget.Toast;

import com.jcx.pc.configure.Config;
import com.jcx.pc.util.FileHelper;
import com.jcx.pc.util.HandleHelper;
import com.jcx.pc.util.JsonUtil;
import com.jcx.pc.util.NetUtil;
import com.jcx.pc.util.ProgressHelper;
import com.jcx.pc.util.ToastHelper;
import com.jcx.pc.util.UTF8Encoder;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.Map;
import android.os.Handler;
/**
 * Created by Cui on 2016/6/12.
 */
public class NetConnect {

    private static String IP = null;
    private int PORT = 12345;
    public static boolean isConnected = false;
    public String sendFilePath = null, recFilePath = null;
    private boolean go_on = true;//接收消息，查看文件是否接受完毕
    private boolean send_over = false;

    private static Socket socket = null;
    private static DataInputStream dis;
    private static DataOutputStream dos;
    private static FileOutputStream fos = null;

    private Context context = null;

    public NetConnect(Context context, String ip){
        this.context=context;
        this.IP = ip;
    }

    /**
     * 设置要传输的文件路径
     * @param filePath
     */
    public void setSendFilePath(String filePath){
        this.sendFilePath = filePath;
    }
    public void resetSendFilePath(){
        this.sendFilePath = null;
    }

    /**
     * 连接服务器
     */
    public void connect() {

        AsyncTask<Void, String, Void> read = new AsyncTask<Void, String, Void>() {
            @Override
            protected Void doInBackground(Void... params) {
                try {
                    socket = new Socket(IP, PORT);
                    dis = new DataInputStream(new BufferedInputStream(socket.getInputStream()));
                    dos = new DataOutputStream(new BufferedOutputStream(socket.getOutputStream()));

                    publishProgress("@success");
                    isConnected =true;
                } catch (IOException e) {
                    System.out.println("服务器连接失败");
                    publishProgress("@fail");
                    e.printStackTrace();
                }
                if (isConnected) {
                    System.out.println("服务器连接成功");
                    receive();
                }

                return null;
            }

            @Override
            protected void onProgressUpdate(String... values) {

                if (values[0].equals("@success")) {
                    Toast.makeText(context, "连接服务器成功！", Toast.LENGTH_SHORT).show();
                    isConnected = true;
                } else if (values[0].equals("@fail")) {
                    Toast.makeText(context, "连接服务器失败", Toast.LENGTH_SHORT).show();
                    isConnected = false;
                }

                super.onProgressUpdate(values);

            }
        };
        read.execute();
    }

    /**
     * 向服务器发送消息
     */
    public void send(final String message){

        if (!isConnected) {
            Toast.makeText(context, "请链接服务器", Toast.LENGTH_SHORT).show();
        }else {

            Runnable sendTh=new Runnable() {
                @Override
                public void run() {
                    try {
                        byte[] buffer = message.getBytes();

                        byte[] head =new byte[1];
                        head[0] = 0;
                        byte[] newBuffer = NetUtil.AddHead(head,buffer);

                        dos.write(newBuffer);
                        dos.flush();

                        System.out.println("发送成功  "+message);

                    } catch (IOException e) {

                        System.out.println("发送发生异常");
                        e.printStackTrace();
                    }
                }
            };
            sendTh.run();
        }
    }

    /**
     * 从服务器接收消息
     *
     * @return
     */
    private String fileName = null;
    private Long fileLength = 0L;

    public String receive() {

        String result = null;

        if (isConnected) {
            new AsyncTask<Void, String, String>() {
                @Override
                protected String doInBackground(Void... params) {

                    while (true) {
                        try {
                            System.out.println("开始接收");

                            byte[] buffer = new byte[Config.BUFFER_SIZE];
                            int r = dis.read(buffer,0,buffer.length);

                            if (r <= 0) {
                                isConnected = false;
                                break;
                            }

                            if (buffer[0] == Config.VALUE_TYPE_FILE_INFO) {
                                System.out.println("接收的是文件信息");
                                //----------------------------------------------TODO 接收文件信息

                                byte[] mes = NetUtil.GetContent(buffer);
                                String mesRec = new String(mes, 0, r-1);
                                System.out.println("收到的内容 "+mesRec);

                                Map<String, String> map = JsonUtil.ParserStr(mesRec);
                                if (map == null) {
                                    System.out.println("收到的数据有问题");
                                    break;
                                }
                                //询问连接状态
                                if (map.get(Config.KEY_HEAD).equals(Config.HEAD_CON_ASK))
                                {
                                    String ansMes = UTF8Encoder.Encode(JsonUtil.EncodeStr(Config.KEY_HEAD,Config.HEAD_CON_OK));
                                    send(ansMes); // 响应连接状态询问，返回已连接

                                }else if (map.get(Config.KEY_HEAD).equals(Config.HEAD_CON_OK))
                                {
                                    System.out.println("已建立连接，可以传输数据了");

                                    publishProgress(Config.HEAD_CON_OK);

                                }else if (map.get(Config.KEY_HEAD).equals(Config.HEAD_FILE_INFO))
                                {
                                    fileName = map.get(Config.KEY_FILE_NAME);
                                    fileLength = Long.parseLong(map.get(Config.KEY_FILE_LENGTH));

                                    publishProgress(Config.REC_BEGIN);

                                }else if (map.get(Config.KEY_HEAD).equals(Config.HEAD_SEND_OVER))
                                {
                                    System.out.println("接收文件完毕");

                                    publishProgress(Config.HEAD_SEND_OVER);
                                    send_over = true;

                                }else if(map.get(Config.KEY_HEAD).equals(Config.HEAD_GO_ON))
                                {
                                    System.out.println("继续传输文件");

                                    go_on = true;
                                }else if(map.get(Config.KEY_HEAD).equals(Config.HEAD_SEND_START))
                                {
                                    System.out.println("开始传输文件");
                                    //-------------------------------------------TODO 传输文件开始
                                    publishProgress(Config.HEAD_SEND_START);
                                }

                                //------------------------------------------------END
                            }else if (buffer[0] == Config.VALUE_TYPE_FILE_CONT) {
                                System.out.println("接收的是文件内容");
                                //-----------------------------------------------TODO 接收文件

                                try {
                                    if (fos == null) {
                                        recFilePath = FileHelper.newFile(fileName);
                                        fos = new FileOutputStream(recFilePath);
                                    }

                                    fos.write(buffer, 1, r-1);
                                    fos.flush();

                                    publishProgress(Integer.toString(r-1));//更新进度条

                                    String ansMes = null;

                                    FileHelper.setReceivedLength(r-1);
                                    System.out.println(FileHelper.getReceivedLength());
                                    if (FileHelper.getReceivedLength() == fileLength)
                                    {
                                        ansMes = UTF8Encoder.Encode(JsonUtil.EncodeStr(Config.KEY_HEAD,Config.HEAD_SEND_OVER));
                                        publishProgress(Config.REC_OVER);
                                        FileHelper.resetreceivedLength();
                                    }else
                                    {
                                        ansMes = UTF8Encoder.Encode(JsonUtil.EncodeStr(Config.KEY_HEAD,Config.HEAD_GO_ON));
                                    }
                                    send(ansMes);
                                    
                                } catch (Exception e1) {
                                    e1.printStackTrace();
                                    publishProgress(Config.REC_FAIL);
                                }

                                //-------------------------------------------------END
                            }

                        } catch (IOException e) {
                            e.printStackTrace();
                            System.out.println("接收发生异常");
                            publishProgress(Config.CONN_FAIL);
                            isConnected = false;
                        }
                    }
                    return null;
                }

                @Override
                protected void onProgressUpdate(String... values) {
                    super.onProgressUpdate(values);

                    switch (values[0]){
                        case Config.HEAD_CON_OK:
                            ToastHelper.ShowToast(context,"连接已建立，可以发送文件");

                            File file = new File(sendFilePath);
                            String fname = file.getName();
                            String flength = String.valueOf(file.length());
                            String fileInfo = UTF8Encoder.Encode(JsonUtil.EncodeStr(Config.KEY_HEAD,Config.HEAD_FILE_INFO,Config.KEY_FILE_NAME,fname,Config.KEY_FILE_LENGTH,flength));
                            send(fileInfo);
                            System.out.println("发送文件信息成功："+fileInfo);

                            break;
                        case Config.HEAD_SEND_START:
                            File fileTemp = new File(sendFilePath);
                            String fnameTemp = fileTemp.getName();
                            String flengthTemp = String.valueOf(fileTemp.length());
                            ProgressHelper.ShowProgress(context,Integer.parseInt(flengthTemp),"发送文件",fnameTemp);

                            sendFile(sendFilePath);
                            resetSendFilePath();
                            break;
                        case Config.HEAD_SEND_OVER:
                            ToastHelper.ShowToast(context,"发送文件成功");
                            break;
                        case Config.CONN_FAIL:
                            ToastHelper.ShowToast(context,"连接服务器失败");
                            break;

                        case Config.REC_FAIL:
                            ToastHelper.ShowToast(context,"接收文件发生异常");
                            break;
                        case Config.REC_BEGIN: //-----------------------TODO 接收文件显示进度条
                            ProgressHelper.ShowProgress(context,fileLength.intValue(),"接收文件",fileName);
                            send(UTF8Encoder.Encode(JsonUtil.EncodeStr(Config.KEY_HEAD,Config.HEAD_SEND_START)));//通知对方开始传输文件
                            break;
                        case Config.REC_OVER:
                            ToastHelper.ShowToast(context,"接收文件成功");
                            if (fos != null) {
                                try {
                                    fos.close();
                                    fos = null;
                                    System.out.println("fileoutputstream关闭");
                                } catch (IOException e) {
                                    e.printStackTrace();
                                }
                            }
                            ProgressHelper.DissmissProgress();
                            break;
                        default: //-------------------------TODO 接收文件更新进度条
                            ProgressHelper.UpdateProgress(Integer.parseInt(values[0]));
                            break;
                    }
                }
            }.execute();
        }else
        {
            System.out.println("连接服务器失败");
        }

        return result;
    }

    private Handler handler = new Handler() {
        @Override
        public void handleMessage(Message msg) {

            switch (msg.what)
            {
                case -1:
                case -2:
                    ProgressHelper.DissmissProgress();//关闭进度条
                    System.out.println("发送文件结束");
                    break;
                default:
                    ProgressHelper.UpdateProgress(msg.what);//更新进度条
                    break;
            }

            super.handleMessage(msg);

        }
    };

    /**
     * 向服务端发送文件
     */
    public void sendFile(final String filePath) {

        if (filePath == null) {
            System.out.println("路径名不能为空");
            return;
        }
        final File file = new File(filePath);
        if (!file.exists()) {
            System.out.println("文件不存在");
            return;
        }
        if (filePath != null || !file.isDirectory()) {

            new Thread() {
                @Override
                public void run() {

                    //发送文件
                    BufferedInputStream bis = null;
                    try {
                        bis = new BufferedInputStream(new FileInputStream(file));//读出文件流放入到缓存中

                        int r = 0;
                        byte[] buffer = new byte[Config.BUFFER_SIZE];

                        System.out.println("sendfile-------开始发送文件");
                        while ((r = bis.read(buffer, 0, buffer.length-1)) != -1) {
                            if (!send_over) {
                                while (true){
                                    if (go_on) {
                                        break;
                                    }
                                }
                                byte[] head =new byte[1];
                                head[0] = 1;
                                byte[] newBuffer = NetUtil.AddHead(head,buffer);

                                dos.write(newBuffer, 0, r+1);
                                dos.flush();

                                Message message = Message.obtain();
                                message.what = r;
                                handler.sendMessage(message);

                                go_on = false;
                            }

                        }
                        System.out.println("发送文件成功");
                        Message message = Message.obtain();
                        message.what = -1;
                        handler.sendMessage(message);

                    } catch (Exception e) {
                        System.out.println("发送文件发生异常");
                        Message message = Message.obtain();
                        message.what = -2;
                        handler.sendMessage(message);

                        e.printStackTrace();
                    } finally {
                        try {
                            //使用完毕后，应关闭输入、输出流和socket
                            if (bis != null) bis.close();
                        } catch (IOException e) {
                            e.printStackTrace();
                        }
                    }

                }
            }.start();

        }else{
            ToastHelper.ShowToast(context,"请选择要发送的文件/请不要选择文件夹");
        }
    }

}
