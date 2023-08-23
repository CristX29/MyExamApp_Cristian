using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyExamApp_Cristian.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaBienvenida : ContentPage
    {
        public VistaBienvenida()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Options());
        }

        private async void BtnPregunta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AskView());
        }
    }
}