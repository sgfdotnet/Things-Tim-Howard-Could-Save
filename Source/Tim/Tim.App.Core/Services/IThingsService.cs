using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tim.App.Core.Models;

namespace Tim.App.Core.Services
{
	interface IThingsService
	{
		Task<IEnumerable<Thing>> GetThings();
	}
}
