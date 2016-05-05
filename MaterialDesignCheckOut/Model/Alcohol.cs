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
    public class Alcohol
    {
        public int imageId { get; set; }
        public string alcoholName { get; set; }

        public List<Alcohol> alcohol { get; set; }
        public List<Alcohol> GetAlcoholData()
        {
            alcohol = new List<Alcohol>();
            for (int i = 0; i < 25; i++)
            {
                alcohol.Add(new Alcohol()
                {
                    imageId = Resource.Drawable.beer1,
                    alcoholName = "Carlsberg"
                });
            }
            return alcohol;
        }
    }

   
}