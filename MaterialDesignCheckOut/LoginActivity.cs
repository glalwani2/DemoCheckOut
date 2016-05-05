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
using Android.Support.Design.Widget;

namespace MaterialDesignCheckOut
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        Button registerButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //SetContentView(Resource.Layout.Login);
            SetContentView(Resource.Layout.Login1);

            //var userNameWrapper = FindViewById<EditText>(Resource.Id.input_name);
            //var passwordWrapper = FindViewById<EditText>(Resource.Id.input_password);

            //userNameWrapper.SetHintTextColor(Android.Graphics.Color.Teal);

            // Create your application here
            registerButton = FindViewById<Button>(Resource.Id.btn_register);
            registerButton.Click += register_ButtonClick;
        }

        private void register_ButtonClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(RegisterActivity));
            StartActivity(intent);
        }
    }
}