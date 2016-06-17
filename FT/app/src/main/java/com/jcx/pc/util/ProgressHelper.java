package com.jcx.pc.util;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.DialogInterface;

import com.jcx.R;

/**
 * Created by Cui on 2016/6/16.
 */
public class ProgressHelper {

    private static ProgressDialog progressdialog;

    public static void ShowProgress(Context context, int max, String title, String message){

        progressdialog = new ProgressDialog(context);
        progressdialog.setProgressStyle(ProgressDialog.STYLE_HORIZONTAL);// 设置水平进度条
        progressdialog.setCancelable(true);// 设置是否可以通过点击Back键取消
        progressdialog.setCanceledOnTouchOutside(false);// 设置在点击Dialog外是否取消Dialog进度条
        progressdialog.setTitle(title);
        progressdialog.setMax(max);
        progressdialog.setButton(DialogInterface.BUTTON_POSITIVE, "确定", new DialogInterface.OnClickListener() {

                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        // TODO Auto-generated method stub

                    }
                });
        progressdialog.setButton(DialogInterface.BUTTON_NEGATIVE, "取消", new DialogInterface.OnClickListener() {

                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        // TODO Auto-generated method stub

                    }
                });
        progressdialog.setMessage(message);
        progressdialog.show();
        System.out.println("显示progressbar");
    }

    public static void UpdateProgress(int increment){
        progressdialog.incrementProgressBy(increment);
        System.out.println("更新progressbar");
    }

    public static void DissmissProgress(){
        progressdialog.dismiss();
        progressdialog = null;
        System.out.println("关闭progressbar");
    }
}
