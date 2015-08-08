using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace FujiSan.WebAPI.Models
{
	public class CpdItemRepositoryJson : ICpdItemRepository
	{
		private static readonly string _virtualFilePath = @"~/App_Data/cpditems.json";

		public IEnumerable<CpdItem> All()
		{
			var filePath = HostingEnvironment.MapPath(_virtualFilePath);

			var json = System.IO.File.ReadAllText(filePath);

			var cpdItems = JsonConvert.DeserializeObject<List<CpdItem>>(json);

			return cpdItems;
		}
	}
}