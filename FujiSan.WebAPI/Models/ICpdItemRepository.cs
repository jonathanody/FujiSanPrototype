using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FujiSan.WebAPI.Models
{
	public interface ICpdItemRepository
	{
		IEnumerable<CpdItem> All();
	}
}