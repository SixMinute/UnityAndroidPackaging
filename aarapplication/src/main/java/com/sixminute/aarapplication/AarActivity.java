package com.sixminute.aarapplication;

import android.app.Activity;
import android.os.Bundle;
import android.widget.TextView;

public class AarActivity extends Activity
{
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        TextView tv = (TextView)findViewById(R.id.textview);
        tv.setText( getText(R.string.res_to_replace) );
    }
}
