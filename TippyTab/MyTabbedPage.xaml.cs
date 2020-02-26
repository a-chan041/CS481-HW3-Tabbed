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
      
            Children.Add(new NewsPage()); //adds the other tabs as children to the main tabbed page
            Children.Add(new Testemonial()); //adds the other tabs as children to the main tabbed page
            Children.Add(new Donate()); //adds the other tabs as children to the main tabbed page
        }

        private void Web (Object sender, EventArgs e) //this function takes users to the link; using a button
        {
            Browser.OpenAsync("https://soleeffects.org/switch-adventure", BrowserLaunchMode.SystemPreferred);
        }

        protected override void OnAppearing() //on appearing call displays alert message as users navigate onto the page
        {
            base.OnAppearing();
            DisplayAlert("Hey there", "Welcome to SOLE Effects HQ, we want to thank you for visiting us.", "OK");

        }
    }
}
