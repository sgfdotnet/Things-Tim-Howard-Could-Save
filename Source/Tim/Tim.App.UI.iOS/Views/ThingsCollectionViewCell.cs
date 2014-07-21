using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Tim.App.Core.Models;

namespace Tim.App.UI.iOS
{
	public partial class ThingsCollectionViewCell : MvxCollectionViewCell
	{
		public static readonly UINib Nib = UINib.FromName("ThingsCollectionViewCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString("ThingsCollectionViewCell");

		public ThingsCollectionViewCell (IntPtr handle) : base(handle)
		{
			this.DelayBind(() => {
				var set = this.CreateBindingSet<ThingsCollectionViewCell, Thing>();
				set.Bind(TitleLabel).To(t => t.Title);
				set.Bind(this.Thumbnail).To(t => t.ThumbnailImageUri).WithConversion(new FileUriToImageConverter(), null);
				set.Apply();
			});
		}

		public static ThingsCollectionViewCell Create()
		{
			return (ThingsCollectionViewCell)Nib.Instantiate(null, null)[0];
		}
	}
}

