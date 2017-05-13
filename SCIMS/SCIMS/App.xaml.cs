using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Push;

using SCIMS.Pages;

namespace SCIMS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("android=c53edf74-42e6-45b9-aea2-e35081876ab4;" +
                   "uwp=4d91dbed-b7cd-4473-bb0d-8aeb8455561f;" +
                   "ios=292f90a8-cf19-45bd-a07b-a299823732b1",
                   typeof(Analytics), typeof(Crashes), typeof(Push));
        }
    }
}
