using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace CrossPlatformSummit.MVVMCross.Droid.Views
{
    [Activity(Label = "View")]
	public class PalestranteView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			SetContentView(Resource.Layout.PalestranteView);
        }
    }
}