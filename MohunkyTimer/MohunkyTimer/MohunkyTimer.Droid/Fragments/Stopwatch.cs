using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MohunkyTimer.Droid.Fragments
{
    public class Stopwatch : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.DebugFragmentLayout, container, false);
            var sampleTextView = view.FindViewById<TextView>(Resource.Id.textView);
            sampleTextView.Text = "This is Stopwatch Fragment Sample";
            return view;
        }
    }
}