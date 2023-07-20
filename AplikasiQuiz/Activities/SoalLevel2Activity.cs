
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
using AndroidX.AppCompat.App;
using AplikasiQuiz.Models;
using AplikasiQuiz.StaticDetails;

namespace AplikasiQuiz.Activities
{
    [Activity(Label = "SoalLevel2Activity")]
    public class SoalLevel2Activity : AppCompatActivity
    {
        private ImageView imgRambu;
        private TextView txtSoal, txtIsiA, txtIsiB, txtIsiC, txtIsiD;
        private tb_soal tbs;
        private List<tb_jawab> listJawaban = new List<tb_jawab>();
        private List<tb_soal> listSoal;
        private ImageLevel2 img2 = new ImageLevel2();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.level2_layout);

            imgRambu = FindViewById<ImageView>(Resource.Id.imgRambu);
            txtSoal = FindViewById<TextView>(Resource.Id.txtSoal);
            txtIsiA = FindViewById<TextView>(Resource.Id.txtIsiA);
            txtIsiB = FindViewById<TextView>(Resource.Id.txtIsiB);
            txtIsiC = FindViewById<TextView>(Resource.Id.txtIsiC);
            txtIsiD = FindViewById<TextView>(Resource.Id.txtIsiD);

            txtIsiA.Click += TxtIsiA_Click;
            txtIsiB.Click += TxtIsiB_Click;
            txtIsiC.Click += TxtIsiC_Click;
            txtIsiD.Click += TxtIsiD_Click;

            string code = Intent.GetStringExtra("Id") ?? string.Empty;
            var stop = System.Convert.FromBase64String(img2.imageStop());
            var traffic = System.Convert.FromBase64String(img2.imageTraffic());
            var guide = System.Convert.FromBase64String(img2.imageGuide());
            var pejalanKaki = System.Convert.FromBase64String(img2.imagePejalanKaki());
            var simpang4 = System.Convert.FromBase64String(img2.imageSimpang4());
            var dilarangMendahului = System.Convert.FromBase64String(img2.imageDilarangMendahului());
            var empatpuluhkm = System.Convert.FromBase64String(img2.image40Km());
            var satuArah = System.Convert.FromBase64String(img2.imageSatuArah());
            var laranganMelintasKedepan = System.Convert.FromBase64String(img2.imageLaranganMelintasKedepan());
            var parkir = System.Convert.FromBase64String(img2.imageParkir());

            listSoal = new List<tb_soal>();

            tbs = new tb_soal();

            tbs.Id = 1;
            tbs.gambar = stop;
            tbs.soal = "Dari rambu lalu lintas di atas termasuk jenis rambu-rambu apa dan apa larangannya?";
            tbs.pilihanA = "Peringatan/ Di larang berhenti";
            tbs.pilihanB = "Larangan/ Ada tikungan tajam";
            tbs.pilihanC = "Peringatan/ Di larang Mendahului";
            tbs.pilihanD = "Larangan/Di larang berhenti";
            tbs.jawaban = "Larangan/Di larang berhenti";

            listSoal.Add(tbs);

            tbs = new tb_soal();

            tbs.Id = 2;
            tbs.gambar = traffic;
            tbs.soal = "Jika kita lagi dijalan dan menemukan rambu lalu lintas gambar dibawah ini berarti kita dekat dengan apa?";
            tbs.pilihanA = "Dekat dengan alat pemberi isyarat lalu lintas";
            tbs.pilihanB = "Dekat dengan jurang";
            tbs.pilihanC = "Jalan Lurus";
            tbs.pilihanD = "Dekat dengan keramaian";
            tbs.jawaban = "Dekat dengan alat pemberi isyarat lalu lintas";

            listSoal.Add(tbs);

            tbs = new tb_soal();

            tbs.Id = 3;
            tbs.gambar = guide;
            tbs.soal = "Apa fungsi dari rambu di atas ?";
            tbs.pilihanA = "Rambu petunjuk arah";
            tbs.pilihanB = "Rambu petunjuk adanya simpang";
            tbs.pilihanC = "Rambu petunjuk adanya arus mudik";
            tbs.pilihanD = "Rambu petunjuk dilarang menuju arah-arah panah";
            tbs.jawaban = "Rambu petunjuk arah";

