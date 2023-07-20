using System;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.IO;
using Java.Net;

namespace AplikasiQuiz.Models
{
    public class DownloadImageFromUrl : AsyncTask<string, string, string>
    {

        private Context context;

        public DownloadImageFromUrl(Context context)
        {
            this.context = context;
        }

        protected override void OnPreExecute()
        {
            base.OnPreExecute();
        }

        protected override void OnPostExecute(string result)
        {
            string storagePath = Android.OS.Environment.ExternalStorageDirectory.Path;
            string filePath = System.IO.Path.Combine(storagePath, "test.pdf");
        }

        protected override string RunInBackground(params string[] @params)
        {
            string storagePath = Android.OS.Environment.ExternalStorageDirectory.Path;
            string filePath = System.IO.Path.Combine(storagePath, "test.pdf");
            int count;

            try
            {
                URL url = new URL(@params[0]);
                URLConnection connection = url.OpenConnection();
                connection.Connect();
                int lengthOfFile = connection.ContentLength;
                InputStream input = new BufferedInputStream(url.OpenStream(), lengthOfFile);
                OutputStream output = new FileOutputStream(filePath);

                byte[] data = new byte[1024];
                long total = 0;
                while((count = input.Read(data))!= -1)
                {
                    total += count;
                }

                output.Flush();
                output.Close();
                input.Close();
            }
            catch (Exception e)
            {

            }

            return null;
        }   
    }
}

