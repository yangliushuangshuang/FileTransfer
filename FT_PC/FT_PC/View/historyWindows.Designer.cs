namespace FT_PC
{
    partial class historyWindows
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
            this.components = new System.ComponentModel.Container();
            this.lb_historyFiles = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.reName = new System.Windows.Forms.ToolStripMenuItem();
            this.tt_item = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_historyFiles
            // 
            this.lb_historyFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_historyFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lb_historyFiles.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_historyFiles.FormattingEnabled = true;
            this.lb_historyFiles.ItemHeight = 20;
            this.lb_historyFiles.Location = new System.Drawing.Point(0, 0);
            this.lb_historyFiles.Margin = new System.Windows.Forms.Padding(0);
            this.lb_historyFiles.Name = "lb_historyFiles";
            this.lb_historyFiles.Size = new System.Drawing.Size(310, 442);
            this.lb_historyFiles.TabIndex = 0;
            this.lb_historyFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.lb_historyFiles.SelectedIndexChanged += new System.EventHandler(this.lb_historyFiles_SelectedIndexChanged);
            this.lb_historyFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_historyFiles_MouseMove);
            this.lb_historyFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lb_historyFiles_MouseUp);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete,
            this.reName});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(113, 48);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 22);
            this.delete.Text = "删除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reName
            // 
            this.reName.Name = "reName";
            this.reName.Size = new System.Drawing.Size(112, 22);
            this.reName.Text = "重命名";
            // 
            // historyWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lb_historyFiles);
            this.Name = "historyWindows";
            this.Size = new System.Drawing.Size(310, 440);
            this.Load += new System.EventHandler(this.historyWindows_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_historyFiles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem reName;
        private System.Windows.Forms.ToolTip tt_item;



    }
}
