using System.ComponentModel;
using Xamarin.Forms;
using XamarinToasts.ViewModels;

namespace XamarinToasts.Views
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