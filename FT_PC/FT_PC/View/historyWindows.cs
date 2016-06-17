using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FT_PC
{
    public partial class historyWindows : UserControl
    {
        private Color lineColor = Color.FromArgb(240, 244, 249);
        private Color focusedColor = Color.FromArgb(102, 206, 255);
        private Color timeBrushColor = Color.FromArgb(140, 140, 147);
        private transferRecoder fileOper;
        public historyWindows()
        {
            InitializeComponent();
        }

        List<listBoxItem> list = new List<listBoxItem>();
        private void historyWindows_Load(object sender, EventArgs e)
        {
            lb_historyFiles.ItemHeight = 20;
            lb_historyFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(listBox1_DrawItem);

            #region 测试用
            //    recoderDataType data;
        //    fileOper = new transferRecoder();
        //    List<String> tempList = new List<String>();
        //    for (int i = 0; i < 30; i++)
        //    {
        //        data = new recoderDataType();
        //        data.filePath = i.ToString();
        //        data.recTime = GetTime.getTime();
        //        tempList.Add(data.formatRecoder());
        //    }
        //    String[] tempStr = tempList.ToArray();
            //    fileOper.addRecoder(tempStr);
            #endregion

            #region 从文件中获得数据,并显示到界面上
            listBoxItem item;
            String[] fileRecoder = new transferRecoder().readRecoder();
            recoderDataType dataParser = new recoderDataType();
            for (int i = 0; i < fileRecoder.Length; i++)
            {
                item = new listBoxItem(null, dataParser.parserRecoder(fileRecoder[i])[0], dataParser.parserRecoder(fileRecoder[i])[1]);
                list.Add(item);
                lb_historyFiles.Items.Add(item);
            }
            #endregion
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                using (SolidBrush brush = new SolidBrush(focusedColor))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
            }
            else
            {
                if (e.Index % 2 == 0)
                {
                    using (SolidBrush brush = new SolidBrush(lineColor))
                    {
                        e.Graphics.FillRectangle(brush, e.Bounds);
                    }
                }
            }

            Brush myBrush = Brushes.Black;  //初始化字体颜色=黑色
            StringFormat strFmt = new System.Drawing.StringFormat();
            strFmt.LineAlignment = StringAlignment.Center; //文本垂直居中
            strFmt.Trimming = StringTrimming.EllipsisCharacter;//超出矩形范围的部分用省略号表示

            if (list[e.Index].fileImg != null) //在项右侧 画图标  
            {
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;

                e.Graphics.DrawImage(list[e.Index].fileImg, (e.Bounds.Right + 2), e.Bounds.Top + 2, 20, 26);
            }
            #region 将时间显示到item上
            //Font f = new Font("微软雅黑", 9, FontStyle.Regular);
            //SolidBrush timeBrush = new SolidBrush(timeBrushColor);
            //SizeF size = e.Graphics.MeasureString(list[e.Index].timeToReceived, f); //获取项文本尺寸
            //RectangleF rectF = new RectangleF((e.Bounds.Right - size.Width - 6), e.Bounds.Top, (size.Width + 6), (e.Bounds.Height));
            //e.Graphics.DrawString(list[e.Index].timeToReceived, f, timeBrush, rectF, strFmt);
            #endregion

            RectangleF rectFExpImg = new RectangleF((e.Bounds.Left + 26 + 20), e.Bounds.Top, (e.Bounds.Width - 46), e.Bounds.Height);
            e.Graphics.DrawString(list[e.Index].fileNmae, e.Font, myBrush, rectFExpImg, strFmt);
        }

        private void lb_historyFiles_MouseUp(object sender, MouseEventArgs e)
        {
            #region 获得当前鼠标点击的item位置
            int posindex = lb_historyFiles.IndexFromPoint(new Point(e.X, e.Y));
            lb_historyFiles.ContextMenuStrip = null;
            if (posindex >= 0 && posindex < lb_historyFiles.Items.Count)
            {
                lb_historyFiles.SelectedIndex = posindex;
            }
            #endregion

            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(this, e.Location);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int selectedItemIndex = lb_historyFiles.SelectedIndex;
            String temp = list[selectedItemIndex].formatStr();
            if (fileOper == null)
            {
                fileOper = new transferRecoder();
            }
            fileOper.deleteRecoder(temp);
            lb_historyFiles.Items.RemoveAt(selectedItemIndex);
            list.RemoveAt(selectedItemIndex);
            lb_historyFiles.Refresh();
        }

        private void lb_historyFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void lb_historyFiles_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lb_historyFiles.IndexFromPoint(e.Location);
            if (index != -1 && index < lb_historyFiles.Items.Count)
            {
                String infoShowInTT=list[index].fileNmae+"   "+list[index].timeToReceived;
                if (tt_item.GetToolTip(lb_historyFiles) != infoShowInTT)
                {
                    tt_item.SetToolTip(lb_historyFiles,infoShowInTT);
                }
            }
        }
    }
}
