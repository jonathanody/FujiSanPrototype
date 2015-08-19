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
		public IEnumerable<CpdItemViewModel> Get()
		{
			var cpdItems = _cpdItemsRepository.All();

			var cpdItemViewModels = ModelFactory.Create(cpdItems);

			return cpdItemViewModels;
		}
	
	}
}
