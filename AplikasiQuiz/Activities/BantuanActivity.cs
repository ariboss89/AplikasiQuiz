﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AplikasiQuiz.Activities
{
    [Activity(Label = "BantuanActivity")]
    public class BantuanActivity : Activity
    {
        private ImageView imgBack;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.BantuanLayout);

            imgBack = FindViewById<ImageView>(Resource.Id.imgBack);

            imgBack.Click += ImgBack_Click;

        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MenuActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }
    }
}

