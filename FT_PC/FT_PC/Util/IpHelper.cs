using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;
using System.Text.RegularExpressions;

namespace FT_PC
{
    class IpHelper
    {
        /// <summary>
        /// 得到本机IP
        /// </summary>
        public static string GetLocalIP()
        {
            //本机IP地址
            string strLocalIP = "";
            //得到计算机名
            string strPcName = Dns.GetHostName();
            //得到本机IP地址数组
            IPHostEntry ipEntry = Dns.GetHostEntry(strPcName);
            //遍历数组
            foreach (var IPadd in ipEntry.AddressList)
            {
                //判断当前字符串是否为正确IP地址
                if (IsRightIP(IPadd.ToString()))
                {
                    //得到本地IP地址
                    strLocalIP = IPadd.ToString();
                    //结束循环
                    break;
                }
            }
            //返回本地IP地址
            return strLocalIP;
        }



        /// <summary>
        /// 判断是否为正确的IP地址
        /// </summary>
        /// <param name="strIPadd">需要判断的字符串</param>
        /// <returns>true = 是 false = 否</returns>
        private static bool IsRightIP(string strIPadd)
        {
            //利用正则表达式判断字符串是否符合IPv4格式
            if (Regex.IsMatch(strIPadd, "[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}"))
            {
                //根据小数点分拆字符串
                string[] ips = strIPadd.Split('.');
                if (ips.Length == 4 || ips.Length == 6)
                {
                    //如果符合IPv4规则
                    if (System.Int32.Parse(ips[0]) < 256 && System.Int32.Parse(ips[1]) < 256 & System.Int32.Parse(ips[2]) < 256 & System.Int32.Parse(ips[3]) < 256)
                        //正确
                        return true;
                    //如果不符合
                    else
                        //错误
                        return false;
                }
                else
                    //错误
                    return false;
            }
            else
                //错误
                return false;
        }
    }
}
