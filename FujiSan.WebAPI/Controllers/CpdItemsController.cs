using FujiSan.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.OData;

namespace FujiSan.WebAPI.Controllers
{
	[EnableCors("*", "*", "*")]
	public class CpdItemsController : ApiController
	{
		private readonly ICpdItemRepository _cpdItemsRepository;

		public CpdItemsController()
		{
			_cpdItemsRepository = new CpdItemRepositoryJson();
		}

		// GET: api/cpditems
		[EnableQuery(PageSize=20)]
		public IQueryable<CpdItem> Get()
		{
			return _cpdItemsRepository.All().AsQueryable();
		}
	
	}
}
