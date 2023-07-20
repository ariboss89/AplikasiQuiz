
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

namespace AplikasiQuiz.Activities
{
    [Activity(Label = "MenuAdminActivity")]
    public class MenuAdminActivity : AppCompatActivity
    {
        private LinearLayout linKelolaInformasi, linKelolaSoal, linKelolaMateri, linKelolaPengguna, linKelolaPassword, linExit;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.admin_layout);

            linKelolaInformasi = FindViewById<LinearLayout>(Resource.Id.linKelolaInformasi);
            linKelolaSoal = FindViewById<LinearLayout>(Resource.Id.linKelolaSoal);
            linKelolaMateri = FindViewById<LinearLayout>(Resource.Id.linKelolaMateri);
            linKelolaPengguna = FindViewById<LinearLayout>(Resource.Id.linKelolaPengguna);
            linKelolaPassword = FindViewById<LinearLayout>(Resource.Id.linKelolaPassword);
            linExit = FindViewById<LinearLayout>(Resource.Id.linExit);

            linExit.Click += LinExit_Click;

        }

        private void LinExit_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MenuActivity));
            StartActivity(intent);
        }

        public override void OnBackPressed()
        {
           
        }
    }
}

