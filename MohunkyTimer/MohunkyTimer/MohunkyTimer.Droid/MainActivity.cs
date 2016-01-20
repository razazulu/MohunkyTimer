using Android.App;
using Android.OS;
using Android.Util;
using Android.Views;
using MohunkyTimer.Droid.Fragments;

namespace MohunkyTimer.Droid
{
    [Activity(Label = "Mohunky Timer", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, ActionBar.ITabListener
    {
        #region Activity lifecycle stuff
        protected override void OnCreate(Bundle bundle)
        {
            Log.Debug(GetType().FullName, "MainActivity - OnCreate");

            base.OnCreate(bundle);

            //Debugging
            //Window.SetFlags(WindowManagerFlags.KeepScreenOn, WindowManagerFlags.KeepScreenOn);
            
            //Action bar setup
            RequestWindowFeature(WindowFeatures.ActionBar);
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            
            AddTab(Resources.GetString(Resource.String.tab_timer_text), -1, new Timer());
            AddTab(Resources.GetString(Resource.String.tab_alarm_text), -1, new Alarm());
            AddTab(Resources.GetString(Resource.String.tab_stopwatch_text), -1, new Stopwatch());

            SetContentView(Resource.Layout.MainActivity);
        }
        #endregion



        #region ActionBar stuff

        void AddTab(string tabText, int iconResourceId, Fragment fragment)
        {
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);
            if(iconResourceId != -1)tab.SetIcon(iconResourceId);

            // must set event handler for replacing tabs tab
            tab.TabSelected += delegate(object sender, ActionBar.TabEventArgs e)
            {
                e.FragmentTransaction.Replace(Resource.Id.fragmentContainer, fragment);
            };

            this.ActionBar.AddTab(tab);
        }  

        public void OnTabReselected(ActionBar.Tab tab, FragmentTransaction ft)
        {
        }

        public void OnTabSelected(ActionBar.Tab tab, FragmentTransaction ft)
        {
            switch (tab.Position)
            {
                case 0:
                    //Show content of tab1
                    break;

                case 1:
                    //Show content of tab2
                    break;

                default:
                    break;
            }
        }

        public void OnTabUnselected(ActionBar.Tab tab, FragmentTransaction ft)
        {
        }
        #endregion
    }
}


