using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT_PC
{
    class Config
    {
        public static String PROJECT_FOLDER = @"C:\Users\Public\Documents";

        public static int PORT = 12345;

        public static int BUFFER_SIZE = 1024;
        public static byte VALUE_TYPE_FILE_INFO = 0;
        public static byte VALUE_TYPE_FILE_CONT = 1;

        public static String KEY_HEAD = "head";
        public static String HEAD_CON_ASK = "con_ask";
        public static String HEAD_CON_OK = "con_ok";
        public static String HEAD_FILE_INFO = "file_info";
        public static String HEAD_SEND_OVER = "send_over";
        public static String HEAD_SEND_START = "send_start";
        public static String HEAD_GO_ON = "go_on";

        public static String KEY_FILE_NAME = "file_name";
        public static String KEY_FILE_LENGTH = "file_length";
    }
}
