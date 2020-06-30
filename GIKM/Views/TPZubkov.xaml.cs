using GIKM.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TPZubkov : TabbedPage
    {
        public TPZubkov()
        {
            InitializeComponent();
            BindingContext = new EventsList(AppConstants.ZUBK);
        }
    }
}