
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Android.Accounts;
using Android.App;
using Android.Content;
using Android.Database;
using Android.Graphics;
using Android.Icu.Util;
using Android.Media;
using Android.Net;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using AndroidX.AppCompat.App;
using AplikasiQuiz.Models;
using Java.Lang.Reflect;
using Java.Net;
using Java.Util;
using Java.Util.Logging;
using Xamarin.Essentials;
using static Android.Bluetooth.BluetoothClass;
using static Android.Provider.MediaStore;
using static Android.Renderscripts.Sampler;
using CookieManager = Android.Webkit.CookieManager;
using Environment = Android.OS.Environment;

namespace AplikasiQuiz.Activities
{
    [Activity(Label = "KelolaMateriActivity")]
    public class KelolaMateriActivity : AppCompatActivity
    {
        private TextView txtDownload1, txtDownload2;
        private ImageView imgBack;
        BroadcastReceiver receiver = new AndroidReceiver();
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.download_Layout);

            txtDownload1 = FindViewById<TextView>(Resource.Id.txtDownload1);
            txtDownload2 = FindViewById<TextView>(Resource.Id.txtDownload2);
            imgBack = FindViewById<ImageView>(Resource.Id.imgBack);

            txtDownload1.Click += TxtDownload1_Click;
            imgBack.Click += ImgBack_Click;

            txtDownload2.Click += TxtDownload2_Click;

            //async Task RequestPermissions()
            //{
            //    var status = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();
            //    var status2 = await Permissions.CheckStatusAsync<Permissions.StorageRead>();

            //    if (status != PermissionStatus.Granted)
            //    {
            //        await Permissions.RequestAsync<Permissions.StorageWrite>();
            //    }
            //    if (status2 != PermissionStatus.Granted)
            //    {
            //        await Permissions.RequestAsync<Permissions.StorageRead>();
            //    }
            //}

        }

        private void TxtDownload2_Click(object sender, EventArgs e)
        {
            string downloadUrl = "https://drive.google.com/file/d/1KTTkuQe-LfsLwiwioC76ij0qNl_sPSxH/view?usp=sharing";

            Intent intent = new Intent(this, typeof(DownloadActivity));
            intent.PutExtra("Id", downloadUrl);
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        public override void OnBackPressed()
        {
            
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MenuActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        private void TxtDownload1_Click(object sender, EventArgs e)
        {
            string downloadUrl = "https://drive.google.com/file/d/1KTTkuQe-LfsLwiwioC76ij0qNl_sPSxH/view?usp=sharing";

            Intent intent = new Intent(this, typeof(DownloadActivity));
            intent.PutExtra("Id", downloadUrl);
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);

            //var filePath = await DownloadPdfFileAsync(url);

            //if (filePath != null)
            //{
            //    await Launcher.OpenAsync(new OpenFileRequest
            //    {
            //        File = new ReadOnlyFile(filePath)
            //    });
            //}

            //DownloadImageFromUrl download = new DownloadImageFromUrl(this);
            //download.Execute(url);


            //var manager = DownloadManager.FromContext(this);

            //var request = new DownloadManager.Request(Android.Net.Uri.Parse(url));
            //long downloadId = manager.Enqueue(request);
            //request.SetAllowedNetworkTypes(DownloadNetwork.Mobile);
            //request.SetAllowedNetworkTypes(DownloadNetwork.Wifi);

            //kodingan download
            //var manager = DownloadManager.FromContext(this);
            //var request = new DownloadManager.Request(Android.Net.Uri.Parse(downloadUrl));

            //request.SetAllowedNetworkTypes(DownloadNetwork.Mobile);
            //request.SetAllowedNetworkTypes(DownloadNetwork.Wifi);

            //var fileName = "MyFileName.{extension}";

            //request.SetNotificationVisibility(DownloadVisibility.VisibleNotifyCompleted);


            // request.SetDestinationInExternalFilesDir(Platform.CurrentActivity, Environment.DirectoryDownloads, fileName);
            //request.SetTitle("Title of Item");
            //request.SetDescription(downloadDescription);

            //long downloadId = manager.Enqueue(request);
            //var query = new DownloadManager.Query();
            //query.SetFilterById(downloadId);
            //ICursor cursor = manager.InvokeQuery(query);

            //if (cursor.MoveToFirst())
            //{
            //    var statusIndex = cursor.GetColumnIndex(
            //      DownloadManager.ColumnStatus);
            //    var soFarIndex = cursor.GetColumnIndex(
            //      DownloadManager.ColumnBytesDownloadedSoFar);
            //    var totalIndex = cursor.GetColumnIndex(
            //      DownloadManager.ColumnTotalSizeBytes);

            //    var status = (DownloadStatus)cursor.GetInt(statusIndex);
            //    double soFar = cursor.GetDouble(soFarIndex);
            //    double total = cursor.GetDouble(totalIndex);
            //    string progress = (soFar / total).ToString("0.00 %");
            //    var intent = new Intent();
            //    intent.SetAction(DownloadManager.ActionViewDownloads);
            //    StartActivity(intent);

            //}

        }

        private async Task<string> DownloadPdfFileAsync(string url)
        {
            var filePath = System.IO.Path.Combine(FileSystem.AppDataDirectory, "test.pdf");

            if (File.Exists(filePath))
                return filePath;

            var httpClient = new HttpClient();
            var pdfBytes = await httpClient.GetByteArrayAsync(url);

            try
            {
                File.WriteAllBytes(filePath, pdfBytes);

                return filePath;
            }
            catch (Exception ex)
            {
                //await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }

            return null;
        }

        
    }
}

