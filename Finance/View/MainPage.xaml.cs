using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Finance
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);
        }
    }
}
