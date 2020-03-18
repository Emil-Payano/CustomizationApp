using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using CustomizationsApp.iOS.Services;
using CustomizationsApp.Services;
using Foundation;
using UIKit;
using Xamarin.Forms.Internals;

[assembly: Xamarin.Forms.Dependency(typeof(CustomizationsApp.iOS.Services.DeviceOrientationService))]
namespace CustomizationsApp.iOS.Services
{
   public class DeviceOrientationService : IDeviceOrientation
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}