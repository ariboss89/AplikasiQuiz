
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AplikasiQuiz.StaticDetails;

namespace AplikasiQuiz.Activities
{
    [Activity(Label = "DetailInformationActivity")]
    public class DetailInformationActivity : Activity
    {
        private ImageView imgRambu, imgArrow;
        private TextView txtNamaRambu, txtKategori, txtInformasi;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.detailInformation_Layout);

            imgRambu = FindViewById<ImageView>(Resource.Id.imgRambu);
            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);
            txtNamaRambu = FindViewById<TextView>(Resource.Id.txtNamaRambu);
            txtKategori = FindViewById<TextView>(Resource.Id.txtKategori);
            txtInformasi = FindViewById<TextView>(Resource.Id.txtInformasi);

            if (StaticInformation.gambar != null)
            {
                byte[] imageArray = StaticInformation.gambar;
                Android.Graphics.Bitmap bitmap = BitmapFactory.DecodeByteArray(imageArray, 0, imageArray.Length);
                //Android.Graphics.Bitmap bMapScaled = Android.Graphics.Bitmap.CreateScaledBitmap(bitmap, 80, 80, true);
                imgRambu.SetImageBitmap(bitmap);
            }

            txtNamaRambu.Text = StaticInformation.nama;
            txtKategori.Text = StaticInformation.kategori;
            txtInformasi.Text = StaticInformation.informasi;

            imgArrow.Click += ImgArrow_Click;

        }

        public override void OnBackPressed()
        {
           
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(InformationActivity));
            intent.PutExtra("Id", StaticInformation.type);
            StartActivity(intent);
        }
    }
}

