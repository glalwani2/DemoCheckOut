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
using Android.Support.V7.Widget;
using Android.Support.Design.Widget;
using MaterialDesignCheckOut.Adapters;
using MaterialDesignCheckOut.Model;

namespace MaterialDesignCheckOut
{
    [Activity(Label = "RecyclerViewMainActivity")]
    public class RecyclerViewMainActivity : Activity
    {
        private RecyclerView recyclerView;
        private RecyclerView.LayoutManager layoutManager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RecycleViewMain);
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            layoutManager = new LinearLayoutManager(Application.Context, LinearLayoutManager.Vertical, false);

            recyclerView.SetLayoutManager(layoutManager);

            var moviesAdapter = new RecycleViewAdapter(MoviesRepository.Movies);

            recyclerView.SetAdapter(moviesAdapter);

            moviesAdapter.ItemClick += MoviesAdapter_ItemClick;

            //SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            //SupportActionBar.SetHomeButtonEnabled(false);
        }

        private void MoviesAdapter_ItemClick(object sender, int e)
        {
            var linearLayout = this.FindViewById<LinearLayout>(Resource.Id.main_content);

            Snackbar.Make(linearLayout, MoviesRepository.Movies[e].ToString(), Snackbar.LengthLong).Show(); // Don’t forget to show!

        }
    }
}