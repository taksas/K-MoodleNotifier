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
        int checker = 0;

        public WebViewPage()
        {
            InitializeComponent();
            checker = 5;
            webView.Source = "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=upcoming";
            var id = SecureStorage.GetAsync("text");
            var password = SecureStorage.GetAsync("desc");


        }

        void Refresh(object sender, System.EventArgs e)
        {
            checker = 1;
            webView.Reload();
            
        }

        void Tsukibetsu(object sender, System.EventArgs e)
        {
            checker = 1;
            webView.Source = "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=month";
        }
        void Nichibetsu(object sender, System.EventArgs e)
        {
            checker = 1;
            webView.Source = "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=day";
        }
        void Tyokkin(object sender, System.EventArgs e)
        {
            checker = 1;
            webView.Source = "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=upcoming";
        }


        
        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            labelLoading.IsVisible = true;
            String uri = e.Url;
            if (checker <= 0) { labelLoading.IsVisible = false; labelStopped.IsVisible = true; e.Cancel = true;}
            if (uri == "https://kadai-moodle.kagawa-u.ac.jp/login/index.php") { labelLoading.IsVisible = false; labelLoggedIn.IsVisible = true; }
     /*/          else if (uri != "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=month" &&
                        uri != "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=day" &&
                        uri != "https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=upcoming" &&
                        uri != "https://kadai-moodle.kagawa-u.ac.jp/" ) { e.Cancel = true; }
            /*/
            checker--;
        }
    

        async void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            var id = await SecureStorage.GetAsync("text");
            var password = await SecureStorage.GetAsync("desc");


            await webView.EvaluateJavaScriptAsync($"document.querySelector('#username').value = '" + id + "' ;");
            await webView.EvaluateJavaScriptAsync($"document.querySelector('#password').value = '" + password + "' ;");
            await webView.EvaluateJavaScriptAsync($"document.querySelector('#loginbtn').click();");
            labelLoading.IsVisible = false;
            labelLoggedIn.IsVisible = false;
            labelStopped.IsVisible = false;

            switch (e.Result) {
                case WebNavigationResult.Cancel:
                case WebNavigationResult.Failure:
                case WebNavigationResult.Timeout: checker = 0; Debug.WriteLine("checker resetted!!"); break;
                default:  break;
            }
        }
        
    }
}