using GIKM.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgEvents : ContentPage
    {
        public PgEvents()
        {
            InitializeComponent();
            BindingContext = new EventsList("GIKM");
        }

        void OnTap(object sender, ItemTappedEventArgs e)
        {
            var eventItem = e.Item as Event;
            Navigation.PushAsync(new PgEventDetail(eventItem.id));
        }

        void OnRefresh(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            BindingContext = new EventsList("GIKM");

            //make sure to end the refresh state
            list.IsRefreshing = false;
        }
    }
}