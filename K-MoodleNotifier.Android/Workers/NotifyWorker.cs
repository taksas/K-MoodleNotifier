using Android.App;
using Android.Content;
using Android.OS;
using System.Collections.Generic;
using AndroidX.Work;
using Xamarin.Essentials;
using AngleSharp;
using Configuration = AngleSharp.Configuration;
using AngleSharp.Html.Dom;
using Android.Graphics;
using AndroidX.Core.App;
using AndroidApp = Android.App.Application;
using System;
using System.Threading;

namespace K_MoodleNotifier.Droid.Workers
{
    internal class NotifyWorker : Worker
    {
        private const string CHANNEL_ID = "local_notifications_channel";
        private const string CHANNEL_NAME = "Notifications";
        private const string CHANNEL_DESCRIPTION = "Local and push notifications messages appear in this channel";

        private int notificationId = -1;
        private const string TITLE_KEY = "title";
        private const string MESSAGE_KEY = "message";

        private bool isChannelInitialized = false;
        public NotifyWorker(Context context, WorkerParameters workerParameters) : base(context, workerParameters)
        {

        }
        public override Result DoWork()
        {
            if ( DateTime.Now.Hour == 0 )
            {
                WorkerStart();
            }
            
            Android.Util.Log.Debug("CalculatorWorker", $"Your T");
            return Result.InvokeSuccess();
        }

        public async void WorkerStart()
        {
            var day1 = await SecureStorage.GetAsync("Day1");
            var day2 = await SecureStorage.GetAsync("Day2");
            var day3 = await SecureStorage.GetAsync("Day3");

            if (day1 == "1")
            {
                Day1();
                Thread.Sleep(10000);
            }
            if (day2 == "1")
            {
                Day2();
                Thread.Sleep(10000);
            }
            if (day3 == "1")
            {
                Day3();
            }
        }


        public async void Day1()
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
                // var classpList1 = document.GetElementsByClassName("dimmed_text");
                var classpList1 = document.QuerySelectorAll("div[class^='col-11']");
                //var classpList2 = document.QuerySelectorAll("div[href^='https://kadai-moodle.kagawa-u.ac.jp/course/view.php?id=']");

                /*   foreach (var c in classpList)
                   {
                       Debug.WriteLine(c.TextContent);
                   }

                   foreach (var c1 in classpList1)
                   {
                       Debug.WriteLine(c1.TextContent.Replace("本日, ", ""));
                   }
   */
                for (var i = 0; i < classpList.Length; i++)
                {
                    var c = classpList[i];
                    var c1 = classpList1[i * 3];
                    var c2 = classpList1[i * 3 + 2];
                    //                Debug.WriteLine($"{c.TextContent} : {c1.TextContent.Replace("本日, ", "")}");
                    ShowNotification(c.TextContent, $"{c2.TextContent} \n {c1.TextContent.Replace("本日, ", "")}", new Dictionary<string, string>());
                }

            }


            catch (System.Exception)
            {
                throw;
            }
        }
            //Debug.WriteLine(result);//マイページのHTMLが取得されている}
            public async void Day2()
        { }
        public async void Day3()
        { }





























            private void CreateNotificationChannel()
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
            {
                return;
            }

            var channel = new NotificationChannel(CHANNEL_ID, CHANNEL_NAME, NotificationImportance.Default)
            {
                Description = CHANNEL_DESCRIPTION
            };

            var notificationManager = (NotificationManager)AndroidApp.Context.GetSystemService(AndroidApp.NotificationService);
            notificationManager.CreateNotificationChannel(channel);
        }

        public void ShowNotification(string title, string message, IDictionary<string, string> data)
        {
            if (!isChannelInitialized)
            {
                CreateNotificationChannel();
            }

            var intent = new Intent(AndroidApp.Context, typeof(MainActivity));
            intent.PutExtra(TITLE_KEY, title);
            intent.PutExtra(MESSAGE_KEY, message);
            intent.AddFlags(ActivityFlags.ClearTop);
            foreach (var key in data.Keys)
            {
                intent.PutExtra(key, data[key]);
            }

            notificationId++;

            var pendingIntent = PendingIntent.GetActivity(AndroidApp.Context, notificationId, intent, PendingIntentFlags.OneShot);
            var notificationBuilder = new NotificationCompat.Builder(AndroidApp.Context, CHANNEL_ID)
                                            .SetLargeIcon(BitmapFactory.DecodeResource(AndroidApp.Context.Resources, Resource.Mipmap.icon))
                                            .SetSmallIcon(Resource.Drawable.icon_K)
                                            .SetContentTitle(title)
                                            .SetContentText(message)
                                            .SetAutoCancel(true)
                                            .SetContentIntent(pendingIntent)
                                            .SetDefaults((int)NotificationDefaults.Sound | (int)NotificationDefaults.Vibrate);

            var notificationManager = NotificationManagerCompat.From(AndroidApp.Context);
            notificationManager.Notify(notificationId, notificationBuilder.Build());
        }
    }

   
}