using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tim.App.Core.Models;

namespace Tim.App.Core.ViewModels.Design
{
	public class ThingsDesignableViewModel : ThingsViewModel
	{
		public ThingsDesignableViewModel() : base(null)
		{
			List<Thing> things = new List<Thing>();
			things.Add(new Thing()
				{
					Id = 1,
					Title = "The Titanic",
					ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/titanic.jpg"),
					FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/titanic.jpg")
				});
			things.Add(new Thing()
			{
				Id = 2,
				Title = "Hurrican Arthur",
				ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/Arthur.jpg"),
				FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/Arthur.jpg")
			});

			this.Things = things;
		}
	}
}
