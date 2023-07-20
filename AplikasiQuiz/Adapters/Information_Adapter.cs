using System;
using Android.App;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using AplikasiQuiz.Models;
using Android.Content;

namespace AplikasiQuiz.Adapters
{
    public class Information_Adapter : BaseAdapter<tb_information>
     {
        TextView txtId, txtNama, txtType, txtKategori;
        ImageView imgRambu;

        public Information_Adapter(Activity activity, int listViewRow)
        {

        }

        public List<tb_information> listInformasi;
        private Context mContext;
        private Activity activity;



        public Information_Adapter(Context context, List<tb_information> items)
        {
            listInformasi = items;
            mContext = context;
        }

        public override int Count
        {
            get
            {
                try
                {
                    return listInformasi.Count;
                }
                catch (Exception)
                {
                    Toast.MakeText(Application.Context, "Can't connect to server !", ToastLength.Long).Show();

                    return 0;
                }
            }
        }

        public override tb_information this[int position]
        {
            get
            {
                return listInformasi[position];
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.informationListviewLayout, null, false);
            }

            txtId = row.FindViewById<TextView>(Resource.Id.txtId);
            txtNama = row.FindViewById<TextView>(Resource.Id.txtNama);
            txtKategori = row.FindViewById<TextView>(Resource.Id.txtKategori);
            txtType = row.FindViewById<TextView>(Resource.Id.txtType);
            imgRambu = row.FindViewById<ImageView>(Resource.Id.imgRambu);

            txtId.Text = listInformasi[position].Id.ToString();
            txtNama.Text = listInformasi[position].informasi;
            txtType.Text = Convert.ToString(listInformasi[position].type);
            txtKategori.Text = listInformasi[position].kategori;
            
            var img = listInformasi[position].gambar;

            if (img != null)
            {
                byte[] imageArray = listInformasi[position].gambar;
                Android.Graphics.Bitmap bitmap = BitmapFactory.DecodeByteArray(imageArray, 0, imageArray.Length);
                //Android.Graphics.Bitmap bMapScaled = Android.Graphics.Bitmap.CreateScaledBitmap(bitmap, 80, 80, true);
                imgRambu.SetImageBitmap(bitmap);
            }

            return row;
        }
    }
}

