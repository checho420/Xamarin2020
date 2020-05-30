using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.views;
using XamarinApp.Views;

namespace XamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage2();
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

        internal static void SetMainPage(HomePage homePage)
        {
            throw new NotImplementedException();
        }
    }
}
