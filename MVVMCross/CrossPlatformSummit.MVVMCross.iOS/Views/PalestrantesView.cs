using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using CrossPlatformSummit.Core.ViewModels;

namespace CrossPlatformSummit.MVVMCross.iOS.Views
{
	[Register("PalestrantesView")]
	public class PalestrantesView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView { BackgroundColor = UIColor.Red };
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
            {
               EdgesForExtendedLayout = UIRectEdge.None;
            }
			   
			var button = new UIButton(new CGRect(10, 50, 300, 40));
			button.SetTitle ("Carregar", UIControlState.Normal);
			Add(button);

			var set = this.CreateBindingSet<PalestrantesView, PalestrantesViewModel>();
			set.Bind(button).To(vm => vm.CarregarCommand);
            set.Apply();
        }
    }
}