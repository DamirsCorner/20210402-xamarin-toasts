using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using XamarinToasts.ViewModels;

namespace XamarinToasts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToastPage : PopupPage
    {
        public ToastPage(string message)
        {
            InitializeComponent();

            BindingContext = new ToastViewModel(message);
        }

        public static async Task Show(string message, int millisecondsDuration = 2000)
        {
            await PopupNavigation.Instance.PushAsync(new ToastPage(message));

            _ = Task.Delay(millisecondsDuration)
                .ContinueWith(async _ => await PopupNavigation.Instance.PopAsync());
        }
    }
}