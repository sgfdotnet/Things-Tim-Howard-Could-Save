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
	[Register ("ThingsCollectionViewCell")]
	partial class ThingsCollectionViewCell
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView Thumbnail { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Thumbnail != null) {
				Thumbnail.Dispose ();
				Thumbnail = null;
			}

			if (TitleLabel != null) {
				TitleLabel.Dispose ();
				TitleLabel = null;
			}
		}
	}
}
