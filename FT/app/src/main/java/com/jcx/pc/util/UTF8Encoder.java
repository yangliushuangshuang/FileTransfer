package com.jcx.pc.util;

import java.io.UnsupportedEncodingException;

/**
 * Created by Cui on 2016/6/13.
 */
public class UTF8Encoder {

    public static String Encode(String str){
        String encodedMes = null;

        if (str != null) {
            try {
                encodedMes = new String(str.getBytes("UTF-8"));
            } catch (UnsupportedEncodingException e) {
                e.printStackTrace();
            }
        }
        return encodedMes;
    }
}
