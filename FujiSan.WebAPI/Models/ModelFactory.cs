using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FujiSan.WebAPI.Models
{
	public static class ModelFactory
	{
		public static IEnumerable<CpdItemViewModel> Create(IEnumerable<CpdItem> cpdItems)
		{
			IEnumerable<CpdItemViewModel> cpdItemViewModels = cpdItems.Select(x =>
				new CpdItemViewModel()
				{
					Id = x.Id,
					Publisher = x.Publisher,
					Name = x.Name,
					LinkUrl = x.LinkUrl,
					Type = x.Type,
					Tags = x.Tags,
					Authors = x.Authors,
					Sessions = x.Sessions,
					SessionRangeText = x.SessionRangeText
				}
			).ToList();

			return cpdItemViewModels;
		}
	}
}