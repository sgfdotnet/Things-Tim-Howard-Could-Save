using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tim.App.Core.Models;

namespace Tim.App.Core.Data
{
	class Cache
	{
		public static IEnumerable<Thing> Things { get; set; }
	}
}
