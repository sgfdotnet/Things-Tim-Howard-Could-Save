using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tim.API.Models;

namespace Tim.API.Data
{
	public class ThingsRepository
	{
		public IEnumerable<Thing> GetThings()
		{
			yield return new Thing()
			{
				Id = 1,
				Title = "The Titanic",
				ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/titanic.jpg"),
				FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/titanic.jpg")
			};
			yield return new Thing()
			{
				Id = 2,
				Title = "Hurrican Arthur",
				ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/Arthur.jpg"),
				FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/Arthur.jpg")
			};
			yield return new Thing()
			{
				Id = 3,
				Title = "Mufasa",
				ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/mufasa.png"),
				FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/mufasa.png")
			};
			yield return new Thing()
			{
				Id = 4,
				Title = "The Dinosaurs",
				ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/dinosaurs.png"),
				FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/dinosaurs.png")
			};
			yield return new Thing()
			{
				Id = 5,
				Title = "Some important hockey goal",
				ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/hockey.jpg"),
				FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/hockey.jpg")
			};
			yield return new Thing()
			{
				Id = 6,
				Title = "Kanye West",
				ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/kanye-swift.jpg"),
				FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/kanye-swift.jpg")
			};
			yield return new Thing()
			{
				Id = 7,
				Title = "Suarez",
				ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/suarez.png"),
				FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/suarez.png")
			};
			yield return new Thing()
			{
				Id = 8,
				Title = "Birth Control",
				ThumbnailImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/thumbnails/birthcontrol.jpg"),
				FullImageUri = new Uri("https://thingstimhowardcouldsave.blob.core.windows.net/things/birthcontrol.jpg")
			};
		}
	}
}