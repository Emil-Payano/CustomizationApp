﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace CustomizationsApp.Services
{
   public interface IDeviceOrientation
    {
        DeviceOrientation GetOrientation();
    }
}
