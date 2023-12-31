﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        async void OnMenuTap1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TPGikm());
        }

        async void OnMenuTap2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TPZubkov());
        }
        async void OnMenuTap3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TPExhall());
        }
        async void OnMenuTap4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TPKorolenko());

        }

    }
}