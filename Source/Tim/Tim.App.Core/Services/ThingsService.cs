using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tim.App.Core.Models;
using Flurl;
using Flurl.Http;

namespace Tim.App.Core.Services
{
	class ThingsService : IThingsService
	{
		private readonly string apiBaseUrl = "http://thingstimhowardcouldsave.azurewebsites.net/api/";

		public async Task<IEnumerable<Thing>> GetThings()
		{
			return await this.apiBaseUrl.AppendPathSegment("things")
				.GetJsonAsync<IEnumerable<Thing>>();
		}
	}
}
