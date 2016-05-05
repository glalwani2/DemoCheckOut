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

namespace MaterialDesignCheckOut.ViewHolder
{
    public class MyViewHolder : RecyclerView.ViewHolder
    {
        public TextView beerNameTextView { get; set; }
        public ImageView beerImageView { get; set; }

        public MyViewHolder(View itemView) : base(itemView)
        {
            beerNameTextView = itemView.FindViewById<TextView>(Resource.Id.txv_row);
            beerImageView = itemView.FindViewById<ImageView>(Resource.Id.img_row);
        }

        public void setData(Alcohol alcohol)
        {
            this.beerNameTextView.Text = alcohol.alcoholName;
            this.beerImageView.SetImageResource(alcohol.imageId);
        }
    }
}