package com.jcx.pc.util;

import android.os.Environment;

import java.io.File;
import java.io.IOException;

/**
 * Created by Cui on 16-6-8.
 */
public class FileHelper {

    public static long receivedLength = 0;

    public static void setReceivedLength(long length){
        receivedLength = receivedLength + length;
    }

    public static long getReceivedLength(){
        return receivedLength;
    }

    public static void resetreceivedLength(){
        receivedLength = 0;
    }

    /**
     * 获得文件的大小
     * @param filePath
     * @return
     */
    public static Long getFileSize(String filePath){
        Long fileLength = 0L;

        File file = new File(filePath);
        if (!file.exists()) {
            fileLength = file.length();
        }

        return fileLength;
    }

    /**
     * 新建接收到的文件，然后写入数据
     * @param fileName
     * @return
     */
    public static String newFile( String fileName){

        File receiveFile=null;

        String project_folder = Environment.getExternalStorageDirectory().getAbsolutePath()+"/"+"ft_pc";
        File parentFolder=new File(project_folder);
        File file=new File(project_folder+"/"+fileName);

        if (!parentFolder.exists()) {
            parentFolder.mkdir();
        }

        for (int i=1;file.exists();i++) {
            int index = fileName.lastIndexOf(".");
            String fileNameWithoutSuffix = fileName.substring(0,index);
            String suffix = fileName.substring(index+1,fileName.length());
            file=new File(project_folder+"/"+fileNameWithoutSuffix+ Integer.toString(i)+"."+suffix);
        }
        try {
            file.createNewFile();
        }  catch (IOException e) {
            e.printStackTrace();
        }
        receiveFile=file;

        return receiveFile.getAbsolutePath();
    }
}
