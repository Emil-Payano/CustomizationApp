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
using CustomizationsApp.Controls;
using CustomizationsApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryDroid))]
namespace CustomizationsApp.Droid.Renderers
{
    public class ExtendedEntryDroid : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control!=null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Red);
            }
        }
        public ExtendedEntryDroid(Context context) : base(context)
        { 
        }
    
    }
}