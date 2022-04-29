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
            webView.Source = "http://xamarin.com";
    }

        void Refresh(object sender, System.EventArgs e)
        {
            webView.Reload();
        }
    }
}