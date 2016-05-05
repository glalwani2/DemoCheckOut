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
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using DemoCheckOut.Adapters;
using DemoCheckOut.Fragments;

namespace DemoCheckOut
{
    [Activity(Label = "CustomViewIconTextTabActivity")]
    public class CustomViewIconTextTabActivity : AppCompatActivity
    {
        private Toolbar toolbar;
        private TabLayout tabLayout;
        private ViewPager viewPager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CustomViewIconTextTabs);

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //setSupportActionBar(toolbar);
            //getSupportActionBar().setDisplayHomeAsUpEnabled(true);

            viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            setupViewPager(viewPager);

            tabLayout = FindViewById<TabLayout>(Resource.Id.tabs);
            tabLayout.SetupWithViewPager(viewPager);
            //setupTabIcons();

            // Create your application here
        }

        private void setupViewPager(ViewPager viewPager)
        {

            var titles = CharSequence.ArrayFromStringArray(new[]
                {
                    "Order",
                    "Payment",
                    "Confirmation"
                });

            var fragments = new Android.Support.V4.App.Fragment[]
                {
                    new OrderFragment(),
                    new PaymentFragment(),
                    new ConfirmationFragment()
                };
            viewPager.Adapter = new CheckoutAdapter(base.SupportFragmentManager, fragments, titles);
        }

        //private void setupTabIcons()
        //{

        //    TextView tabOne = (TextView)LayoutInflater.from(this).inflate(R.layout.custom_tab, null);
        //    tabOne.text
        //    tabOne.setCompoundDrawablesWithIntrinsicBounds(0, R.drawable.ic_tab_favourite, 0, 0);
        //    tabLayout.getTabAt(0).setCustomView(tabOne);

        //    TextView tabTwo = (TextView)LayoutInflater.from(this).inflate(R.layout.custom_tab, null);
        //    tabTwo.setText("CONFIRMATION");
        //    tabTwo.setCompoundDrawablesWithIntrinsicBounds(0, R.drawable.ic_tab_call, 0, 0);
        //    tabLayout.getTabAt(1).setCustomView(tabTwo);

        //    TextView tabThree = (TextView)LayoutInflater.from(this).inflate(R.layout.custom_tab, null);
        //    tabThree.setText("PAYMENT");
        //    tabThree.setCompoundDrawablesWithIntrinsicBounds(0, R.drawable.ic_tab_contacts, 0, 0);
        //    tabLayout.getTabAt(2).setCustomView(tabThree);
        //}
    }
}