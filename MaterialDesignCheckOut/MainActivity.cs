using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace MaterialDesignCheckOut
{
    [Activity(Label = "MaterialDesignCheckOut", Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        private Toolbar toolbar;
        private Button btnCustomIconTextTabs;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            // Get our button from the layout resource,
            // and attach an event to it
            btnCustomIconTextTabs = FindViewById<Button>(Resource.Id.btnCustomIconTabs);

            btnCustomIconTextTabs.Click += buttonClick;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(CustomViewIconTextTabsActivity));
            StartActivity(intent);
        }
    }
}

