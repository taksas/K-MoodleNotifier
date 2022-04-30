using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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

        private async void Refresh(object sender, System.EventArgs e)
        {
            var id = await SecureStorage.GetAsync("text");
            var password = await SecureStorage.GetAsync("desc");
            Debug.Write(id);
            Debug.Write(password);
            await webView.EvaluateJavaScriptAsync($"document.querySelector('#username').value = id;");

            await webView.EvaluateJavaScriptAsync($"document.querySelector('#password').value = password;");

            await webView.EvaluateJavaScriptAsync($"document.querySelector('#loginbtn').click();");
            //   webView.Reload();
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