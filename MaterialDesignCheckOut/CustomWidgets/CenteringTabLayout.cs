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
using Android.Util;
using Android.Support.V4.View;

namespace MaterialDesignCheckOut.CustomWidgets
{
    public class CenteringTabLayout : TabLayout
    {
        public CenteringTabLayout(Context context) : base(context)
        {
        }

        public CenteringTabLayout(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public CenteringTabLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        protected override void OnLayout(bool changed, int left, int top, int right, int bottom)
        {
            base.OnLayout(changed, left, top, right, bottom);

            View firstTab = ((ViewGroup)GetChildAt(0)).GetChildAt(0);
            View lastTab = ((ViewGroup)GetChildAt(0)).GetChildAt(((ViewGroup)GetChildAt(0)).ChildCount - 1);
            ViewCompat.SetPaddingRelative(GetChildAt(0), (Width / 2) - (firstTab.Width / 2), 0, (Width / 2) - (lastTab.Width / 2), 0);
        }
    }
}