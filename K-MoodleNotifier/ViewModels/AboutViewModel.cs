using K_MoodleNotifier.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace K_MoodleNotifier.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command OpenWebCommand { get; }
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(OnLoginClicked);
        }


        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
        }
    }
}