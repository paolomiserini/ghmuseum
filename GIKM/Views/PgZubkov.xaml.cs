
using GIKM.ViewModels;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgZubkov : ContentPage
    {
        public PgZubkov()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var _pagetoopen = new PUpPage(AppConstants.ZUBK);
            OpenPopUp(_pagetoopen);
        }

        private async void OpenPopUp(PopupPage _page)
        {
            await Navigation.PushPopupAsync(_page);
        }
    }
}