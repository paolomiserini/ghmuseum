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
        }

        void OnTap(object sender, ItemTappedEventArgs e)
        {
            var eventItem = e.Item as Event;
            Navigation.PushAsync(new PgEventDetail(eventItem.id));
        }

        void OnRefresh(object sender, EventArgs e)
        {
            var _formActive = new Event();
            var list = (ListView)sender;
            foreach (var item in list.ItemsSource)
            {
                _formActive = (Event)item;
                break;
            }
            BindingContext = new EventsList(_formActive.formType);

            //make sure to end the refresh state
            list.IsRefreshing = false;
        }
    }
}