            listSoal.Add(tbs);

            tbs = new tb_soal();

            tbs.Id = 4;
            tbs.gambar = pejalanKaki;
            tbs.soal = "Rambu lalu lintas banyak kita temui dijalanan, jika kita menemukan rambu lalu lintas petunjuk gambar dibawah ini. Apa manfaat dari rambu lalu lintas tersebut ?";
            tbs.pilihanA = "Agar jalan terlihat rapi dan tertib";
            tbs.pilihanB = "Pengguna jalan menjadi senang dan tidak bosan";
            tbs.pilihanC = "Memberi petunjuk bagi pejalan kaki agar mengetahui bentuk jalan, arah jalan, dan untuk menghindari adanya kecelakaan";
            tbs.pilihanD = "B dan C Benar";
            tbs.jawaban = "Memberi petunjuk bagi pejalan kaki agar mengetahui bentuk jalan, arah jalan, dan untuk menghindari adanya kecelakaan";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 5;
            tbs.gambar = simpang4;
            tbs.soal = "Rambu diatas menunjukkan sebuah peringatan adanya apa?";
            tbs.pilihanA = "Simpang tiga";
            tbs.pilihanB = "Adanya Simpang Empat";
            tbs.pilihanC = "Adanya Simpang Lima";
            tbs.pilihanD = "Adanya Pos Medis";
            tbs.jawaban = "Adanya Simpang Empat";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 6;
            tbs.gambar = dilarangMendahului;
            tbs.soal = "Jika kita dijalan sedang menaiki kendaraan bermotor dan menemukan rambu lalu lintas seperti gambar di bawah ini, apa maksud dari rambu ini?";
            tbs.pilihanA = "Dilarang Mendahului";
            tbs.pilihanB = "Tikungan Tajam";
            tbs.pilihanC = "Dilarang Berbelok";
            tbs.pilihanD = "Ada Belokan di Depan";
            tbs.jawaban = "Dilarang Mendahului";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 7;
            tbs.gambar = empatpuluhkm;
            tbs.soal = "Jika kita dijalan sedang menaiki kendaraan bermotor dan menemukan rambu lalu lintas gambar di bawah ini termasuk jenis rambu apa dan maksudnya apa?";
            tbs.pilihanA = "Rambu dilarang berkecepatan lebih dari 40 km/jam";
            tbs.pilihanB = "Rambu dilarang berkecepatan kurang dari 40 km/jam";
            tbs.pilihanC = "Rambu petunjuk berkecepatan maksimal 40 km/jam";
            tbs.pilihanD = "A dan C Benar";
            tbs.jawaban = "Rambu dilarang berkecepatan lebih dari 40 km/jam";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 8;
            tbs.gambar = satuArah;
            tbs.soal = "Apa maksud dari rambu diatas?";
            tbs.pilihanA = "Rambu dilarang lurus";
            tbs.pilihanB = "Rambu satu arah";
            tbs.pilihanC = "Rambu dilarang mendahului";
            tbs.pilihanD = "Rambu wajib lurus";
            tbs.jawaban = "Rambu satu arah";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 9;
            tbs.gambar = laranganMelintasKedepan;
            tbs.soal = "Apa arti dari rambu diatas?";
            tbs.pilihanA = "Rambu larangan melintas terus ke depan";
            tbs.pilihanB = "Rambu petunjuk boleh maju ke depan";
            tbs.pilihanC = "Rambu arah di alihkan";
            tbs.pilihanD = "Rambu dilarang berhenti";
            tbs.jawaban = "Rambu larangan melintas terus ke depan";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 10;
            tbs.gambar = parkir;
            tbs.soal = "Rambu diatas menunjukkan bahwa?";
            tbs.pilihanA = "Dilarang Parkir";
            tbs.pilihanB = "Silahkan Parkir";
            tbs.pilihanC = "Wajib Memarkirkan Kendaraan";
            tbs.pilihanD = "Terdapat fasilitas parkir";
            tbs.jawaban = "Terdapat fasilitas parkir";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            var orderByDescendingResult = from s in listSoal
                                          orderby s.Id descending
                                          select s;

            int Id = 0;
            int count = listSoal.Count;

