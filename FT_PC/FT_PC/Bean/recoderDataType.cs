using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT_PC
{
    class recoderDataType
    {
        public String filePath
        {
            get;
            set;
        }
        public String recTime
        {
            get;
            set;
        }
        public String formatRecoder(){
            String aRecoder;
            aRecoder = filePath + "&" + recTime;
            return aRecoder;
        }
        /// <summary>
        /// 将从文件中读取的字符串解析为文件路径和接收时间
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public String[] parserRecoder(String str)
        {
            String[] parseredRec = new String[2];
            int index = str.LastIndexOf("&");
            parseredRec[0] = str.Substring(0, index);
            parseredRec[1] = str.Substring(index + 1, str.Length - index - 1);
            return parseredRec;
        }
    }
}
