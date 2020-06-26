using GIKM.ViewModels;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Interfaces.Animations;
using Rg.Plugins.Popup.Pages;
using System;
using System.IO;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgEventDetail : ContentPage
    {
        public PgEventDetail(int id)
        {
            InitializeComponent();
            var _singleEvent = new SingleEvent(id);
            this.BindingContext = _singleEvent;
            var byteArray = new WebClient().DownloadData(_singleEvent.singleEvent.imageUrl);
            this.imgTop.Source = ImageSource.FromStream(() => new MemoryStream(byteArray));
        }

        private void Button_Clicked_Buy(object sender, EventArgs e)
        {
            var _pagetoopen = new PUpPage();
            OpenPopUp(_pagetoopen);
        }

        private async void OpenPopUp (PopupPage _page)
        {
            await Navigation.PushPopupAsync(_page);
        }
    }
}