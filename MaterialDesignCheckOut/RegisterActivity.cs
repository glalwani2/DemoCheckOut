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

namespace MaterialDesignCheckOut
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Register);
            // Create your application here
            var button = FindViewById<TextView>(Resource.Id.btnRegister);
            button.Click += register_Click;
        }

        private void register_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MaterialToolBarActivity));
            StartActivity(intent);
        }
    }
}