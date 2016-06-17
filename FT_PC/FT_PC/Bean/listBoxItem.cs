using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FT_PC
{
    class listBoxItem
    {
        public Image fileImg
        {
            get;
            set;
        }
        public String fileNmae
        {
            get;
            set;
        }
        public String timeToReceived
        {
            get;
            set;
        }
        public listBoxItem(Image fileImage,String fileName,String timeToReceived)
        {
            this.fileImg = fileImage;
            this.fileNmae = fileName;
            this.timeToReceived = timeToReceived;
        }
        public String formatStr()
        {
            String result;
            result = fileNmae + "&" + timeToReceived;
            return result;
        }
    }
}
