using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;



namespace Fp
{
    [Activity(Label = "future destination")]
    public class myListView2 : Activity
    {
        
        static readonly string[] countries = new String[] {
            "Beijing","Shanghai","Taiwan","Chongqing","shenzhen"
            };
        ListView CountryList2;
        ArrayAdapter<string> countryDataAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.myListView);

            CountryList2 = FindViewById(Resource.Id.countryList) as ListView;

            countryDataAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, countries);
            CountryList2.Adapter = countryDataAdapter;


            CountryList2.ItemClick += listView_ItemClick;
        }

        void listView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //Get our item from the list adapter
            var item = this.countryDataAdapter.GetItem(e.Position);

            //Make a toast with the item name just to show it was clicked
            Toast.MakeText(this, item + " Clicked!", ToastLength.Short).Show();
        }

    }
}