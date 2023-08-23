using MyExamApp_Cristian.Services;
using MyExamApp_Cristian.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyExamApp_Cristian
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new VistaBienvenida());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
