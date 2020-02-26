using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TippyTab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
        }
        protected override void OnDisappearing() //OnDisapperaing displays an alert as users navigate away from the page
        {
            DisplayAlert("Before you go!", "If you would like to become a Mentor, visit our website in the Home tab", "OK");
            base.OnDisappearing();
        }
    }
}
