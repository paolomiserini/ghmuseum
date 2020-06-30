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
    public partial class PUpPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public PUpPage(string _office)
        {
            InitializeComponent();
            // Inizializzo conle label corrette
            setText(_office);
        }

        private void setText(string _officetype)
        {
            switch (_officetype)
            {
                case AppConstants.GIKM:
                    this.WorkingTime.Text = "Время работы с 9.00 до 22.00 часов";
                    this.Telephone.Text = "Телефон для справок: 8(86141)2136";
                    this.Escursion.Text = "Посещение и экскурсии по предварительной записи по телефону 8(928)4004718";
                    break;
                case AppConstants.ZUBK:
                    this.WorkingTime.Text = "ежедневно: с 9.00 до 18.00";
                    this.Telephone.Text = "Телефон для справок: +7 (928)239-42-28";
                    this.Escursion.Text = "";
                    break;
                    break;
                case AppConstants.CEHA:
                    this.WorkingTime.Text = "Время работы вт-вс . с 11.00 до 20.00 - чт. с 11.00 до 21.00";
                    this.Telephone.Text = "Телефон для справок:  (86141) 3-32-98, (918)668-74-02";
                    this.Escursion.Text = "";
                    break;
                case AppConstants.DOMK:
                    this.WorkingTime.Text = "ежедневно: с 9.00 до 18.00 (касса до 17.15)";
                    this.Telephone.Text = "Телефон для справок: +7 (928)4004717";
                    this.Escursion.Text = "";
                    break;
                default:
                    break;
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        // ### Methods for supporting animations in your popup page ###

        // Invoked before an animation appearing
        protected override void OnAppearingAnimationBegin()
        {
            base.OnAppearingAnimationBegin();
        }

        // Invoked after an animation appearing
        protected override void OnAppearingAnimationEnd()
        {
            base.OnAppearingAnimationEnd();
        }

        // Invoked before an animation disappearing
        protected override void OnDisappearingAnimationBegin()
        {
            base.OnDisappearingAnimationBegin();
        }

        // Invoked after an animation disappearing
        protected override void OnDisappearingAnimationEnd()
        {
            base.OnDisappearingAnimationEnd();
        }

        protected override Task OnAppearingAnimationBeginAsync()
        {
            return base.OnAppearingAnimationBeginAsync();
        }

        protected override Task OnAppearingAnimationEndAsync()
        {
            return base.OnAppearingAnimationEndAsync();
        }

        protected override Task OnDisappearingAnimationBeginAsync()
        {
            return base.OnDisappearingAnimationBeginAsync();
        }

        protected override Task OnDisappearingAnimationEndAsync()
        {
            return base.OnDisappearingAnimationEndAsync();
        }

        // ### Overrided methods which can prevent closing a popup page ###

        // Invoked when a hardware back button is pressed
        protected override bool OnBackButtonPressed()
        {
            // Return true if you don't want to close this popup page when a back button is pressed
            return base.OnBackButtonPressed();
        }

        // Invoked when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Return false if you don't want to close this popup page when a background of the popup page is clicked
            return base.OnBackgroundClicked();
        }
    }
}