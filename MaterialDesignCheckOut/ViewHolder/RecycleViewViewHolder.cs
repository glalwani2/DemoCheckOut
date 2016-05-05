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

namespace MaterialDesignCheckOut.ViewHolder
{
    public class RecycleViewViewHolder : RecyclerView.ViewHolder
    {
        public TextView MovieNameTextView { get; set; }
        public ImageView MovieImageView { get; set; }

        public RecycleViewViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            MovieNameTextView = itemView.FindViewById<TextView>(Resource.Id.cardViewText);
            MovieImageView = itemView.FindViewById<ImageView>(Resource.Id.imageView);

            itemView.Click += (s, e) => listener(Position);
        }
    }
}