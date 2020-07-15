using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TotvsDevXamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AppCenter.Start("android=88792496-a93c-46f0-80cb-03dda2ef1e1c;" +
                  "ios=8aa53e88-a408-4ca7-85b4-6c5f8580f8b2",
                  typeof(Analytics), typeof(Crashes));

            MainPage = new MainPage();
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
