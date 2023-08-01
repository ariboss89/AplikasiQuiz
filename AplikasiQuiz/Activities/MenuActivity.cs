
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AplikasiQuiz.Models;

namespace AplikasiQuiz.Activities
{
    [Activity(Label = "MenuActivity", MainLauncher = true)]
    public class MenuActivity : AppCompatActivity
    {
        private TextView txtMenu;
        private LinearLayout linCaraSelamat, linRambu, linSoal, linMateri, linProfil, linBantuan;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.mainMenu_Layout);

            txtMenu = FindViewById<TextView>(Resource.Id.txtMenuUtama);
            linCaraSelamat = FindViewById<LinearLayout>(Resource.Id.linCaraSelamat);
            linRambu = FindViewById<LinearLayout>(Resource.Id.linRambu);
            linSoal = FindViewById<LinearLayout>(Resource.Id.linSoal);
            linMateri = FindViewById<LinearLayout>(Resource.Id.linMateri);
            linProfil = FindViewById<LinearLayout>(Resource.Id.linProfil);
            linBantuan = FindViewById<LinearLayout>(Resource.Id.linBantuan);
            txtMenu = FindViewById<TextView>(Resource.Id.txtMenuUtama);

            linCaraSelamat.Click += LinCaraSelamat_Click;
            linRambu.Click += LinRambu_Click;
            linSoal.Click += LinSoal_Click;
            linProfil.Click += LinProfil_Click;
            linMateri.Click += LinMateri_Click;
            linBantuan.Click += LinBantuan_Click;
        }

        private void LinBantuan_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(BantuanActivity));
            StartActivity(intent);
        }

        private void LinMateri_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(KelolaMateriActivity));
            StartActivity(intent);
        }

        private void LinProfil_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfilActivity));
            StartActivity(intent);
        }

        private void LinSoal_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainSoalActivity));
            StartActivity(intent);
        }

        private void LinRambu_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainInformationActivity));
            StartActivity(intent); 
        }

        private void LinCaraSelamat_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CaraSelamat));
            StartActivity(intent);
        }
    }
}

