namespace FT_PC
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minSize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileAcceptImg = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WiFiSSIDandKEY = new System.Windows.Forms.Panel();
            this.WIFIkeyValue = new System.Windows.Forms.TextBox();
            this.WIFIssidValue = new System.Windows.Forms.TextBox();
            this.WifiKEY = new System.Windows.Forms.Label();
            this.WifiSSID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hotSpotImg = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_connetWindow = new System.Windows.Forms.Button();
            this.btn_historyWindow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.identifer_recoderWf = new System.Windows.Forms.Panel();
            this.identifer_connectWf = new System.Windows.Forms.Panel();
            this.gbWindows = new System.Windows.Forms.GroupBox();
            this.tt_mainForm = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileAcceptImg)).BeginInit();
            this.WiFiSSIDandKEY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotSpotImg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minSize);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "FT";
            // 
            // minSize
            // 
            this.minSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.minSize.Image = global::FT_PC.Properties.Resources.minimum;
            this.minSize.Location = new System.Drawing.Point(253, 1);
            this.minSize.Margin = new System.Windows.Forms.Padding(0);
            this.minSize.Name = "minSize";
            this.minSize.Size = new System.Drawing.Size(26, 26);
            this.minSize.TabIndex = 0;
            this.minSize.TabStop = false;
            this.minSize.Click += new System.EventHandler(this.minSize_Click);
            this.minSize.MouseEnter += new System.EventHandler(this.minSize_MouseEnter);
            this.minSize.MouseLeave += new System.EventHandler(this.minSize_MouseLeave);
            this.minSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minSize_MouseMove);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit.Image = global::FT_PC.Properties.Resources.exit;
            this.exit.InitialImage = null;
            this.exit.Location = new System.Drawing.Point(283, 1);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 26);
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.fileAcceptImg);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.WiFiSSIDandKEY);
            this.panel2.Controls.Add(this.hotSpotImg);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Font = new System.Drawing.Font("宋体", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 120);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // fileAcceptImg
            // 
            this.fileAcceptImg.Image = global::FT_PC.Properties.Resources.accept_file1;
            this.fileAcceptImg.Location = new System.Drawing.Point(242, 47);
            this.fileAcceptImg.Name = "fileAcceptImg";
            this.fileAcceptImg.Size = new System.Drawing.Size(50, 50);
            this.fileAcceptImg.TabIndex = 4;
            this.fileAcceptImg.TabStop = false;
            this.fileAcceptImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fileAcceptImg_MouseClick);
            this.fileAcceptImg.MouseEnter += new System.EventHandler(this.fileAcceptImg_MouseEnter);
            this.fileAcceptImg.MouseLeave += new System.EventHandler(this.fileAcceptImg_MouseLeave);
            this.fileAcceptImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fileAcceptImg_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(231, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 48);
            this.panel4.TabIndex = 3;
            // 
            // WiFiSSIDandKEY
            // 
            this.WiFiSSIDandKEY.Controls.Add(this.WIFIkeyValue);
            this.WiFiSSIDandKEY.Controls.Add(this.WIFIssidValue);
            this.WiFiSSIDandKEY.Controls.Add(this.WifiKEY);
            this.WiFiSSIDandKEY.Controls.Add(this.WifiSSID);
            this.WiFiSSIDandKEY.Controls.Add(this.pictureBox1);
            this.WiFiSSIDandKEY.Location = new System.Drawing.Point(74, 42);
            this.WiFiSSIDandKEY.Name = "WiFiSSIDandKEY";
            this.WiFiSSIDandKEY.Size = new System.Drawing.Size(157, 63);
            this.WiFiSSIDandKEY.TabIndex = 1;
            // 
            // WIFIkeyValue
            // 
            this.WIFIkeyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.WIFIkeyValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WIFIkeyValue.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WIFIkeyValue.ForeColor = System.Drawing.Color.White;
            this.WIFIkeyValue.Location = new System.Drawing.Point(55, 35);
            this.WIFIkeyValue.Name = "WIFIkeyValue";
            this.WIFIkeyValue.Size = new System.Drawing.Size(100, 18);
            this.WIFIkeyValue.TabIndex = 6;
            this.WIFIkeyValue.Text = "***";
            this.WIFIkeyValue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WIFIkeyValue_MouseMove);
            // 
            // WIFIssidValue
            // 
            this.WIFIssidValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.WIFIssidValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WIFIssidValue.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WIFIssidValue.ForeColor = System.Drawing.Color.White;
            this.WIFIssidValue.Location = new System.Drawing.Point(55, 11);
            this.WIFIssidValue.Name = "WIFIssidValue";
            this.WIFIssidValue.Size = new System.Drawing.Size(100, 18);
            this.WIFIssidValue.TabIndex = 5;
            this.WIFIssidValue.Text = "***";
            this.WIFIssidValue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WIFIssidValue_MouseMove);
            // 
            // WifiKEY
            // 
            this.WifiKEY.AutoSize = true;
            this.WifiKEY.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WifiKEY.ForeColor = System.Drawing.Color.White;
            this.WifiKEY.Location = new System.Drawing.Point(4, 32);
            this.WifiKEY.Name = "WifiKEY";
            this.WifiKEY.Size = new System.Drawing.Size(58, 21);
            this.WifiKEY.TabIndex = 4;
            this.WifiKEY.Text = "密码：";
            // 
            // WifiSSID
            // 
            this.WifiSSID.AutoSize = true;
            this.WifiSSID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WifiSSID.ForeColor = System.Drawing.Color.White;
            this.WifiSSID.Location = new System.Drawing.Point(4, 8);
            this.WifiSSID.Name = "WifiSSID";
            this.WifiSSID.Size = new System.Drawing.Size(58, 21);
            this.WifiSSID.TabIndex = 3;
            this.WifiSSID.Text = "名称：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-56, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // hotSpotImg
            // 
            this.hotSpotImg.Image = global::FT_PC.Properties.Resources.hotSpot1;
            this.hotSpotImg.Location = new System.Drawing.Point(18, 47);
            this.hotSpotImg.Name = "hotSpotImg";
            this.hotSpotImg.Size = new System.Drawing.Size(50, 50);
            this.hotSpotImg.TabIndex = 2;
            this.hotSpotImg.TabStop = false;
            this.hotSpotImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hotSpotImg_MouseClick);
            this.hotSpotImg.MouseEnter += new System.EventHandler(this.hotSpotImg_MouseEnter);
            this.hotSpotImg.MouseLeave += new System.EventHandler(this.hotSpotImg_MouseLeave);
            this.hotSpotImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hotSpotImg_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleDescription = "";
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.Controls.Add(this.btn_connetWindow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_historyWindow, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("宋体", 1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 121);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 36);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_connetWindow
            // 
            this.btn_connetWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connetWindow.CausesValidation = false;
            this.btn_connetWindow.FlatAppearance.BorderSize = 0;
            this.btn_connetWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connetWindow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connetWindow.Location = new System.Drawing.Point(0, 0);
            this.btn_connetWindow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_connetWindow.Name = "btn_connetWindow";
            this.btn_connetWindow.Size = new System.Drawing.Size(149, 36);
            this.btn_connetWindow.TabIndex = 0;
            this.btn_connetWindow.Text = "连接设备";
            this.btn_connetWindow.UseVisualStyleBackColor = true;
            this.btn_connetWindow.Click += new System.EventHandler(this.btn_connetWindow_Click);
            // 
            // btn_historyWindow
            // 
            this.btn_historyWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_historyWindow.FlatAppearance.BorderSize = 0;
            this.btn_historyWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historyWindow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_historyWindow.Location = new System.Drawing.Point(149, 0);
            this.btn_historyWindow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_historyWindow.Name = "btn_historyWindow";
            this.btn_historyWindow.Size = new System.Drawing.Size(161, 36);
            this.btn_historyWindow.TabIndex = 1;
            this.btn_historyWindow.Text = "传输记录";
            this.btn_historyWindow.UseVisualStyleBackColor = true;
            this.btn_historyWindow.Click += new System.EventHandler(this.btn_historyWindow_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.gbWindows);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 600);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.identifer_recoderWf);
            this.panel5.Controls.Add(this.identifer_connectWf);
            this.panel5.Location = new System.Drawing.Point(1, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 2);
            this.panel5.TabIndex = 1;
            // 
            // identifer_recoderWf
            // 
            this.identifer_recoderWf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.identifer_recoderWf.Location = new System.Drawing.Point(152, 0);
            this.identifer_recoderWf.Name = "identifer_recoderWf";
            this.identifer_recoderWf.Size = new System.Drawing.Size(156, 2);
            this.identifer_recoderWf.TabIndex = 0;
            // 
            // identifer_connectWf
            // 
            this.identifer_connectWf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.identifer_connectWf.Location = new System.Drawing.Point(1, 0);
            this.identifer_connectWf.Name = "identifer_connectWf";
            this.identifer_connectWf.Size = new System.Drawing.Size(146, 2);
            this.identifer_connectWf.TabIndex = 0;
            // 
            // gbWindows
            // 
            this.gbWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbWindows.Location = new System.Drawing.Point(1, 159);
            this.gbWindows.Margin = new System.Windows.Forms.Padding(0);
            this.gbWindows.Name = "gbWindows";
            this.gbWindows.Padding = new System.Windows.Forms.Padding(0);
            this.gbWindows.Size = new System.Drawing.Size(310, 440);
            this.gbWindows.TabIndex = 3;
            this.gbWindows.TabStop = false;
            this.gbWindows.Text = "gbWinodws";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(312, 600);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileAcceptImg)).EndInit();
            this.WiFiSSIDandKEY.ResumeLayout(false);
            this.WiFiSSIDandKEY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotSpotImg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox minSize;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_connetWindow;
        private System.Windows.Forms.Button btn_historyWindow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbWindows;
        private System.Windows.Forms.PictureBox hotSpotImg;
        private System.Windows.Forms.Panel WiFiSSIDandKEY;
        private System.Windows.Forms.Label WifiKEY;
        private System.Windows.Forms.Label WifiSSID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox WIFIkeyValue;
        private System.Windows.Forms.TextBox WIFIssidValue;
        private System.Windows.Forms.ToolTip tt_mainForm;
        private System.Windows.Forms.Panel identifer_connectWf;
        private System.Windows.Forms.Panel identifer_recoderWf;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox fileAcceptImg;
    }
}

