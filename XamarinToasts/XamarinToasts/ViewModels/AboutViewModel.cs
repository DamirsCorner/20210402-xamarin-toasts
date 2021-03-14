using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinToasts.Views;

namespace XamarinToasts.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            OpenToastCommand = new Command(async () => await ToastPage.Show("Operation succeeded!"));
        }

        public ICommand OpenWebCommand { get; }

        public ICommand OpenToastCommand { get; }
    }
}