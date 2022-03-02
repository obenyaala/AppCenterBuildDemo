using AppCenterApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppCenterApp.Views
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