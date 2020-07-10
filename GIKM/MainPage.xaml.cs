using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using GIKM.Views;

namespace GIKM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // 2 seconds delay and redirect to menu page
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(2000);
            await this.Navigation.PushAsync(new MenuPage());
        }
    }
}
