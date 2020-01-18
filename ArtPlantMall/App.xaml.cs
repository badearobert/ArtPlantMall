using ArtPlantMall.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ArtPlantMallView();
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
