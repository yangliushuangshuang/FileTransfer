using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FT_PC
{
    public partial class connectWindows : UserControl
    {
        private NetConnect netConnect;

        public connectWindows()
        {
            InitializeComponent();
            
        }

        private void connectWindows_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            netConnect = new NetConnect();
        }

        private void sendFileBy_hotSpot_Click(object sender, EventArgs e)
        {
            netConnect.StartSend(JsonUtil.EncodeStr(Config.KEY_HEAD, Config.HEAD_CON_ASK));
        }

        private void openFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要发送的文件";
            ofd.Multiselect = false;
            ofd.Filter = "文本文件|*.text|视频文件|*.mp4|音乐文件|*.mp3|图片文件|*.jpg|所有文件|*.*";
            ofd.ShowDialog();
        }

        private void btn_selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Cui\Desktop";
            ofd.Title = "请选择将要发送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();
            //tb_filePath.Text = ofd.FileName;
            String filePath = ofd.FileName;
            String flength = FileHelper.GetFileSize(filePath).ToString();
            NetConnect.setFileInfo(filePath, flength);
        }


    }
}
