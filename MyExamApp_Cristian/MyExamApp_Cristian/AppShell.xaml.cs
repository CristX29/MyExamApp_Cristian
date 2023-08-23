using MyExamApp_Cristian.ViewModels;
using MyExamApp_Cristian.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyExamApp_Cristian
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
