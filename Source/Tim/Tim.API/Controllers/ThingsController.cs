using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tim.API.Data;
using Tim.API.Models;

namespace Tim.API.Controllers
{
    public class ThingsController : ApiController
    {
		public IEnumerable<Thing> Get()
		{
			return new ThingsRepository().GetThings();
		}
    }
}
