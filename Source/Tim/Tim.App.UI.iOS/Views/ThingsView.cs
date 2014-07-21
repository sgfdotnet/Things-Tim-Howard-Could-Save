using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Tim.App.Core.ViewModels;
using System.Linq;
using Tim.App.Core.Models;

namespace Tim.App.UI.iOS
{
	public partial class ThingsView : MvxViewController
	{
		public ThingsViewModel ThingsViewModel { get; set; }

		public ThingsView () : base("ThingsView", null)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override async void ViewDidLoad()
		{
			base.ViewDidLoad();

			this.ThingsViewModel = (ThingsViewModel)this.ViewModel;

			this.ThingsList.RegisterNibForCell(UINib.FromName("ThingsCollectionViewCell", NSBundle.MainBundle), ThingsCollectionViewCell.Key);
			var thingSource = new MvxCollectionViewSource(this.ThingsList, ThingsCollectionViewCell.Key);
			this.ThingsList.Source = thingSource;
			//this.ThingsList.Delegate = new 

			await this.ThingsViewModel.LoadThings();

			// Perform any additional setup after loading the view, typically from a nib.
			var set = this.CreateBindingSet<ThingsView, Core.ViewModels.ThingsViewModel>();
			set.Bind(thingSource).To(vm => vm.Things);
			set.Apply();
		}
	}

	public class ThingsListDelegate : UICollectionViewDelegate
	{
		private ThingsView thingsView;

		public ThingsListDelegate (ThingsView thingsView)
		{
			this.thingsView = thingsView;
		}

		public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
		{
			// NOTE: Don't call the base implementation on a Model class
			// see http://docs.xamarin.com/guides/ios/application_fundamentals/delegates,_protocols,_and_events

			Thing thing = this.thingsView.ThingsViewModel.Things.ToList()[0];

		}
	}
}

