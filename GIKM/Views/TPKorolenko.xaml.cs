using GIKM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TPKorolenko : TabbedPage
    {
        public TPKorolenko()
        {
            InitializeComponent();
            BindingContext = new EventsList(AppResource.ResourceManager.GetString("DOMK"));
        }
    }
}