using MyExamApp_Cristian.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyExamApp_Cristian.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}