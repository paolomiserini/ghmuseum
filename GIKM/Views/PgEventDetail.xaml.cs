﻿using GIKM.ViewModels;
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

        private void On_LabelTapped(object sender, EventArgs e)
        {
            // Todo implementare l'acquisto del biglietto ed il pagamento

            //var _pagetoopen = new PUpPage(AppConstants.GIKM);
            //OpenPopUp(_pagetoopen);
        }

 
    }
}