
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
using AplikasiQuiz.StaticDetails;

namespace AplikasiQuiz.Activities
{
	[Activity (Label = "CaraSelamat")]			
	public class CaraSelamat : AppCompatActivity
	{
		private ImageView imgArrow;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView(Resource.Layout.CaraSelamat_Layout);

			imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);

            imgArrow.Click += ImgArrow_Click;
		}

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MenuActivity));
            StartActivity(intent);
        }

        public override void OnBackPressed()
        {

        }
    }
}

