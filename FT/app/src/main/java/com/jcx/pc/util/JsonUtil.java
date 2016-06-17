package com.jcx.pc.util;

import java.util.HashMap;
import java.util.Map;

/**
 * Created by Cui on 16-6-8.
 */
public class JsonUtil {

    /**
     * 将数据以简直对的形式传递
     * @param str
     * @return
     */
    public static String EncodeStr(String... str){
        StringBuffer encodedStr=new StringBuffer();
        for (int i = 0; i < str.length; i+=2) {
            encodedStr.append(str[i]).append("=").append(str[i+1]);
            if (i+2 != str.length) {
                encodedStr.append("&");
            }
        }

        return encodedStr.toString();
    }

    public static Map<String,String> ParserStr(String str){

        if (str == null) {
            return null;
        }
        Map<String, String> maps = new HashMap<String, String>();
        //拆分字符串
        String[] sprStr=new String[10];
        sprStr=str.split("&");
        for (String string : sprStr) {
            int i=string.indexOf("=");
            String key=string.substring(0,i);
            String value=string.substring(i+1, (string.length()));
            maps.put(key, value);
        }

        return maps;
    }

}
