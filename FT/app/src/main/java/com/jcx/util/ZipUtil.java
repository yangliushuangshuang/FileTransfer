package com.jcx.util;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.util.List;
import java.util.zip.ZipEntry;
import java.util.zip.ZipInputStream;
import java.util.zip.ZipOutputStream;

/**
 * Created by Cui on 16-4-11.
 */
public class ZipUtil {

    public ZipUtil(){}

    /**
     * 取得压缩包中的 文件列表(文件夹,文件自选)
     * @param zipFileString     压缩包名字
     * @param bContainFolder    是否包括 文件夹
     * @param bContainFile      是否包括 文件
     * @return
     * @throws Exception
     */
    public static List<File> GetFileList(String zipFileString, boolean bContainFolder, boolean bContainFile)throws Exception {

        List<File> fileList = new java.util.ArrayList<File>();
        ZipInputStream inZip = new ZipInputStream(new FileInputStream(zipFileString));
        ZipEntry zipEntry;
        String szName = "";

        while ((zipEntry = inZip.getNextEntry()) != null) {
            szName = zipEntry.getName();

            if (zipEntry.isDirectory()) {

                // get the folder name of the widget
                szName = szName.substring(0, szName.length() - 1);
                File folder = new File(szName);
                if (bContainFolder) {
                    fileList.add(folder);
                }

            } else {
                File file = new File(szName);
                if (bContainFile) {
                    fileList.add(file);
                }
            }
        }//end of while

        inZip.close();

        return fileList;
    }

    /**
     * 解压一个压缩文档 到指定位置
     * @param zipFileString 压缩包的名字
     * @param outPathString 指定的路径
     * @throws Exception
     */
    public static void unZip(String zipFileString, String outPathString)throws Exception {
        ZipInputStream inZip = new ZipInputStream(new FileInputStream(zipFileString));
        ZipEntry zipEntry;
        String szName = "";

        while ((zipEntry = inZip.getNextEntry()) != null) {
            szName = zipEntry.getName();

            if (zipEntry.isDirectory()) {

                // get the folder name of the widget
                szName = szName.substring(0, szName.length() - 1);
                File folder = new File(outPathString + File.separator + szName);
                folder.mkdirs();

            } else {

                File file = new File(outPathString + File.separator + szName);
                file.createNewFile();
                // get the output stream of the file
                FileOutputStream out = new FileOutputStream(file);
                int len;
                byte[] buffer = new byte[1024];
                // read (len) bytes into buffer
                while ((len = inZip.read(buffer)) != -1) {
                    // write (len) byte from buffer at the position 0
                    out.write(buffer, 0, len);
                    out.flush();
                }
                out.close();
            }
        }//end of while

        inZip.close();

    }//end of func

    public String getZipedFile(final String srcFilePath, final String zipedFilePath){
        Runnable zipFiles=new Runnable() {
            @Override
            public void run() {
                try {
                    zip(srcFilePath,zipedFilePath);
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        };
        new Thread(zipFiles).start();
        return zipedFilePath;
    }

    /**
     * 压缩文件,文件夹
     * @param srcFileString 要压缩的文件/文件夹名字
     * @param zipFileString 指定压缩的目的和名字
     * @throws Exception
     */
    public static void zip(String srcFileString, String zipFileString)throws Exception {

        //创建Zip包
        ZipOutputStream outZip = new ZipOutputStream(new FileOutputStream(zipFileString));

        //打开要输出的文件
        File file = new File(srcFileString);

        //压缩
        ZipFiles(file.getParent()+File.separator, file.getName(), outZip);

        //完成,关闭
        outZip.finish();
        outZip.close();

    }//end of func

    /**
     * 压缩文件
     * @param folderString
     * @param fileString
     * @param zipOutputSteam
     * @throws Exception
     */
    private static void ZipFiles(String folderString, String fileString, ZipOutputStream zipOutputSteam)throws Exception{

        if(zipOutputSteam == null)
            return;

        File file = new File(folderString+fileString);

        //判断是不是文件
        if (file.isFile()) {

            ZipEntry zipEntry =  new ZipEntry(fileString);
            FileInputStream inputStream = new FileInputStream(file);
            zipOutputSteam.putNextEntry(zipEntry);

            int len;
            byte[] buffer = new byte[4096];

            while((len=inputStream.read(buffer)) != -1)
            {
                zipOutputSteam.write(buffer, 0, len);
            }

            zipOutputSteam.closeEntry();
        }
        else {

            //文件夹的方式,获取文件夹下的子文件
            String fileList[] = file.list();

            //如果没有子文件, 则添加进去即可
            if (fileList.length <= 0) {
                ZipEntry zipEntry =  new ZipEntry(fileString+ File.separator);
                zipOutputSteam.putNextEntry(zipEntry);
                zipOutputSteam.closeEntry();
            }

            //如果有子文件, 遍历子文件
            for (int i = 0; i < fileList.length; i++) {
                ZipFiles(folderString, fileString+File.separator+fileList[i], zipOutputSteam);
            }//end of for

        }//end of if

    }//end of func

    public void finalize() throws Throwable {

    }
}
