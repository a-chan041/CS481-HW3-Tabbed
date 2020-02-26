using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Essentials;


namespace TippyTab
{
    public partial class Donate : ContentPage
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void Give (Object sender, EventArgs e) //this function takes users to a link attached to a button
        {
            Browser.OpenAsync("https://soleeffects.org/give", BrowserLaunchMode.SystemPreferred);
        }
    }
}
