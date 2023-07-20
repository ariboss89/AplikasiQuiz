
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
    [Activity(Label = "MainSoalActivity")]
    public class MainSoalActivity : Activity
    {
        private Button btnLevel2, btnLevel3;
        private ImageView imgBack;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.mainQuestion_Layout);
            btnLevel2 = FindViewById<Button>(Resource.Id.btnLvl2);
            btnLevel3 = FindViewById<Button>(Resource.Id.btnLvl3);

            btnLevel2.Click += BtnLevel2_Click;
            btnLevel3.Click += BtnLevel3_Click;

            imgBack = FindViewById<ImageView>(Resource.Id.imgBack);
            imgBack.Click += ImgBack_Click;

        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MenuActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        private void BtnLevel3_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SoalLevel3Activity));
            intent.PutExtra("Id", "Level 3");
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        private void BtnLevel2_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SoalLevel2Activity));
            intent.PutExtra("Id", "Level 2");
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }
    }
}

