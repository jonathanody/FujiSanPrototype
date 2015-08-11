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
	}
}