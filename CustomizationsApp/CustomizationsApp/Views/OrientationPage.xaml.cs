using CustomizationsApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace CustomizationsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrientationPage : ContentPage
    {
        public OrientationPage()
        {
            InitializeComponent();
           OrientationLabel.Text = DependencyService.Get<IDeviceOrientation>().GetOrientation().ToString();
        }
      
        
    }
}