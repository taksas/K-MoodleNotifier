using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace K_MoodleNotifier.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class WebViewPage : ContentPage
{
    public WebViewPage()
    {
            InitializeComponent();
            webView.Source = "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=upcoming";
    }
        
        void Refresh(object sender, System.EventArgs e)
        {
            webView.Reload();
        }

        void Tsukibetsu(object sender, System.EventArgs e)
        {
            webView.Source = "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=month";
        }
        void Nichibetsu(object sender, System.EventArgs e)
        {
            webView.Source = "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=day";
        }
        void Tyokkin(object sender, System.EventArgs e)
        {
            webView.Source = "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=upcoming";
        }


        
        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            labelLoading.IsVisible = true;
        }

        void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            labelLoading.IsVisible = false;
        }
        
    }
}