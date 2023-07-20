
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
using AplikasiQuiz.Adapters;
using AplikasiQuiz.Models;
using AplikasiQuiz.StaticDetails;
using Java.IO;

namespace AplikasiQuiz.Activities
{
    [Activity(Label = "InformationActivity")]
    public class InformationActivity : AppCompatActivity
    {
        private List<tb_information> listInformasi;
        private tb_information tbi;
        private ListView lvInformasi;
        private Information_Adapter adapterInformation;
        private ImageView imgArrow;
        private ImageLevel2 img2 = new ImageLevel2();
        private ImageLevel3 img = new ImageLevel3();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.information_layout);

            lvInformasi = FindViewById<ListView>(Resource.Id.lvInformasi);
            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);

            string code = Intent.GetStringExtra("Id") ?? string.Empty;

            lvInformasi.ItemClick += LvInformasi_Click;
            imgArrow.Click += ImgArrow_Click;

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

            listInformasi = new List<tb_information>();

            tbi = new tb_information();
            tbi.Id = 1;
            tbi.nama = "Rambu Dilarang Berhenti";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Larangan";
            tbi.informasi = "Rambu lalu lintas larangan adalah rambu yang digunakan untuk menyatakan suatu perbuatan yang dilarang " +
                "dilakukan oleh pengguna jalan. Rambu dengan huruf ‘S’ dalam lingkaran merah yang diberi garis diagonal ini termasuk rambu larangan. " +
                "Digunakan untuk memberitahukan pengguna jalan bahwa di area  tertentu mereka dilarang untuk menghentikan kendaraannya. ";
            tbi.gambar = stop;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 2;
            tbi.nama = "Rambu Lalu Lintas Alat Pemberi Isyarat Lalu Lintas";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Peringatan";
            tbi.informasi = "Sign ini berfungsi untuk mengatur kendaraan demi ketertiban berlalu lintas. Alat pemberi isyarat terdiri dari tiga warna, " +
                "yaitu merah (berhenti), kuning (waspada), dan hijau (jalan terus).Pemasangan sign ini bermanfaat sebagai peringatan pengaturan " +
                "persinyalan guna meminimalisasi angka kecelakaan lalu lintas yang dapat mengancam keselamatan jiwa pengguna jalan.";
            tbi.gambar = traffic;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 3;
            tbi.nama = "Rambu Pendahulu Petunjuk Jurusan Yang Menunjukkan Jurusan Yang Dituju";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Rambu berwarna dasar hijau dan tulisan serta piktogram berwarna putih ini adalah rambu petunjuk. Digunakan untuk memberikan " +
                "informasi kepada pengguna jalan mengenai pendahulu petunjuk jurusan yang menunjukkan jurusan yang akan dituju, yaitu Bekasi, Kranji dan Jakarta/ Bandung.";
            tbi.gambar = guide;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 4;
            tbi.nama = "RAMBU LALU LINTAS PERINTAH MENGGUNAKAN JALUR ATAU LAJUR LALU LINTAS KHUSUS PEJALAN KAKI";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Sign lalu lintas ini menyatakan perintah kepada pejalan kaki untuk menggunakan jalur atau lajur lalu lintas khusus pejalan kaki. Rambu perintah berfungsi untuk menyatakan perintah yang wajib dilakukan oleh setiap pengguna jalan demi terciptanya kelancaran dan kenyamanan saat berkendara. Rambu perintah berbentuk bundar berwarna biru dan piktogram berwarna putih serta merah untuk garis serong sebagai batas akhir perintah.\n\n";
            tbi.gambar = pejalanKaki;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 5;
            tbi.nama = "RAMBU LALU LINTAS SIMPANG EMPAT";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Sign ini berfungsi untuk memperingatkan pengguna jalan agar berhati-hati akan adanya potensi bahaya di persimpangan empat jalan. Pemasangan rambu peringatan persimpangan prioritas menginformasikan bila suatu persimpangan arus di jalan utama (mayor) bersimpangan dengan jalan kecil (minor), maka kendaraan yang berada di jalan utama mendapat hak terlebih dahulu. Dipasang pada lengan jalan minor (jalan kecil)";
            tbi.gambar = simpang4;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 6;
            tbi.nama = "RAMBU LALU LINTAS DILARANG MENDAHULUI KENDARAAN LAIN";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Larangan";
            tbi.informasi = "Rambu lalu lintas larangan adalah rambu yang digunakan untuk menyatakan suatu perbuatan yang dilarang dilakukan oleh pengguna jalan. Rambu ini termasuk rambu larangan. Digunakan untuk memberitahukan pengguna jalan bahwa di area tertentu mereka dilarang untuk menyalip kendaraan lain.";
            tbi.gambar = dilarangMendahului;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 7;
            tbi.nama = "RAMBU LALU LINTAS PERINTAH BATAS MINIMUM KECEPATAN YANG DIPERINTAHKAN";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Perintah";
            tbi.informasi = "Sign lalu lintas ini menyatakan perintah kepada pengguna jalan untuk berkendara dengan kecepatan minimum yang diperintahkan, yaitu  40 km/ jam. Rambu perintah berfungsi untuk menyatakan perintah yang wajib dilakukan oleh setiap pengguna jalan demi terciptanya kelancaran dan kenyamanan saat berkendara. Rambu perintah berbentuk bundar berwarna biru dan piktogram berwarna putih serta merah untuk garis serong sebagai batas akhir perintah";
            tbi.gambar = empatpuluhkm;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 8;
            tbi.nama = "RAMBU LALU LINTAS PETUNJUK SISTEM SATU ARAH";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Rambu petunjuk berfungsi sebagai pemandu jalan atau pemberi informasi lain saat seseorang sedang melakukan perjalanan. Rambu dengan warna dasar biru dan piktogram tanda panah ke arah atas ini termasuk rambu petunjuk pengaturan lalu lintas. Digunakan untuk memberikan informasi kepada pengguna jalan bahwa mereka berada di sistem jalan satu arah.";
            tbi.gambar = satuArah;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 9;
            tbi.nama = "RAMBU LALU LINTAS DILARANG BERJALAN TERUS";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Larangan";
            tbi.informasi = "Rambu lalu lintas larangan adalah rambu yang digunakan untuk menyatakan suatu perbuatan yang dilarang dilakukan oleh pengguna jalan. Rambu dengan piktogram berupa tanda panah ke arah atas dalam lingkaran merah yang diberi garis diagonal ini termasuk rambu larangan. Digunakan untuk memberitahukan pengguna jalan bahwa di area  tertentu mereka dilarang untuk terus menjalankan kendaraannya";
            tbi.gambar = laranganMelintasKedepan;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 10;
            tbi.nama = "RAMBU LALU LINTAS LOKASI FASILITAS PARKIR";
            tbi.type = "Level 2";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Rambu petunjuk berfungsi sebagai pemandu jalan atau pemberi informasi lain saat seseorang sedang melakukan perjalanan. Rambu dengan warna dasar biru serta piktogram berupa huruf P berwarna putih ini termasuk rambu petunjuk. Digunakan untuk memberikan informasi mengenai lokasi fasilitas parkir.";
            tbi.gambar = parkir;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 11;
            tbi.nama = "RAMBU LALU LINTAS LOKASI APOTEK";
            tbi.type = "Level 3";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Rambu petunjuk berfungsi sebagai pemandu jalan atau pemberi informasi lain saat seseorang sedang melakukan perjalanan. Rambu dengan warna dasar biru serta piktogram berupa mortar (alat penumbuk obat) dengan palang merah di dalamnya ini termasuk rambu petunjuk. Digunakan untuk memberikan informasi mengenai lokasi apotek";
            tbi.gambar = apotek;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 12;
            tbi.nama = "RAMBU LALU LINTAS DILARANG MEMUTAR BALIK DAN BELOK KANAN";
            tbi.type = "Level 3";
            tbi.kategori = "Rambu Larangan";
            tbi.informasi = "Rambu lalu lintas larangan adalah rambu yang digunakan untuk menyatakan suatu perbuatan yang dilarang dilakukan oleh pengguna jalan. Rambu ini termasuk rambu larangan. Digunakan untuk memberitahukan pengguna jalan bahwa di area  tertentu mereka dilarang untuk memutar balik dan membelokan kendaraannya ke sebelah kanan";
            tbi.gambar = balikdanbelokkanan;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 13;
            tbi.nama = "RAMBU LALU LINTAS PETUNJUK JALAN BUNTU DIDEPAN";
            tbi.type = "Level 3";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Rambu dengan warna dasar biru, garis tepi putih, serta piktogram berupa dua persegi panjang yang menyerupai bentuk huruf T ini adalah rambu petunjuk pengaturan lalu lintas. Digunakan untuk memberikan informasi kepada pengguna jalan bahwa di depan mereka terdapat jalan buntu.";
            tbi.gambar = jalanbuntu;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 14;
            tbi.nama = "RAMBU LALU LINTAS LEBAR RUANG BEBAS";
            tbi.type = "Level 3";
            tbi.kategori = "Rambu Peringatan";
            tbi.informasi = "Sign ini berfungsi untuk memperingatkan pengguna jalan agar berhati-hati saat melintasi jalan dengan lebar tertentu. Lebar ruang bebas ditentukan sesuai dengan lebar badan jalan. Ruang bebas dibuat guna menunjang pelayanan lalu lintas dan angkutan jalan serta pengamanan konstruksi jalan.";
            tbi.gambar = lebarruangbebas;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 15;
            tbi.nama = "RAMBU K3 PARKIR";
            tbi.type = "Level 3";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Sign ini memberi petunjuk agar pengendara mobil memarkir kendaraannya dengan posisi mundur. Cara parkir mundur biasanya digunakan untuk tempat parkir dengan luas terbatas. Biasanya dipasang di tempat parkir perkantoran, pusat perbelanjaan, hotel, dan sebagainya.";
            tbi.gambar = parkirmundur;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 16;
            tbi.nama = "RAMBU LALU LINTAS LOKASI PERPUSTAKAAN";
            tbi.type = "Level 3";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Rambu petunjuk berfungsi sebagai pemandu jalan atau pemberi informasi lain saat seseorang sedang melakukan perjalanan. Rambu dengan warna dasar biru dan piktogram berupa orang yang sedang membaca buku ini termasuk rambu petunjuk. Digunakan untuk memberikan informasi mengenai lokasi salah satu fasilitas pendidikan, yaitu perpustakaan";
            tbi.gambar = perpus;

            listInformasi.Add(tbi);

            //tbi = new tb_information();
            //tbi.Id = 17;
            //tbi.nama = "RAMBU LALU LINTAS LOKASI APOTEK";
            //tbi.type = "Level 3";
            //tbi.kategori = "Rambu Petunjuk";
            //tbi.informasi = "";
            //tbi.gambar = prioritas;
            //tbi.gambar = perpus;

            //listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 17;
            tbi.nama = "RAMBU LALU LINTAS DILARANG BERJALAN TERUS";
            tbi.type = "Level 3";
            tbi.kategori = "Rambu Peringatan";
            tbi.informasi = "Rambu berbentuk segitiga sama sisi dengan titik-titik sudut yang dibulatkan ini termasuk rambu larangan. Digunakan untuk memberitahukan pengguna jalan bahwa di area tertentu mereka dilarang untuk berjalan terus karena wajib memberi prioritas kepada arus lalu lintas dari arah yang diberi prioritas";
            tbi.gambar = segitiga;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 18;
            tbi.nama = "RAMBU LALU LINTAS TIKUNGAN TAJAM GANDA DENGAN TIKUNGAN PERTAMA KE KANAN";
            tbi.type = "Level 3";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Sign ini berfungsi untuk memperingatkan pengguna jalan agar berhati-hati akan adanya potensi bahaya saat melintasi tikungan tajam ganda dengan tikungan pertama ke kanan. Pemasangan sign ini bermanfaat untuk menciptakan ketertiban lalu lintas dan meminimalisasi angka kecelakaan lalu lintas yang dapat mengancam keselamatan jiwa pengguna jalan.\n\n";
            tbi.gambar = tikungantajamkanan;

            listInformasi.Add(tbi);

            tbi = new tb_information();
            tbi.Id = 19;
            tbi.nama = "RAMBU LALU LINTAS PETUNJUK MENDAPATKAN PRIORITAS";
            tbi.type = "Level 3";
            tbi.kategori = "Rambu Petunjuk";
            tbi.informasi = "Rambu dengan warna dasar biru dan piktogram berupa dua tanda panah yang berlawanan arah berwarna merah dan putih ini adalah rambu petunjuk pengaturan lalu lintas. Digunakan untuk memberikan petunjuk kepada pengguna jalan bahwa mereka mendapatkan prioritas melanjutkan perjalanan dari arah berlawanan";
            tbi.gambar = tinggilebihdari;

            listInformasi.Add(tbi);

            if (code == "Level 2")
            {
                try
                {
                    var dataKu = listInformasi.Where(x => x.type == code).ToList();
                    adapterInformation = new Information_Adapter(this, dataKu);
                    lvInformasi.Adapter = adapterInformation;

                }catch(Exception e)
                {
                    Toast.MakeText(this, e.ToString(), ToastLength.Long).Show();
                }
            }
            else
            {
                var dataKu = listInformasi.Where(x => x.type == code).ToList();
                adapterInformation = new Information_Adapter(this, dataKu);
                lvInformasi.Adapter = adapterInformation;
            }
        }

        private void ImgArrow_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainInformationActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        private void LvInformasi_Click(object sender, AdapterView.ItemClickEventArgs e)
        {
            var data = adapterInformation[e.Position];

            StaticInformation.Id = data.Id;
            StaticInformation.type = data.type;
            StaticInformation.kategori = data.kategori;
            StaticInformation.nama = data.nama;
            StaticInformation.informasi = data.informasi;
            StaticInformation.gambar = data.gambar;

            Intent intent = new Intent(this, typeof(DetailInformationActivity));
            StartActivity(intent);
        }

        public override void OnBackPressed()
        {
            
        }
    }
}

