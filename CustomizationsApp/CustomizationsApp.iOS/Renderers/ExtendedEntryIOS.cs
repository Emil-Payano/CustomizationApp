using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomizationsApp.Controls;
using CustomizationsApp.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryIOS))]
namespace CustomizationsApp.iOS.Renderers
{
   public class ExtendedEntryIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIKit.UIColor.Red;
            }
        }
      

    }
}