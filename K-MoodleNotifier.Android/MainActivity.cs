﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using AndroidX.Work;
using K_MoodleNotifier.Droid.Workers;

namespace K_MoodleNotifier.Droid
{
    [Activity(Label = "K_MoodleNotifier", Icon = "@drawable/icon_K", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());


            WorkManager manager = WorkManager.GetInstance(this);
            manager.CancelAllWork();

            PeriodicWorkRequest NotifyWorkRequest = PeriodicWorkRequest.Builder.From<NotifyWorker>(TimeSpan.FromMinutes(15)).Build();

            WorkManager.Instance.Enqueue(NotifyWorkRequest);


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}