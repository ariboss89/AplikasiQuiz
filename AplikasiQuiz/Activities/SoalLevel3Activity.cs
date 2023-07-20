
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
    [Activity(Label = "SoalLevel3Activity")]
    public class SoalLevel3Activity : AppCompatActivity
    {
        private ImageView imgRambu;
        private TextView txtSoal, txtIsiA, txtIsiB, txtIsiC, txtIsiD;
        private tb_soal tbs;
        private List<tb_jawab> listJawaban = new List<tb_jawab>();
        private List<tb_soal> listSoal;
        private ImageLevel3 img = new ImageLevel3();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.level3_layout);

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

            var apotek = System.Convert.FromBase64String(img.imageApotek());
            var balikdanbelokkanan = System.Convert.FromBase64String(img.imageBalikdanBelokKanan());
            var jalanbuntu = System.Convert.FromBase64String(img.imageJalanBuntu());
            var lebarruangbebas = System.Convert.FromBase64String(img.imageLebarRuangBebas());
            var parkirmundur = System.Convert.FromBase64String(img.imageParkirMundur());
            var perpus= System.Convert.FromBase64String(img.imagePerpus());
            //var prioritas = System.Convert.FromBase64String(img.imagep());
            var segitiga = System.Convert.FromBase64String(img.imageSegitiga());
            var tikungantajamkanan = System.Convert.FromBase64String(img.imageTikunganTajamKanan());
            var tinggilebihdari = System.Convert.FromBase64String(img.imageTinggiLebihDari());

            listSoal = new List<tb_soal>();

            tbs = new tb_soal();

            tbs.Id = 1;
            tbs.gambar = apotek;
            tbs.soal = "Dari rambu lalu lintas di atas termasuk jenis rambu-rambu apa dan apa larangannya?";
            tbs.pilihanA = "Peringatan/ Ada Apotek";
            tbs.pilihanB = "Petunjuk/ Ada Apotek";
            tbs.pilihanC = "Petunjuk/ Ada Rumah Sakit";
            tbs.pilihanD = "Petunjuk/Ada Posko Medis";
            tbs.jawaban = "Petunjuk/ Ada Apotek";

            listSoal.Add(tbs);

            tbs = new tb_soal();

            tbs.Id = 2;
            tbs.gambar = balikdanbelokkanan;
            tbs.soal = "Apa maksud dari rambu larangan diatas?";
            tbs.pilihanA = "Dilarang mendahului dan belok kanan";
            tbs.pilihanB = "Dilarang memutar balik dan belok kanan";
            tbs.pilihanC = "Dilarang memutar balik";
            tbs.pilihanD = "Dilarang belok kanan";
            tbs.jawaban = "Dilarang memutar balik dan belok kanan";

            listSoal.Add(tbs);

            tbs = new tb_soal();

            tbs.Id = 3;
            tbs.gambar = jalanbuntu;
            tbs.soal = "Apa maksud dari rambu di atas ?";
            tbs.pilihanA = "Rambu petunjuk ada simpang di depan";
            tbs.pilihanB = "Rambu petunjuk adanya simpang 2";
            tbs.pilihanC = "Rambu petunjuk adanya arus padat";
            tbs.pilihanD = "Rambu petunjuk adanya jalan buntu di depan";
            tbs.jawaban = "Rambu petunjuk adanya jalan buntu di depan";

            listSoal.Add(tbs);

            tbs = new tb_soal();

            tbs.Id = 4;
            tbs.gambar = lebarruangbebas;
            tbs.soal = "Apabila kita menemukan rambu lalu lintas ini dijalanan, apa yang sebaiknya kita lakukan?";
            tbs.pilihanA = "Berhati-hati saat melintasi jalan dengan lebar tertentu";
            tbs.pilihanB = "Berhati-hati saat melintasi jalan sempit";
            tbs.pilihanC = "Berhati-hati saat melintasi jalan dikarenakan jalanan mengecil";
            tbs.jawaban = "Berhati-hati saat melintasi jalan dengan lebar tertentu";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 5;
            tbs.gambar = parkirmundur;
            tbs.soal = "Apa arti dari rambu petunjuk diatas?";
            tbs.pilihanA = "Melakukan parkir secara bebas";
            tbs.pilihanB = "Melakukan parkir depan";
            tbs.pilihanC = "Melakukan parkir mundur";
            tbs.pilihanD = "Melakukan parkir menyerong";
            tbs.jawaban = "Melakukan parkir mundur";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 6;
            tbs.gambar = perpus;
            tbs.soal = "Jika kita dijalan sedang menaiki kendaraan bermotor dan menemukan rambu lalu lintas seperti gambar di bawah ini, apa maksud dari rambu ini?";
            tbs.pilihanA = "Dekat dengan lokasi Perpustakaan";
            tbs.pilihanB = "Dekat dengan lokasi Sekolah";
            tbs.pilihanC = "Dekat dengan lokasi Taman";
            tbs.pilihanD = "Dekat dengan lokasi Universitas";
            tbs.jawaban = "Dekat dengan lokasi Perpustakaan";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            //tbs.Id = 7;
            //tbs.gambar = prioritas;
            //tbs.soal = "Jika kita dijalan sedang menaiki kendaraan bermotor dan menemukan rambu lalu lintas diatas, apa maksud dari rambu tersebut?";
            //tbs.pilihanA = "Mendapatkan prioritas melanjutkan perjalanan dari arah berlawanan";
            //tbs.pilihanB = "Jalan dua arah";
            //tbs.pilihanC = "Jalan pada arah sebaliknya tidak boleh di lalui";
            //tbs.pilihanD = "Jalan pada arah sebaliknya hanya khusus orang penting";
            //tbs.jawaban = "Mendapatkan prioritas melanjutkan perjalanan dari arah berlawanan";

            //listSoal.Add(tbs);
            //tbs = new tb_soal();

            tbs.Id = 7;
            tbs.gambar = segitiga;
            tbs.soal = "Apa maksud dari rambu diatas?";
            tbs.pilihanA = "Rambu dilarang lurus";
            tbs.pilihanB = "Rambu hati - hati";
            tbs.pilihanC = "Rambu bahwa di area tertentu dilarang untuk berjalan terus karena wajib memberikan prioritas kepada arus lalu lintas yang diberikan prioritas";
            tbs.pilihanD = "Rambu agar waspada selalu";
            tbs.jawaban = "Rambu bahwa di area tertentu dilarang untuk berjalan terus karena wajib memberikan prioritas kepada arus lalu lintas yang diberikan prioritas";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 8;
            tbs.gambar = tikungantajamkanan;
            tbs.soal = "Rambu diatas merupakan rambu?";
            tbs.pilihanA = "Rambu boleh menyalip";
            tbs.pilihanB = "Rambu petunjuk jalan kanan dan lurus";
            tbs.pilihanC = "Rambu arah di alihkan";
            tbs.pilihanD = "Rambu lalu lintas tikungan tajam ganda dengan tikungan pertama ke kanan";
            tbs.jawaban = "Rambu lalu lintas tikungan tajam ganda dengan tikungan pertama ke kanan";

            listSoal.Add(tbs);
            tbs = new tb_soal();

            tbs.Id = 9;
            tbs.gambar = tinggilebihdari;
            tbs.soal = "Rambu diatas menunjukkan bahwa?";
            tbs.pilihanA = "Pengguna jalan bahwa di area tertentu kendaraan bermotor dengan tinggi lebih dari ... m dilarang masuk";
            tbs.pilihanB = "Pengguna jalan bahwa di area tertentu kendaraan bermotor dengan lebar lebih dari ... m dilarang masuk";
            tbs.pilihanC = "Lebar ruang bebas sesuai dengan lebar jalan";
            tbs.pilihanD = "A dan B Benar";
            tbs.jawaban = "Pengguna jalan bahwa di area tertentu kendaraan bermotor dengan tinggi lebih dari ... m dilarang masuk";

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

                if (nextId == 0)
                {
                    Intent intent = new Intent(this, typeof(SkorActivity));
                    intent.PutExtra("level", "Level3");
                    intent.SetFlags(ActivityFlags.NewTask);
                    StaticSoal.Id = 0;
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

            if (countData != 0)
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

            Intent intent = new Intent(this, typeof(SoalLevel3Activity));
            StartActivity(intent);
        }

        private void TxtIsiC_Click(object sender, EventArgs e)
        {
            tb_jawab tbj = new tb_jawab();
            tbj.Id = StaticSoal.Id;
            tbj.jawaban = txtIsiC.Text;

            StaticSoal.listJawaban.Add(tbj);

            Intent intent = new Intent(this, typeof(SoalLevel3Activity));
            StartActivity(intent);
        }

        private void TxtIsiB_Click(object sender, EventArgs e)
        {
            tb_jawab tbj = new tb_jawab();
            tbj.Id = StaticSoal.Id;
            tbj.jawaban = txtIsiB.Text;

            StaticSoal.listJawaban.Add(tbj);

            Intent intent = new Intent(this, typeof(SoalLevel3Activity));
            StartActivity(intent);
        }

        private void TxtIsiA_Click(object sender, EventArgs e)
        {
            tb_jawab tbj = new tb_jawab();
            tbj.Id = StaticSoal.Id;
            tbj.jawaban = txtIsiA.Text;

            StaticSoal.listJawaban.Add(tbj);

            Intent intent = new Intent(this, typeof(SoalLevel3Activity));
            StartActivity(intent);
        }
    }
}

