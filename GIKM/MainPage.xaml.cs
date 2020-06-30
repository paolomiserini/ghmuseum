using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GIKM.Views;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace GIKM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //private SReferenceTicket.SoldServiceClient client;
        
        public MainPage()
        {
            InitializeComponent();
            //this.client = new SReferenceTicket.SoldServiceClient();
        }
        // 3 seconds delay and redirect to menu page
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(3000);
            await this.Navigation.PushAsync(new MenuPage());
        }

        //private void ListOfEvents()
        //{
        //    try
        //    {
        //        var seanceResponse = this.client.GetSeancesAsync("MuseumTestGate", "MuseumTestGate", "session1", true, "<Request dtBegin=\"20180501\" dtEnd=\"20200531\"/>");
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

    }
}
