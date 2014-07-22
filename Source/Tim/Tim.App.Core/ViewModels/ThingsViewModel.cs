using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using Tim.App.Core.Models;
using Tim.App.Core.Services;

namespace Tim.App.Core.ViewModels
{
	public class ThingsViewModel : MvxViewModel
	{
		private readonly IThingsService service;

		public ThingsViewModel(IThingsService service)
		{
			this.service = service;
		}

		public override void Start()
		{
			this.LoadThingsCommand = new MvxCommand(async () => 
			{
				await LoadThings();
			});
			this.ShowSlidesCommand = new MvxCommand(() => 
			{
				this.ShowViewModel<SlideshowViewModel>();
			});
		}

		public ICommand LoadThingsCommand { get; private set; }
		public ICommand ShowSlidesCommand { get; private set; }

		public async Task LoadThings()
		{
			this.Things = await service.GetThings();
			Data.Cache.Things = this.Things;
		}
		
		#region Things

		private IEnumerable<Thing> things;
		public IEnumerable<Thing> Things
		{
			get { return things; }
			set { things = value; RaisePropertyChanged(() => Things); }
		}

		#endregion

		
		#region Test

		private string test = "This is a test";
		public string Test
		{
			get { return test; }
			set { test = value; RaisePropertyChanged(() => Test); }
		}

		#endregion

	}
}
