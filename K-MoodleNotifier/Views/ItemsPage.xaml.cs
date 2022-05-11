using K_MoodleNotifier.Models;
using K_MoodleNotifier.ViewModels;
using K_MoodleNotifier.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace K_MoodleNotifier.Views
{
    public partial class ItemsPage : ContentPage
    {


        public ItemsPage()
        {
            
            InitializeComponent();
            checker();
        }

        async void checker()
        {

            var day1 = await SecureStorage.GetAsync("Day1");
            var day2 = await SecureStorage.GetAsync("Day2");
            var day3 = await SecureStorage.GetAsync("Day3");

            if (day1 == "1")
            {
                checkBox1.IsChecked = true;
            }
            if (day2 == "1")
            {
                checkBox2.IsChecked = true;
            }
            if (day3 == "1")
            {
                checkBox3.IsChecked = true;
            }
        }
        void LoginCommand(object sender, System.EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnCheckBoxCheckedChanged1(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day1", "1");
                // var text1 =  await SecureStorage.GetAsync("Day1");
                // Debug.WriteLine(text1);
            }
            else
            {
                await SecureStorage.SetAsync("Day1", "0");
                // var text1 = await SecureStorage.GetAsync("Day1");
                // Debug.WriteLine(text1);
            }
            
        }
        async void OnCheckBoxCheckedChanged2(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day2", "1");
            }
            else
            {
                await SecureStorage.SetAsync("Day2", "0");
            }
        }
        async void OnCheckBoxCheckedChanged3(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day3", "1");
            }
            else
            {
                await SecureStorage.SetAsync("Day3", "0");
            }
        }
    }
}