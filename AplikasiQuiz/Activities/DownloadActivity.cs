
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AplikasiQuiz.Activities
{
	[Activity (Label = "DownloadActivity")]			
	public class DownloadActivity : AppCompatActivity, IDownloadListener
	{
		WebView webView;
		AndroidReceiver receiver;
        ImageView imgArrow;
        private ImageView imgBack;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView(Resource.Layout.DownloadWebView);

			webView = FindViewById<WebView>(Resource.Id.webView1);
            imgArrow = FindViewById<ImageView>(Resource.Id.imgArrow);
            imgBack = FindViewById<ImageView>(Resource.Id.imgBack);

            webView = (WebView)FindViewById(Resource.Id.webView1);
            webView.Settings.JavaScriptEnabled = true;
            webView.Settings.BuiltInZoomControls = true;
            webView.SetWebViewClient(new HybridWebViewClient());
            webView.Settings.UseWideViewPort = false;

            string code = Intent.GetStringExtra("Id") ?? string.Empty;

            webView.LoadUrl(code);

            webView.SetDownloadListener(this);

            imgBack.Click += ImgBack_Click;

        }

        public override void OnBackPressed()
        {
            
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(KelolaMateriActivity));
            intent.SetFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }

        protected override void OnResume()
        {
            base.OnResume();
            var filter = new IntentFilter(DownloadManager.ActionDownloadComplete);

            receiver = new AndroidReceiver();
            RegisterReceiver(receiver, filter);
        }

        protected override void OnPause()
        {
            UnregisterReceiver(receiver);
            base.OnPause();
        }

        public void OnDownloadStart(string url, string userAgent, string contentDisposition, string mimetype, long contentLength)
        {
            DownloadManager.Request request = new DownloadManager.Request(Android.Net.Uri.Parse(url));
            String cookies = CookieManager.Instance.GetCookie(url);
            request.AddRequestHeader("cookie", cookies);
            request.AddRequestHeader("User-Agent", userAgent);
            request.SetDescription("Downloading file to crn folder...");
            request.SetTitle(URLUtil.GuessFileName(url, contentDisposition, mimetype));
            request.AllowScanningByMediaScanner();
            request.SetNotificationVisibility(Android.App.DownloadVisibility.VisibleNotifyCompleted);

            request.SetDestinationInExternalFilesDir(Application.Context, "download",
                URLUtil.GuessFileName(url, contentDisposition, mimetype));
            DownloadManager manager = (DownloadManager)GetSystemService(Android.App.Application.DownloadService);
            manager.Enqueue(request);
        }
    }
}

