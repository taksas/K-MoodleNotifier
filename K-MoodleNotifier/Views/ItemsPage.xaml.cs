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
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace K_MoodleNotifier.Views
{
    public partial class ItemsPage : ContentPage
    {


        public ItemsPage()
        {
            InitializeComponent();
            
        }


        void LoginCommand(object sender, System.EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(NewItemPage));
        }
    }
}