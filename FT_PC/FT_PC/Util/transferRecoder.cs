using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FT_PC
{
    class transferRecoder
    {
        private String defaultDirectory = @"C:\Users\Public\Documents\ftFiles";
        private String defaultPath = @"C:\Users\Public\Documents\ftFiles\transferRecoder.txt";

        public transferRecoder()
        {
        }

        /// <summary>
        /// 判断默认文件夹是否存在
        /// </summary>
        /// <returns>
        /// 1://默认文件夹和默认文件存在
        /// 0://默认文件夹存在，但文件不存在
        /// -1://文件夹，文件都不存在
        /// </returns>
        public int fileIsExist()
        {
            if (Directory.Exists(defaultDirectory))
            {
                if (File.Exists(defaultPath))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return -1;
        }

        /// <summary>
        /// 向文件中添加记录
        /// </summary>
        /// <param name="aRecoder"></param>
        /// <returns></returns>
        public Boolean addRecoder(String[] aRecoder)
        {
            if (aRecoder == null)
            {
                return false;
            }
            switch (fileIsExist())
            {
                case 0:
                    File.Create(defaultPath);
                    break;
                case -1:
                    Directory.CreateDirectory(defaultDirectory);
                    File.Create(defaultPath);
                    break;
            }
            File.AppendAllLines(defaultPath, aRecoder,Encoding.Default);
            return true;
        }

        /// <summary>
        /// 从文件中删除记录
        /// </summary>
        /// <param name="aRecoder"></param>
        /// <returns></returns>
        public Boolean deleteRecoder(String aRecoder)
        {
            if (aRecoder==null)
            {
                return false;
            }
            String[] srcStr = readRecoder();
            String[] destStr = new String[srcStr.Length-1];
            int j = 0;
            for (int i = 0; i < srcStr.Length; i++)
            {
                if (!srcStr[i].Equals(aRecoder))
                {
                    destStr[j] = srcStr[i];
                    j++;
                }
            }
            File.WriteAllLines(defaultPath, destStr,Encoding.Default);
            if (destStr.Length==srcStr.Length)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 清空文件记录
        /// </summary>
        public void cleanRecoder()
        {
            File.WriteAllText(defaultPath, "",Encoding.Default);
        }

        /// <summary>
        /// 从文件中读取记录
        /// </summary>
        /// <returns></returns>
        public String[] readRecoder()
        {
            String[] fileRecoders = null;
            if (!Directory.Exists(defaultDirectory))
            {
                Directory.CreateDirectory(defaultDirectory);
            }
            if (!File.Exists(defaultPath))
            {
                File.Create(defaultPath);
            }
            try
            {
                fileRecoders = File.ReadAllLines(defaultPath, Encoding.Default);
            }
            catch { }
            return fileRecoders;
        }
    }
}
