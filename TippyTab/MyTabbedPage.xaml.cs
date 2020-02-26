using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TippyTab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            InitializeComponent();
      
            Children.Add(new NewsPage());
            Children.Add(new Testemonial());
            Children.Add(new Donate());
        }

        private void Web (Object sender, EventArgs e)
        {
            Browser.OpenAsync("https://soleeffects.org/switch-adventure", BrowserLaunchMode.SystemPreferred);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayAlert("Hey There", "Welcome to SOLE Effects HQ, we want to thank you for visiting us.", "OK");

        }
    }
}
