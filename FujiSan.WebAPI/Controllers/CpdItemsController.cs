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

		public CpdItemsController(ICpdItemRepository cpdItemRepository)
		{
			_cpdItemsRepository = cpdItemRepository;
		}

		// GET: api/cpditems
		[EnableQuery(PageSize=50)]
		public IQueryable<CpdItem> Get()
		{
			var cpdItems = _cpdItemsRepository.All().AsQueryable();

			return cpdItems;
		}
	
	}
}
