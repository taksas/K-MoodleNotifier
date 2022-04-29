using K_MoodleNotifier.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AngleSharp;
using System.Collections;
using System.IO;
using System.Text;
using System.Diagnostics;
using AngleSharp.Html.Dom;
using AngleSharp.Dom;
using AngleSharp.Scripting;
using K_MoodleNotifier.Models;
using System.Collections.ObjectModel;


namespace K_MoodleNotifier.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {


        public Command OpenWebCommand { get; }
        public Command StartWebCommand { get; }






        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(OnLoginClicked);
            StartWebCommand = new Command(button1_Click);




        }












        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
        }

        private async void button1_Click(object obj)
        {




            var id = await SecureStorage.GetAsync("text");
            var password = await SecureStorage.GetAsync("desc");


            //Cookieを有効化?
            var config = Configuration.Default.WithDefaultLoader().WithDefaultCookies(); // WithDefaultCookies()を追加
            var context = BrowsingContext.New(config);
            //URLを取得
            await context.OpenAsync("https://kadai-moodle.kagawa-u.ac.jp/calendar/view.php?view=day");


            //submit
            var document = await context.Active.Forms[0].SubmitAsync(new
            {
                username = await SecureStorage.GetAsync("text"),
                password = await SecureStorage.GetAsync("desc")
            });


            try
            {
                var classpList = document.GetElementsByClassName("name d-inline-block");
                var classpList2 = document.GetElementsByClassName("dimmed_text");
                foreach (var c in classpList)
                {
                    Debug.WriteLine(c.TextContent);
                }
                foreach (var c1 in classpList2)
                {
                    Debug.WriteLine(c1.TextContent.Replace("本日, ", ""));
                }





            }
            catch (System.Exception)
            {
                throw;
            }

            //Debug.WriteLine(result);//マイページのHTMLが取得されている
        }





    }
}