﻿using GIKM.ViewModels;
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
    public partial class TPExhall : TabbedPage
    {
        public TPExhall()
        {
            InitializeComponent();
            BindingContext = new EventsList(AppConstants.CEHA);
        }
    }
}