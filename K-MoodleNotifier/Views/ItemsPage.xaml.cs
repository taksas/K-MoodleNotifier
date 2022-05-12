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
        void LoginCommand(object sender, System.EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(NewItemPage));
        }
        async void checker()
        {

            var day11 = await SecureStorage.GetAsync("Day11");
            var day12 = await SecureStorage.GetAsync("Day12");
            var day13 = await SecureStorage.GetAsync("Day13");

            var day21 = await SecureStorage.GetAsync("Day21");
            var day22 = await SecureStorage.GetAsync("Day22");
            var day23 = await SecureStorage.GetAsync("Day23");

            var day31 = await SecureStorage.GetAsync("Day31");
            var day32 = await SecureStorage.GetAsync("Day32");
            var day33 = await SecureStorage.GetAsync("Day33");

            if (day11 == "1")
            {
                checkBox11.IsChecked = true;
            }
            if (day12 == "1")
            {
                checkBox12.IsChecked = true;
            }
            if (day13 == "1")
            {
                checkBox13.IsChecked = true;
            }

            if (day21 == "1")
            {
                checkBox21.IsChecked = true;
            }
            if (day22 == "1")
            {
                checkBox22.IsChecked = true;
            }
            if (day23 == "1")
            {
                checkBox23.IsChecked = true;
            }

            if (day31 == "1")
            {
                checkBox31.IsChecked = true;
            }
            if (day32 == "1")
            {
                checkBox32.IsChecked = true;
            }
            if (day33 == "1")
            {
                checkBox33.IsChecked = true;
            }
        }





        //1st Notify
        async void OnCheckBoxCheckedChanged11(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day11", "1");
                // var text1 =  await SecureStorage.GetAsync("Day1");
                // Debug.WriteLine(text1);
            }
            else
            {
                await SecureStorage.SetAsync("Day11", "0");
                // var text1 = await SecureStorage.GetAsync("Day1");
                // Debug.WriteLine(text1);
            }
            
        }
        async void OnCheckBoxCheckedChanged12(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day12", "1");
            }
            else
            {
                await SecureStorage.SetAsync("Day12", "0");
            }
        }
        async void OnCheckBoxCheckedChanged13(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day13", "1");
            }
            else
            {
                await SecureStorage.SetAsync("Day13", "0");
            }
        }


        private void MyPicker_SelectedIndexChanged1(object sender, EventArgs e)
        {
            var val = MyPicker1.Items[MyPicker1.SelectedIndex];
            DisplayAlert("選択アイテム", val, "OK");
        }















        //2nd Notify
        async void OnCheckBoxCheckedChanged21(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day21", "1");
                // var text1 =  await SecureStorage.GetAsync("Day1");
                // Debug.WriteLine(text1);
            }
            else
            {
                await SecureStorage.SetAsync("Day21", "0");
                // var text1 = await SecureStorage.GetAsync("Day1");
                // Debug.WriteLine(text1);
            }

        }
        async void OnCheckBoxCheckedChanged22(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day22", "1");
            }
            else
            {
                await SecureStorage.SetAsync("Day22", "0");
            }
        }
        async void OnCheckBoxCheckedChanged23(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day23", "1");
            }
            else
            {
                await SecureStorage.SetAsync("Day23", "0");
            }
        }


        private void MyPicker_SelectedIndexChanged2(object sender, EventArgs e)
        {
            var val = MyPicker2.Items[MyPicker2.SelectedIndex];
            DisplayAlert("選択アイテム", val, "OK");
        }














        //3rd Notify
        async void OnCheckBoxCheckedChanged31(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day31", "1");
                // var text1 =  await SecureStorage.GetAsync("Day1");
                // Debug.WriteLine(text1);
            }
            else
            {
                await SecureStorage.SetAsync("Day31", "0");
                // var text1 = await SecureStorage.GetAsync("Day1");
                // Debug.WriteLine(text1);
            }

        }
        async void OnCheckBoxCheckedChanged32(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day32", "1");
            }
            else
            {
                await SecureStorage.SetAsync("Day32", "0");
            }
        }
        async void OnCheckBoxCheckedChanged33(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                await SecureStorage.SetAsync("Day33", "1");
            }
            else
            {
                await SecureStorage.SetAsync("Day33", "0");
            }
        }


        private void MyPicker_SelectedIndexChanged3(object sender, EventArgs e)
        {
            var val = MyPicker3.Items[MyPicker3.SelectedIndex];
            DisplayAlert("選択アイテム", val, "OK");
        }

    }
}