﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidTest001
{
    [Activity(Label = "AndroidTest001", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

