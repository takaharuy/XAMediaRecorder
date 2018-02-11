using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace XAMediaRecorder
{
    [Activity(Label = "@string/app_name", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.sample_main);
        }

        [Java.Interop.Export("onCaptureClick")]
        public void OnCaptureClick(View view)
        {

        }
    }
}