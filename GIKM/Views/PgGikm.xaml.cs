using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Interfaces.Animations;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GIKM.ViewModels;

namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgGikm : ContentPage
    {
        public PgGikm()
        {
            InitializeComponent();
        }

         private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var _pagetoopen = new PUpPage(AppConstants.GIKM);
            OpenPopUp(_pagetoopen);
        }

        private async void OpenPopUp(PopupPage _page)
        {
            await Navigation.PushPopupAsync(_page);
        }
    }
}