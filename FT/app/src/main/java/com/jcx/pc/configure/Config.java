package com.jcx.pc.configure;

/**
 * Created by Cui on 16-6-8.
 */
public class Config {

    public static final byte VALUE_TYPE_FILE_INFO = 0;
    public static final byte VALUE_TYPE_FILE_CONT = 1;

    public static final String KEY_HEAD = "head";
    public static final String HEAD_CON_ASK = "con_ask";
    public static final String HEAD_CON_OK = "con_ok";
    public static final String HEAD_FILE_INFO = "file_info";
    public static final String HEAD_SEND_OVER = "send_over";
    public static final String HEAD_SEND_START = "send_start";
    public static final String HEAD_GO_ON = "go_on";

    public static final String KEY_FILE_NAME="file_name";
    public static final String KEY_FILE_LENGTH="file_length";
    public static final int BUFFER_SIZE=1024;

    public static final String CONN_FAIL = "con_fail";
    public static final String REC_BEGIN = "rec_start";
    public static final String REC_OVER = "rec_over";
    public static final String REC_FAIL = "rec_fail";

}
