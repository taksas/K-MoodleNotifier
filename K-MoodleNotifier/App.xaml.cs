using K_MoodleNotifier.Services;
using K_MoodleNotifier.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace K_MoodleNotifier
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
