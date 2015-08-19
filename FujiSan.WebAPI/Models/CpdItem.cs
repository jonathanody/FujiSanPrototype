using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FujiSan.WebAPI.Models
{
	public class CpdItem
	{
		public Guid Id { get; set; }
		public string Publisher { get; set; }
		public string Name { get; set; }
		public string LinkUrl { get; set; }
		public string Type { get; set; }
		public List<string> Tags { get; set; }
		public List<string> Authors { get; set; }
		public List<DateTime> Sessions { get; set; }

		public string SessionRangeText
		{
			get
			{
				if (Sessions == null || Sessions.Count == 0)
					return "No sessions recorded";
				else if (Sessions.Count == 1)
					return Sessions.ElementAt(0).ToShortDateString();
				else
				{
					var orderedSesions = Sessions.OrderBy(s => s).ToList();
					return string.Format("{0} - {1}", orderedSesions.ElementAt(0).ToShortDateString(),
						orderedSesions.ElementAt(Sessions.Count - 1).ToShortDateString());
				}
			}
		}
	}
}