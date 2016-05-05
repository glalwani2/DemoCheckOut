using Android.OS;
using Android.Views;

namespace DemoCheckOut.Fragments
{
    public class OrderFragment : Android.Support.V4.App.Fragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return inflater.Inflate(Resource.Layout.OrderFragmentView, container, false);
        }
    }
}