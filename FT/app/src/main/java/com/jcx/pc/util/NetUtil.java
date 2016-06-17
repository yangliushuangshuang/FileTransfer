package com.jcx.pc.util;

/**
 * Created by Cui on 2016/6/13.
 * function: 对网络传输的流，加头部标识，去掉头部标识获得内容
 */
public class NetUtil {

    /**
     * 添加头部内容信息标识
     * @param head
     * @param body
     * @return
     */
    public static byte[] AddHead(byte[] head, byte[] body){
        byte[] message=new byte[head.length+body.length];

        for (int i = 0; i < message.length; i++) {
            if (i < head.length) {
                message[i] = head[i];
            } else {
                message[i] = body[i - head.length];
            }
        }
        return message;
    }

    /**
     * 去掉头部标识，获得网络数据中的内容
     * @param buffer
     * @return
     */
    public static byte[] GetContent(byte[] buffer){
        byte[] content = new byte[buffer.length-1];

        for (int i = 1, j = 0; i < buffer.length; i++, j++) {
            content[j] = buffer[i];
        }

        return content;
    }

    public static int GetEffLength(byte[] buffer){
        int effLength = 0;

        int i = 0;
        while (i < buffer.length){
            if (buffer[i] == 0) {
                effLength = i+1;
                break;
            }
            i++;
        }

        return effLength;
    }
}
