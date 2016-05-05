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
using MaterialDesignCheckOut.Model;
using MaterialDesignCheckOut.ViewHolder;
using Android.Support.V7.Widget;

namespace MaterialDesignCheckOut.Adapters
{
    public class RecyclerAdapter : RecyclerView.Adapter
    {

        private List<Alcohol> mData;
        private LayoutInflater mInflater;

        public RecyclerAdapter(Context context, List<Alcohol> data)
        {
            this.mData = data;
            this.mInflater = LayoutInflater.From(context);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var holder1 = (MyViewHolder)holder;
            Alcohol alcohol = mData[position];
            holder1.setData(alcohol);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = mInflater.Inflate(Resource.Layout.RecyclerViewChildCard, parent, false);

            return new MyViewHolder(view);

        }

        public override int ItemCount
        {
            get { return mData.Count; }
        }

    }
}