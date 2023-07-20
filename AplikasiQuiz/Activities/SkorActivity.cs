
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
using AplikasiQuiz.StaticDetails;

namespace AplikasiQuiz.Activities
{
    [Activity(Label = "SkorActivity")]
    public class SkorActivity : AppCompatActivity
    {
        private tb_soal tbs;
        private List<tb_soal> listSoal;
        List<int> listSalah = new List<int>();
        List<int> listBenar = new List<int>();
        private TextView txtNilaiBenar, txtNilaiSalah, txtNilaiSkor, txtKet;
        private Button btnMainMenu;
        private ImageLevel2 img2 = new ImageLevel2();
        private ImageLevel3 img = new ImageLevel3();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.scoring_layout);

            txtNilaiBenar = FindViewById<TextView>(Resource.Id.txtNilaiBenar);
            txtNilaiSalah = FindViewById<TextView>(Resource.Id.txtNilaiSalah);
            txtNilaiSkor = FindViewById<TextView>(Resource.Id.txtNilaiSkor);
            txtKet = FindViewById<TextView>(Resource.Id.txtKet);
            btnMainMenu = FindViewById<Button>(Resource.Id.btnMainMenu);

            btnMainMenu.Click += BtnMainMenu_Click;

            var listJawaban = StaticSoal.listJawaban;

            var listJawaban2 = StaticSoal.listJawaban2;

            string MyText = Intent.GetStringExtra("level");

            if (MyText == "Level2")
            {

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

                tbs.Id = 5;
                tbs.gambar = simpang4;
                tbs.soal = "Rambu diatas menunjukkan sebuah peringatan adanya apa?";
                tbs.pilihanA = "Simpang tiga";
                tbs.pilihanB = "Adanya Simpang Empat";
                tbs.pilihanC = "Adanya Simpang Lima";
                tbs.pilihanD = "Adanya Pos Medis";
                tbs.jawaban = "Adanya Simpang Empat";

                listSoal.Add(tbs);

                tbs.Id = 6;
                tbs.gambar = dilarangMendahului;
                tbs.soal = "Jika kita dijalan sedang menaiki kendaraan bermotor dan menemukan rambu lalu lintas seperti gambar di bawah ini, apa maksud dari rambu ini?";
                tbs.pilihanA = "Dilarang Mendahului";
                tbs.pilihanB = "Tikungan Tajam";
                tbs.pilihanC = "Dilarang Berbelok";
                tbs.pilihanD = "Ada Belokan di Depan";
                tbs.jawaban = "Dilarang Mendahului";

                listSoal.Add(tbs);

                tbs.Id = 7;
                tbs.gambar = empatpuluhkm;
                tbs.soal = "Jika kita dijalan sedang menaiki kendaraan bermotor dan menemukan rambu lalu lintas gambar di bawah ini termasuk jenis rambu apa dan maksudnya apa?";
                tbs.pilihanA = "Rambu dilarang berkecepatan lebih dari 40 km/jam";
                tbs.pilihanB = "Rambu dilarang berkecepatan kurang dari 40 km/jam";
                tbs.pilihanC = "Rambu petunjuk berkecepatan maksimal 40 km/jam";
                tbs.pilihanD = "A dan C Benar";
                tbs.jawaban = "Rambu dilarang berkecepatan lebih dari 40 km/jam";

                listSoal.Add(tbs);

                tbs.Id = 8;
                tbs.gambar = satuArah;
                tbs.soal = "Apa maksud dari rambu diatas?";
                tbs.pilihanA = "Rambu dilarang lurus";
                tbs.pilihanB = "Rambu satu arah";
                tbs.pilihanC = "Rambu dilarang mendahului";
                tbs.pilihanD = "Rambu wajib lurus";
                tbs.jawaban = "Rambu satu arah";

                listSoal.Add(tbs);

                tbs.Id = 9;
                tbs.gambar = laranganMelintasKedepan;
                tbs.soal = "Apa arti dari rambu diatas?";
                tbs.pilihanA = "Rambu larangan melintas terus ke depan";
                tbs.pilihanB = "Rambu petunjuk boleh maju ke depan";
                tbs.pilihanC = "Rambu arah di alihkan";
                tbs.pilihanD = "Rambu dilarang berhenti";
                tbs.jawaban = "Rambu larangan melintas terus ke depan";

                listSoal.Add(tbs);

                tbs.Id = 10;
                tbs.gambar = parkir;
                tbs.soal = "Rambu diatas artinya adalah 4 ?";
                tbs.pilihanA = "Dilarang Berhenti";
                tbs.pilihanB = "Silahkan Maju";
                tbs.pilihanC = "Dilarang Menyalip";
                tbs.pilihanD = "B dan C Benar";
                tbs.jawaban = "Dilarang Berhenti";

                listSoal.Add(tbs);

                var listAsc = listSoal.OrderByDescending(x => x.Id).ToList();

                for (int a = 0; a < listAsc.Count; a++)
                {
                    string kunci = listAsc[a].jawaban;
                    string jawaban = listJawaban[a].jawaban;

                    int b = 0;

                    if (kunci == jawaban)
                    {
                        int c = b + 1;

                        listBenar.Add(c);
                    }
                    else
                    {
                        int c = b + 1;

                        listSalah.Add(c);
                    }

                }

            }
            else
            {
                var apotek = System.Convert.FromBase64String(img.imageApotek());
                var balikdanbelokkanan = System.Convert.FromBase64String(img.imageBalikdanBelokKanan());
                var jalanbuntu = System.Convert.FromBase64String(img.imageJalanBuntu());
                var lebarruangbebas = System.Convert.FromBase64String(img.imageLebarRuangBebas());
                var parkirmundur = System.Convert.FromBase64String(img.imageParkirMundur());
                var perpus = System.Convert.FromBase64String(img.imagePerpus());
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

                var listAsc = listSoal.OrderByDescending(x => x.Id).ToList();

                for (int a = 0; a < listAsc.Count; a++)
                {
                    string kunci = listAsc[a].jawaban;
                    string jawaban = listJawaban[a].jawaban;

                    int b = 0;

                    if (kunci == jawaban)
                    {
                        int c = b + 1;

                        listBenar.Add(c);
                    }
                    else
                    {
                        int c = b + 1;

                        listSalah.Add(c);
                    }

                }
            }

            double countBenar = listBenar.Count;
            double countSalah = listSalah.Count;

            double totalSoal = countBenar + countSalah;
            double nilai = 100 / totalSoal;

            double skor = countBenar * nilai;

            txtNilaiBenar.Text = countBenar.ToString();
            txtNilaiSalah.Text = countSalah.ToString();
            txtNilaiSkor.Text = Math.Round(skor).ToString();

            if (skor < 60)
            {
                txtKet.Text = "Pengetahuan anda masih kurang, silahkan di tingkatkan lagi !!";

            }
            else
            {

                txtKet.Text = "Pengetahuan anda terhadap rambu lalu lintas sangat baik !!";

            }



            string oo = "";
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MenuActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        public override void OnBackPressed()
        {
           
        }
    }
}

