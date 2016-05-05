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

namespace MaterialDesignCheckOut.Model
{
    public class Movie
    {
        public string Title { get; set; }
        public string Episode { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }

        public override string ToString()
        {
            return "Episode " + Episode + " " + Title + " by " + Director;
        }
    }
}