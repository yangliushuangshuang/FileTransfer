using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace FT_PC
{
    class WifiHelper
    {
        /// <summary>
        /// 创建虚拟WiFi
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string create(string str)
        {
            Process process = new Process
            {
                StartInfo = { FileName = " cmd.exe ", UseShellExecute = false, RedirectStandardInput = true, RedirectStandardOutput = true, CreateNoWindow = true }
            };
            process.Start();
            process.StandardInput.WriteLine(str);
            process.StandardInput.WriteLine("exit");
            process.WaitForExit();
            string res = process.StandardOutput.ReadToEnd();
            process.Close();
            return res;
        }

        /// <summary>
        /// 开启虚拟WiFi
        /// </summary>
        /// <param name="wifiName"></param>
        /// <param name="psw"></param>
        public void startWifi(string wifiName, string psw)
        {
            string str = "netsh wlan set hostednetwork mode=allow ssid=" + wifiName + " key=" + psw;
            Console.Out.Write(create(str));
            string str1 = "netsh wlan start hostednetwork";
            Console.Out.Write(create(str1));
        }

        /// <summary>
        /// 关闭虚拟WiFi
        /// </summary>
        public void closeApWifi()
        {
            string str = "netsh wlan stop hostednetwork";
            create(str);
        }
    }
}
