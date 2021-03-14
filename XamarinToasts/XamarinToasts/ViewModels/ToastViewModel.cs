using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinToasts.ViewModels
{
    public class ToastViewModel : BaseViewModel
    {
        private string message;

        public ToastViewModel(string message)
        {
            Message = message;
        }

        public string Message
        {
            get => message;
            private set => SetProperty(ref message, value);
        }
    }
}
