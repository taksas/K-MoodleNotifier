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
        OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
    }

    public ICommand OpenWebCommand { get; }
}
}
