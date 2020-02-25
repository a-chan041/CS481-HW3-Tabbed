using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TippyTab.Services;
using TippyTab.Views;

namespace TippyTab
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainTabPage();
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
