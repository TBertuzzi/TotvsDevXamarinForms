using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TotvsDevXamarinForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAnalytics_Clicked(object sender, EventArgs e)
        {
            var properties = new Dictionary<string, string> {
                { "Canal Net", "TOTVS" }
            };

            Analytics.TrackEvent("Pagina acessada",properties);
        }

        private void btnCrash_Clicked(object sender, EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }

        private void btnCrashException_Clicked(object sender, EventArgs e)
        {
            var crash = "Totvs";

            try
            {
                int numero = Convert.ToInt32(crash);
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }

        }

        private void btnCrashEvent_Clicked(object sender, EventArgs e)
        {
            var crash = "Totvs";
            try
            {
                int numero = Convert.ToInt32(crash);
            }
            catch (Exception exception)
            {
                var properties = new Dictionary<string, string> {
                 { "Canal Net", "TOTVS" },
                { "Conversao", "Numero" }
              };
                Crashes.TrackError(exception, properties);
            }
        }
    }
}
