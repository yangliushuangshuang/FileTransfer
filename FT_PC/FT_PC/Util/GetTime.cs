using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT_PC
{
    class GetTime
    {
        private static String time_now;
        public static String getTime()
        {
            time_now=DateTime.Now.ToString("yyyy年M月d日 HH:mm");
            return time_now;
        }
    }
}
