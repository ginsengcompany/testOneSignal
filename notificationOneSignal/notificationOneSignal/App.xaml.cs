using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.OneSignal;
using Xamarin.Forms;

namespace notificationOneSignal
{
    public partial class App : Application
    {

        private string app_id = "247b8425-652f-468e-800f-5a4559bb34c5";

        public App()
        {
            InitializeComponent();

            MainPage = new notificationOneSignal.MainPage();

            OneSignal.Current.StartInit(app_id).InFocusDisplaying(Com.OneSignal.Abstractions.OSInFocusDisplayOption.Notification).EndInit();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
