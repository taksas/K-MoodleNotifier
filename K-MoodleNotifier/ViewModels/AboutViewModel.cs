using K_MoodleNotifier.Views;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.Generic;
using AngleSharp;
using System.Diagnostics;
using AngleSharp.Html.Dom;
using K_MoodleNotifier.Interfaces;
using Prism.Commands;
using Prism.Navigation;


namespace K_MoodleNotifier.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        public readonly ILocalNotificationsService localNotificationsService;
        public ICommand ShowNotificationCommand { get; private set; }

        public Command OpenWebCommand { get; }
        public Command StartWebCommand { get; }



        public Command Refreshing { get; }



        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(OnLoginClicked);
            StartWebCommand = new Command(button1_Click);


            Refreshing = new Command(OnRefreshing);



            localNotificationsService = DependencyService.Get<ILocalNotificationsService>();
            ShowNotificationCommand = new DelegateCommand(ShowNotification);

        }


        private void ShowNotification()
        {
            localNotificationsService.ShowNotification("Local Notification", "This a local notification", new Dictionary<string, string>());
        }




        private async void OnRefreshing(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
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