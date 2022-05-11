using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using AndroidX.Work;
using K_MoodleNotifier.Droid.Workers;
using Android.Content;

namespace K_MoodleNotifier.Droid
{
    [Activity(Label = "Moodleカレンダー通知", Icon = "@drawable/icon_K", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            DozeIgnoring();

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

        public void DozeIgnoring()
        {
            //Android6 Marshmallow以降
            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                PowerManager pm = (PowerManager)this.GetSystemService(Context.PowerService);
                string packageName = this.PackageManager.GetPackageInfo(this.PackageName, 0).PackageName;
                if (!pm.IsIgnoringBatteryOptimizations(packageName))
                {
                    //Dozeホワイトリストに追加する許可を求める
                    Intent intent = new Intent(Android.Provider.Settings.ActionRequestIgnoreBatteryOptimizations);
                    intent.SetData(Android.Net.Uri.Parse("package:" + packageName));
                    this.StartActivity(intent);
                }
            }
        }
    }
}