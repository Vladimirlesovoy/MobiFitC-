using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace MobiFit.Droid
{
    [Activity(Label = "MobiFit", Icon = "@mipmap/MobiFit", 

        Theme = "@style/MainTheme", MainLauncher = true, 
    
       ConfigurationChanges = ConfigChanges.ScreenSize 

    | ConfigChanges.Orientation | ConfigChanges.UiMode 
        
    | ConfigChanges.ScreenLayout 
        
    | ConfigChanges.SmallestScreenSize, 
    ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    
    
    
    
    
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            this.Window.AddFlags(Android.Views.WindowManagerFlags.Fullscreen);



        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}