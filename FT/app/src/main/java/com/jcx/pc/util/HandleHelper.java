package com.jcx.pc.util;

import android.os.Handler;
import android.os.Message;


/**
 * Created by Cui on 2016/6/16.
 */
public class HandleHelper {
    public static Handler handler = new Handler() {
        @Override
        public void handleMessage(Message msg) {
            super.handleMessage(msg);

            switch (msg.what)
            {
                case -1:
                case -2:
                    ProgressHelper.DissmissProgress();//关闭进度条
                    System.out.println("发送文件结束");
                    break;
                default:
                    ProgressHelper.UpdateProgress((int)msg.what);//更新进度条
                    break;
            }
        }
    };
}
