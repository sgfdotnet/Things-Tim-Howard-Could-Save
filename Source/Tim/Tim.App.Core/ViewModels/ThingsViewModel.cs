using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.ViewModels;
using Tim.App.Core.Models;

namespace Tim.App.Core.ViewModels
{
	public class ThingsViewModel : MvxViewModel
	{
		public override void Start()
		{

		}

		
		#region Things

		private IEnumerable<Thing> things;
		public IEnumerable<Thing> Things
		{
			get { return things; }
			set { things = value; RaisePropertyChanged(() => Things); }
		}

		#endregion


	}
}
