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
            Initializer();
            InitializeComponent();
        }

        public async void Initializer()
        {
            DayChecker();
            ParallelChecker();
            GeneralChecker();
        }
        
        
        
        public async void DayChecker()
        {
            var day11 = await SecureStorage.GetAsync("Day11");
            var day12 = await SecureStorage.GetAsync("Day12");
            var day13 = await SecureStorage.GetAsync("Day13");

            if (day11 == null)
            {
                await SecureStorage.SetAsync("Day11", "1");
            }
            if (day12 == null)
            {
                await SecureStorage.SetAsync("Day12", "0");
            }
            if (day13 == null)
            {
                await SecureStorage.SetAsync("Day13", "0");
            }


            var day21 = await SecureStorage.GetAsync("Day21");
            var day22 = await SecureStorage.GetAsync("Day22");
            var day23 = await SecureStorage.GetAsync("Day23");

            if (day21 == null)
            {
                await SecureStorage.SetAsync("Day21", "1");
            }
            if (day22 == null)
            {
                await SecureStorage.SetAsync("Day22", "0");
            }
            if (day23 == null)
            {
                await SecureStorage.SetAsync("Day23", "0");
            }


            var day31 = await SecureStorage.GetAsync("Day31");
            var day32 = await SecureStorage.GetAsync("Day32");
            var day33 = await SecureStorage.GetAsync("Day33");

            if (day31 == null)
            {
                await SecureStorage.SetAsync("Day31", "1");
            }
            if (day32 == null)
            {
                await SecureStorage.SetAsync("Day32", "0");
            }
            if (day33 == null)
            {
                await SecureStorage.SetAsync("Day33", "0");
            }


        }

        public async void ParallelChecker()
        {
            var daytime1 = await SecureStorage.GetAsync("DayTime1");
            var daytime2 = await SecureStorage.GetAsync("DayTime2");
            var daytime3 = await SecureStorage.GetAsync("DayTime3");

            if (daytime1 == null)
            {
                await SecureStorage.SetAsync("DayTime1", "0");
            }
            if (daytime2 == null)
            {
                await SecureStorage.SetAsync("DayTime2", "-1");
            }
            if (daytime3 == null)
            {
                await SecureStorage.SetAsync("DayTime3", "-1");
            }


        }
        
        
        public async void GeneralChecker()
        {
            var feature01 = await SecureStorage.GetAsync("Feature01");
            var feature02 = await SecureStorage.GetAsync("Feature02");

            if (feature01 == null)
            {
                await SecureStorage.SetAsync("Feature01", "0");
            }
            if (feature02 == null)
            {
                await SecureStorage.SetAsync("Feature02", "-1");
            }
            
        
        
    }


}
