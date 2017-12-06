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
    [Activity(Label = "contact")]
    public class contact : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.contact);



            // Get our button from the layout resource,
            // and attach an event to it
            Button btnCall = FindViewById<Button>(Resource.Id.btnCall);

            btnCall.Click += delegate {
                
                var uri2 = Android.Net.Uri.Parse("tel:6477846083");
                var callIntent = new Intent(Intent.ActionCall, uri2);
                StartActivity(callIntent);
            };

            Button btnSMS = FindViewById<Button>(Resource.Id.btnSMS);

            btnSMS.Click += delegate {

                var smsContent = FindViewById<EditText>(Resource.Id.txtSMS).Text;

                var smsUri = Android.Net.Uri.Parse("sendto:6477846083");
                var smsIntent = new Intent(Intent.ActionSendto, smsUri);
                smsIntent.PutExtra("sms_body", smsContent);
                StartActivity(smsIntent);
            };

            Button btnEmail = FindViewById<Button>(Resource.Id.btnEmail);

            btnEmail.Click += delegate {

                var email = new Intent(Android.Content.Intent.ActionSend);
                email.PutExtra(Android.Content.Intent.ExtraEmail,
                               new string[] { "wqw792559263@gmail.com", "wqw792559263@gmail.com" });

                email.PutExtra(Android.Content.Intent.ExtraCc, new string[] { "wqw792559263@gmail.com" });

                email.PutExtra(Android.Content.Intent.ExtraSubject, "Test Email");

                email.PutExtra(Android.Content.Intent.ExtraText, "This is a test email ");

                email.SetType("message/rfc822");
                StartActivity(email);
            };

        }
    }
}