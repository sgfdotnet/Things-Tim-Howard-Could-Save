// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Tim.App.UI.iOS
{
	[Register ("ThingsView")]
	partial class ThingsView
	{
		[Outlet]
		MonoTouch.UIKit.UILabel TestLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UICollectionView ThingsList { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ThingsList != null) {
				ThingsList.Dispose ();
				ThingsList = null;
			}

			if (TestLabel != null) {
				TestLabel.Dispose ();
				TestLabel = null;
			}
		}
	}
}
