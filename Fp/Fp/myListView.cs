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
    [Activity(Label = "Visited places")]
    public class myListView : Activity
    {
        
        static readonly string[] countries = new String[] {
            "Niagara-falls","Vancouver","Edward Prince Island","Montreal",
            };
        ListView CountryList1;
        ArrayAdapter<string> countryAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.myListView);

            CountryList1 = FindViewById(Resource.Id.countryList) as ListView;

            countryAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, countries);
            CountryList1.Adapter = countryAdapter;


            CountryList1.ItemClick += listView_ItemClick;
        }

        void listView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //Get our item from the list adapter
            var item = this.countryAdapter.GetItem(e.Position);

            //Make a toast with the item name just to show it was clicked
            Toast.MakeText(this, item + " Clicked!", ToastLength.Short).Show();
        }

    }
}