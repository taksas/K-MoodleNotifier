using K_MoodleNotifier.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using Xamarin.Essentials;


namespace K_MoodleNotifier.ViewModels
{
    public class LoginViewModel : BaseViewModel
    { 
        public LoginViewModel()
    {
        Title = "About";
        OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/taksas/K-MoodleNotifier/blob/master/LICENCE"));
        OpenWebCommand2 = new Command(async () => await Browser.OpenAsync("https://docs.microsoft.com/ja-jp/xamarin/essentials/secure-storage?tabs=android"));
    }

    public ICommand OpenWebCommand { get; }
        public Command OpenWebCommand2 { get; }
    }

}

