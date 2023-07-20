
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

namespace AplikasiQuiz.Activities
{
	[BroadcastReceiver]
	public class AndroidReceiver : BroadcastReceiver
	{
		public override void OnReceive (Context context, Intent intent)
		{
            //Toast.MakeText (context, "Received intent!", ToastLength.Short).Show ();
            
            string value = intent.GetStringExtra("IdDownload");

                long downloadId = intent.GetLongExtra(
                  DownloadManager.ExtraDownloadId, Convert.ToInt64(value));

        }
	}
}

