using System;
using iOSSimpleBinding;

using UIKit;
using System.Diagnostics;

namespace iOSSimpleSample
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.


			UIButton button = new UIButton ();

			View.AddSubview (button);


		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);


		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			PPScanner p = new PPScanner ();

			PPScannerViewController controller = p.Controller;

			controller.Update ();

			PPScannerDelegate pd = new MyDelegate ();

			p.SetDelegate (pd);

			p.Run ();

			PresentViewController (controller, true, null);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public class MyDelegate : PPScannerDelegate {

			public override void DidStart ()
			{
				Debug.WriteLine ("I am here DidStart");
			}


			#region implemented abstract members of PPScannerDelegate
			public override void DidFinish ()
			{
				Debug.WriteLine ("I am here DidFinish");
			}
			#endregion
		}

	}
}