            if (StaticSoal.Id == 0)
            {
                int param = count - 1;

                //Id = listSoal[param].Id;

                Id = param;

                StaticSoal.Id = listSoal[Id].Id;


                txtIsiA.Text = listSoal[Id].pilihanA;
                txtIsiB.Text = listSoal[Id].pilihanB;
                txtIsiC.Text = listSoal[Id].pilihanC;
                txtIsiD.Text = listSoal[Id].pilihanD;


                if (listSoal[Id].gambar != null)
                {
                    byte[] imageArray = listSoal[Id].gambar;
                    Android.Graphics.Bitmap bitmap = BitmapFactory.DecodeByteArray(imageArray, 0, imageArray.Length);
                    //Android.Graphics.Bitmap bMapScaled = Android.Graphics.Bitmap.CreateScaledBitmap(bitmap, 80, 80, true);
                    imgRambu.SetImageBitmap(bitmap);
                }

                txtSoal.Text = listSoal[Id].soal;

            }
            else
            {
                int idKu = StaticSoal.Id;

                int nextId = idKu - 1;

                if (nextId == 0) {
                    Intent intent = new Intent(this, typeof(SkorActivity));
                    intent.PutExtra("level", "Level2");
                    StaticSoal.Id = 0;
                    intent.SetFlags(ActivityFlags.NewTask);
                    StartActivity(intent);
                }
                else
                {
                    var data = listSoal.Where(x => x.Id == nextId).ToList();

                    StaticSoal.Id = data[0].Id;

                    txtIsiA.Text = data[0].pilihanA;
                    txtIsiB.Text = data[0].pilihanB;
                    txtIsiC.Text = data[0].pilihanC;
                    txtIsiD.Text = data[0].pilihanD;

                    if (data[Id].gambar != null)
                    {
                        byte[] imageArray = data[Id].gambar;
                        Android.Graphics.Bitmap bitmap = BitmapFactory.DecodeByteArray(imageArray, 0, imageArray.Length);
                        //Android.Graphics.Bitmap bMapScaled = Android.Graphics.Bitmap.CreateScaledBitmap(bitmap, 80, 80, true);
                        imgRambu.SetImageBitmap(bitmap);
                    }

                    txtSoal.Text = data[0].soal;

                }
            }

            int countData = StaticSoal.listJawaban.Count;

            if(countData != 0)
            {
                tb_jawab tbj = new tb_jawab();
                tbj.Id = StaticSoal.listJawaban[0].Id;
                tbj.jawaban = StaticSoal.listJawaban[0].jawaban;

                StaticSoal.listJawaban2.Add(tbj);
            }

        }

        public override void OnBackPressed()
        {
            
        }

        private void TxtIsiD_Click(object sender, EventArgs e)
        {
            tb_jawab tbj = new tb_jawab();
            tbj.Id = StaticSoal.Id;
            tbj.jawaban = txtIsiD.Text;

            StaticSoal.listJawaban.Add(tbj);

            Intent intent = new Intent(this, typeof(SoalLevel2Activity));
            StartActivity(intent);
        }

        private void TxtIsiC_Click(object sender, EventArgs e)
        {
            tb_jawab tbj = new tb_jawab();
            tbj.Id = StaticSoal.Id;
            tbj.jawaban = txtIsiC.Text;
           
            StaticSoal.listJawaban.Add(tbj);

            Intent intent = new Intent(this, typeof(SoalLevel2Activity));
            StartActivity(intent);
        }

        private void TxtIsiB_Click(object sender, EventArgs e)
        {
            tb_jawab tbj = new tb_jawab();
            tbj.Id = StaticSoal.Id;
            tbj.jawaban = txtIsiB.Text;
           
            StaticSoal.listJawaban.Add(tbj);

            Intent intent = new Intent(this, typeof(SoalLevel2Activity));
            StartActivity(intent);
        }

        private void TxtIsiA_Click(object sender, EventArgs e)
        {
            tb_jawab tbj = new tb_jawab();
            tbj.Id = StaticSoal.Id;
            tbj.jawaban = txtIsiA.Text;
           
            StaticSoal.listJawaban.Add(tbj);

            Intent intent = new Intent(this, typeof(SoalLevel2Activity));
            StartActivity(intent);
        }
    }
}

