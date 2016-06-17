namespace FT_PC
{
    partial class connectWindows
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.qrCode = new System.Windows.Forms.PictureBox();
            this.btn_selectFile = new System.Windows.Forms.Button();
            this.sendFileBy_hotSpot = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.file_size = new System.Windows.Forms.Label();
            this.persent = new System.Windows.Forms.Label();
            this.lb_fileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qrCode
            // 
            this.qrCode.Location = new System.Drawing.Point(79, 226);
            this.qrCode.Name = "qrCode";
            this.qrCode.Size = new System.Drawing.Size(143, 129);
            this.qrCode.TabIndex = 0;
            this.qrCode.TabStop = false;
            this.qrCode.Visible = false;
            // 
            // btn_selectFile
            // 
            this.btn_selectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_selectFile.FlatAppearance.BorderSize = 0;
            this.btn_selectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_selectFile.Location = new System.Drawing.Point(0, 0);
            this.btn_selectFile.Margin = new System.Windows.Forms.Padding(0);
            this.btn_selectFile.Name = "btn_selectFile";
            this.btn_selectFile.Size = new System.Drawing.Size(310, 27);
            this.btn_selectFile.TabIndex = 1;
            this.btn_selectFile.Text = "选择文件";
            this.btn_selectFile.UseVisualStyleBackColor = false;
            this.btn_selectFile.Click += new System.EventHandler(this.btn_selectFile_Click);
            // 
            // sendFileBy_hotSpot
            // 
            this.sendFileBy_hotSpot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendFileBy_hotSpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sendFileBy_hotSpot.FlatAppearance.BorderSize = 0;
            this.sendFileBy_hotSpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendFileBy_hotSpot.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendFileBy_hotSpot.Location = new System.Drawing.Point(0, 29);
            this.sendFileBy_hotSpot.Margin = new System.Windows.Forms.Padding(0);
            this.sendFileBy_hotSpot.Name = "sendFileBy_hotSpot";
            this.sendFileBy_hotSpot.Size = new System.Drawing.Size(310, 27);
            this.sendFileBy_hotSpot.TabIndex = 1;
            this.sendFileBy_hotSpot.Text = "通过热点发送文件";
            this.sendFileBy_hotSpot.UseVisualStyleBackColor = false;
            this.sendFileBy_hotSpot.Click += new System.EventHandler(this.sendFileBy_hotSpot_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 11);
            this.progressBar1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.file_size);
            this.panel1.Controls.Add(this.persent);
            this.panel1.Controls.Add(this.lb_fileName);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 90);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // file_size
            // 
            this.file_size.AutoSize = true;
            this.file_size.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.file_size.Location = new System.Drawing.Point(239, 59);
            this.file_size.Name = "file_size";
            this.file_size.Size = new System.Drawing.Size(56, 17);
            this.file_size.TabIndex = 5;
            this.file_size.Text = "文件大小";
            // 
            // persent
            // 
            this.persent.AutoSize = true;
            this.persent.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.persent.Location = new System.Drawing.Point(13, 59);
            this.persent.Name = "persent";
            this.persent.Size = new System.Drawing.Size(32, 17);
            this.persent.TabIndex = 4;
            this.persent.Text = "进度";
            // 
            // lb_fileName
            // 
            this.lb_fileName.AutoSize = true;
            this.lb_fileName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_fileName.Location = new System.Drawing.Point(11, 8);
            this.lb_fileName.Name = "lb_fileName";
            this.lb_fileName.Size = new System.Drawing.Size(70, 20);
            this.lb_fileName.TabIndex = 3;
            this.lb_fileName.Text = "fileName";
            // 
            // connectWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sendFileBy_hotSpot);
            this.Controls.Add(this.btn_selectFile);
            this.Controls.Add(this.qrCode);
            this.Name = "connectWindows";
            this.Size = new System.Drawing.Size(310, 440);
            this.Load += new System.EventHandler(this.connectWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox qrCode;
        private System.Windows.Forms.Button btn_selectFile;
        private System.Windows.Forms.Button sendFileBy_hotSpot;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label file_size;
        private System.Windows.Forms.Label persent;
        private System.Windows.Forms.Label lb_fileName;
    }
}
