using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using DemoCheckOut.Fragments;
using DemoCheckOut.Adapters;

namespace DemoCheckOut
{
    [Activity(Theme = "@android:style/Theme.Material.Light.DarkActionBar", Label = "DemoCheckOut", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Android.Support.V4.App.FragmentActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            var fragments = new Android.Support.V4.App.Fragment[]
                {
                    new OrderFragment(),
                    new PaymentFragment(),
                    new ConfirmationFragment()
                };

            var titles = CharSequence.ArrayFromStringArray(new[]
                {
                    "Order",
                    "Payment",
                    "Confirmation"
                });
            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);

            viewPager.Adapter = new CheckoutAdapter(base.SupportFragmentManager, fragments, titles);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            //var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //var button = FindViewById<Button>(Resource.Id.btnCustomIconTabs);
            //button.Click += Clicked;
        }

        //private void Clicked(object sender, EventArgs e)
        //{
        //    var intent = new Intent(this, typeof(CustomViewIconTextTabActivity));
        //    StartActivity(intent);
        //}
    }
}

