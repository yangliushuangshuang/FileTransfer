using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FT_PC
{
    public partial class mainForm : Form
    {
        private Color defaultColor = Color.FromArgb(15, 121, 255);
        private Color mouseOnColor = Color.FromArgb(3, 100, 200);
        private connectWindows cWindow;
        public historyWindows hWindow;

        private NetConnect netConnect;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            netConnect = new NetConnect();

            FormBorderStyle = FormBorderStyle.None;
            cWindow = new connectWindows();
            hWindow = new historyWindows();
            initUI();
        }


        public void initUI()
        {
            cWindow.Show();
            identifer_connectWf.Visible = true;
            identifer_recoderWf.Visible = false;
            gbWindows.Controls.Clear();
            gbWindows.Controls.Add(cWindow);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_connetWindow_Click(object sender, EventArgs e)
        {
            identifer_connectWf.Visible = true;
            identifer_recoderWf.Visible = false;
            cWindow.Show();
            gbWindows.Controls.Clear();
            gbWindows.Controls.Add(cWindow);
        }

        private void btn_historyWindow_Click(object sender, EventArgs e)
        {
            hWindow.Show();
            identifer_connectWf.Visible = false;
            identifer_recoderWf.Visible = true;
            gbWindows.Controls.Clear();
            gbWindows.Controls.Add(hWindow);
        }

        private void minSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackColor = mouseOnColor;
        }

        private void minSize_MouseEnter(object sender, EventArgs e)
        {
            minSize.BackColor = mouseOnColor;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackColor = defaultColor;
        }

        private void minSize_MouseLeave(object sender, EventArgs e)
        {
            minSize.BackColor = defaultColor;
        }

        #region 设置窗体的拖动
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        #endregion

        private void hotSpotImg_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("hellow");
        }

        private void hotSpotImg_MouseEnter(object sender, EventArgs e)
        {
            hotSpotImg.BackColor = mouseOnColor;
        }

        private void hotSpotImg_MouseLeave(object sender, EventArgs e)
        {
            hotSpotImg.BackColor = defaultColor;
        }

        private void hotSpotImg_MouseMove(object sender, MouseEventArgs e)
        {
            String str = "创建热点";
            if (tt_mainForm.GetToolTip(hotSpotImg)!=str)
            {
                tt_mainForm.SetToolTip(hotSpotImg, str);
            }
        }

        private void exit_MouseMove(object sender, MouseEventArgs e)
        {
            String str = "退出";
            if (tt_mainForm.GetToolTip(exit) != str)
            {
                tt_mainForm.SetToolTip(exit, str);
            }
        }

        private void minSize_MouseMove(object sender, MouseEventArgs e)
        {
            String str = "最小化";
            if (tt_mainForm.GetToolTip(minSize) != str)
            {
                tt_mainForm.SetToolTip(minSize, str);
            }
        }

        private void WIFIssidValue_MouseMove(object sender, MouseEventArgs e)
        {
            String str = " SSID：" + WIFIssidValue.Text.ToString();
            if (tt_mainForm.GetToolTip(WIFIssidValue) != str)
            {
                tt_mainForm.SetToolTip(WIFIssidValue, str);
            }
        }

        private void WIFIkeyValue_MouseMove(object sender, MouseEventArgs e)
        {
            String str = " KEY：" + WIFIkeyValue.Text.ToString();
            if (tt_mainForm.GetToolTip(WIFIkeyValue) != str)
            {
                tt_mainForm.SetToolTip(WIFIkeyValue, str);
            }
        }

        private void fileAcceptImg_MouseEnter(object sender, EventArgs e)
        {
            fileAcceptImg.BackColor = mouseOnColor;
        }

        private void fileAcceptImg_MouseLeave(object sender, EventArgs e)
        {
            fileAcceptImg.BackColor = defaultColor;
        }

        private void fileAcceptImg_MouseMove(object sender, MouseEventArgs e)
        {
            String str = "开启监听";
            if (tt_mainForm.GetToolTip(fileAcceptImg) != str)
            {
                tt_mainForm.SetToolTip(fileAcceptImg, str);
            }
        }

        private void fileAcceptImg_MouseClick(object sender, MouseEventArgs e)
        {
            if (netConnect.GetListenState())
            {
                MessageBox.Show("正在监听");
            }
            else
            {
                netConnect.StartListen();
                MessageBox.Show("已开启监听");
            }
        }

    }
}
