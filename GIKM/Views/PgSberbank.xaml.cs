﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgSberbank : ContentPage
    {
        public PgSberbank(string URL)
        {
            InitializeComponent();
            webView.Source = URL;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}