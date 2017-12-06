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

namespace Fp
{
    [Activity(Label = "AuthorDescription")]
    public class BlogAuthorDescription : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BlogAuthorDescription);

            // Create your application here
            Button showMenu = FindViewById<Button>(Resource.Id.button1);

            showMenu.Click += delegate {

                PopupMenu menu = new PopupMenu(this, showMenu);
                menu.Inflate(Resource.Menu.popup_menu);

                menu.MenuItemClick += (s1, e1) =>
                {
                    Toast.MakeText(this, e1.Item.TitleFormatted.ToString(), ToastLength.Long).Show();



                    switch (e1.Item.TitleFormatted.ToString())
                    {
                        case "Visited Places":
                            StartActivity(typeof(myListView));
                            break;
                            case "Future Destinations":
                             StartActivity(typeof(myListView2));
                            break;
                            case "Contact":
                            StartActivity(typeof(contact));
                            break;
                    }
                };
                menu.Show();


            };
        }
    }
}
 