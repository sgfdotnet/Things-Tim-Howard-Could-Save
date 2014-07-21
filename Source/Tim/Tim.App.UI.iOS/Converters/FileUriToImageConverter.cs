using System;
using Cirrious.CrossCore.Converters;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Tim.App.UI.iOS
{
	public class FileUriToImageConverter : MvxValueConverter<Uri, UIImage>
	{
		protected override UIImage Convert(Uri value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value == null)
				return null;

			using (var url = new NSUrl (value.ToString()))
			using (var data = NSData.FromUrl(url))
			{
				return UIImage.LoadFromData(data);
			}
		}
	}
}

