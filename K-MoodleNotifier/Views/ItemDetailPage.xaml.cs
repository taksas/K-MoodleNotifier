using K_MoodleNotifier.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace K_MoodleNotifier.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}