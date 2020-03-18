using CustomizationsApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomizationsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new OrientationPage();
            //MainPage = new EntryBackgroundColorPage();
            //MainPage = new RemoveLineEffectPage();
            //MainPage = new MenuPage();
            MainPage = new ElevationPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
