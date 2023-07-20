
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
    [Activity(Label = "NavigationActivity")]
    public class NavigationActivity : Activity
    {
        Button btnMenu, btnExit;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.navigation_layout);

            btnMenu = (Button)FindViewById(Resource.Id.btnMenu);
            btnExit = (Button)FindViewById(Resource.Id.btnExit);

            btnMenu.Click += BtnMenu_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.FinishAndRemoveTask();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MenuActivity));
            StartActivity(intent);
        }
    }
}

