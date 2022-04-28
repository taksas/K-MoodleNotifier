using K_MoodleNotifier.ViewModels;
using K_MoodleNotifier.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace K_MoodleNotifier
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
