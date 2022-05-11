//using K_MoodleNotifier.ViewModels;

using Xamarin.Forms;
using K_MoodleNotifier.ViewModels;
using System.Collections.ObjectModel;
using K_MoodleNotifier.Models;
using System.Threading.Tasks;
using System;
using System.Linq;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using Xamarin.Essentials;

namespace K_MoodleNotifier.Views
{

    public partial class AboutPage : ContentPage
    {

        public AboutPage()
        {

            DayChecker();
            InitializeComponent();
        }

        public async void DayChecker()
        {
            var day1 = await SecureStorage.GetAsync("Day1");
            var day2 = await SecureStorage.GetAsync("Day2");
            var day3 = await SecureStorage.GetAsync("Day3");

            if (day1 == null)
            {
                await SecureStorage.SetAsync("Day1", "1");
            }
            if (day2 == null)
            {
                await SecureStorage.SetAsync("Day2", "0");
            }
            if (day3 == null)
            {
                await SecureStorage.SetAsync("Day3", "0");
            }
        }
    }


}