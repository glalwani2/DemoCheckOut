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
using MaterialDesignCheckOut.Model;
using MaterialDesignCheckOut.ViewHolder;

namespace MaterialDesignCheckOut.Adapters
{
    public class RecycleViewAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;

        private readonly List<Movie> movies;

        public RecycleViewAdapter(List<Movie> movies)
        {
            this.movies = movies;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var movieViewHolder = (RecycleViewViewHolder)holder;
            movieViewHolder.MovieNameTextView.Text = movies[position].Title;
            movieViewHolder.MovieImageView.SetImageResource(Resource.Drawable.starwarslogo);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layout = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.RecycleViewRow, parent, false);

            return new RecycleViewViewHolder(layout, OnItemClick);

        }

        public override int ItemCount
        {
            get { return movies.Count; }
        }

        void OnItemClick(int position)
        {
            ItemClick?.Invoke(this, position);
        }
    }
}