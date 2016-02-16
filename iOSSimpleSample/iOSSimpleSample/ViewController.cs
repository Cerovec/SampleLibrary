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

			PPScanner p = new PPScanner ();

			PPScannerController controller = p.Controller;

			PPScannerDelegate pd = new MyDelegate ();

			p.SetDelegate (pd);

			p.Run ();

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public class MyDelegate : PPScannerDelegate {

			public override void DidStart ()
			{
				Debug.WriteLine ("I am here");
			}


			#region implemented abstract members of PPScannerDelegate
			public override void DidFinish ()
			{
				throw new NotImplementedException ();
			}
			#endregion
		}

	}
}

