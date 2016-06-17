using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT_PC
{
    class FileHelper
    {
        public static long receivedLength = 0;

        public static void setReceivedLength(long length)
        {
            receivedLength = receivedLength + length;
        }

        public static long getReceivedLength()
        {
            return receivedLength;
        }

        public static void resetreceivedLength()
        {
            receivedLength = 0;
        }

        /// <summary>
        /// 获得文件大小
        /// </summary>
        /// <param name="filePath">文件的路径</param>
        /// <returns></returns>
        public static long GetFileSize(String filePath)
        {
            long fileSize = 0L;
            if (filePath!="")
            {
                FileInfo fi = new FileInfo(filePath);
                fileSize = fi.Length; //返回文件字节大小
            }
           
            return fileSize;
        }

        /// <summary>
        /// 从文件路径中获得文件的名字
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static String GetFileName(String filePath)
        {
            String fileName = null;

            int index = filePath.LastIndexOf("\\");
            fileName = filePath.Substring(index + 1, filePath.Length - 1 - index);

            return fileName;
        }
    }
}
