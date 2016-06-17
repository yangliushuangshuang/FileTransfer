using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT_PC
{
    class JsonUtil
    {
        /// <summary>
        /// 对将要输出的字符串进行编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String EncodeStr(params String[] str)
        {
            StringBuilder encodedStr = new StringBuilder();

            for (int i = 0; i < str.Length; i += 2)
            {
                encodedStr.Append(str[i]).Append("=").Append(str[i + 1]);
                if (i + 2 != str.Length)
                {
                    encodedStr.Append("&");
                }
            }

            return encodedStr.ToString();
        }

        /// <summary>
        /// 对收到的字符串进行解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Dictionary<String, String> parserStr(String str)
        {
            Dictionary<String, String> dic = new Dictionary<String, String>();

            //拆分字符串
            String[] sprStr = new String[10];
            sprStr = str.Split('&');
            foreach (String s in sprStr)
            {
                int i = s.IndexOf('=');
                String key = s.Substring(0, i);
                String value = s.Substring(i + 1, s.Length - i - 1);
                dic.Add(key, value);
            }

            return dic;
        }
    }
}
