package com.jcx.pc.util;

import android.content.Context;
import android.widget.Toast;

/**
 * Created by Cui on 2016/6/14.
 */
public class ToastHelper {

    public static void ShowToast(Context context, String mes){
        Toast.makeText(context,mes,Toast.LENGTH_SHORT).show();
    }
}
