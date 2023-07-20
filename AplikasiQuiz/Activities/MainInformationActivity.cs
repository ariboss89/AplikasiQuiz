
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
using AndroidX.AppCompat.App;
using AplikasiQuiz.Models;

namespace AplikasiQuiz.Activities
{
    [Activity(Label = "MainInformationActivity")]
    public class MainInformationActivity : AppCompatActivity
    {
        private Button btnLevel2, btnLevel3;
        private ImageView imgArrow;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.mainInformation_Layout);

            btnLevel2 = FindViewById<Button>(Resource.Id.btnTingkat2);
            btnLevel3 = FindViewById<Button>(Resource.Id.btnTingkat3);
            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);

            btnLevel2.Click += BtnLevel2_Click;
            btnLevel3.Click += BtnLevel3_Click;

            imgArrow.Click += ImgArrow_Click;

        }

        public override void OnBackPressed()
        {
            
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MenuActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        private void BtnLevel3_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(InformationActivity));
            intent.PutExtra("Id", "Level 3");
            StartActivity(intent);
        }

        private void BtnLevel2_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(InformationActivity));
            intent.PutExtra("Id", "Level 2");
            StartActivity(intent);
        }
    }
}

