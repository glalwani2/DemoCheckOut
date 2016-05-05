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
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.Widget;
using MaterialDesignCheckOut.Adapters;
using MaterialDesignCheckOut.Model;

namespace MaterialDesignCheckOut
{
    [Activity(Label = "")]
    public class MaterialToolBarActivity : AppCompatActivity
    {
        private Toolbar toolbar;
        RecyclerView recyclerView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MaterialToolBar);

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            SetSupportActionBar(toolbar);

            toolbar.SetTitle(Resource.String.ApplicationName);

            toolbar.SetLogo(Resource.Drawable.Icon);
            setUpRecyclerView();
            //toolbar.InflateMenu(Resource.Menu.menu_main);
            //toolbar.MenuItemClick += OnMenuItem_Clicked;
            // Create your application here
        }

        private void setUpRecyclerView()
        {
            Alcohol alcohol = new Alcohol();
            recyclerView = (RecyclerView)FindViewById<RecyclerView>(Resource.Id.itemsRecyclerView);
            RecyclerAdapter adapter = new RecyclerAdapter(this, alcohol.GetAlcoholData());
            recyclerView.SetAdapter(adapter);

            GridLayoutManager gridLayoutManager = new GridLayoutManager(Application.Context, 2);
            recyclerView.SetLayoutManager(gridLayoutManager);
        }

        //private void OnMenuItem_Clicked(object sender, Toolbar.MenuItemClickEventArgs e)
        //{

        //}

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            String msg = "";

            switch (item.ItemId)
            {

                case Resource.Id.discard:
                    msg = GetString(Resource.String.delete);
                    break;


                case Resource.Id.search:
                    msg = GetString(Resource.String.search);
                    break;


                case Resource.Id.edit:
                    msg = GetString(Resource.String.edit);
                    break;


                case Resource.Id.settings:
                    msg = GetString(Resource.String.settings);
                    break;


                case Resource.Id.Exit:
                    msg = GetString(Resource.String.exit);
                    break;
            }
            Toast.MakeText(this, msg + "Clicked !" , ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }
    }
}