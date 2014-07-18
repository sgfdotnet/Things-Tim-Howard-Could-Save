﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tim.API.Models
{
	public class Thing
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public Uri ThumbnailImageUri { get; set; }
		public Uri FullImageUri { get; set; }
	}
}