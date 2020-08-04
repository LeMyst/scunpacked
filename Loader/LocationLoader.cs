using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Loader
{
	public class LocationLoader
	{
		public string DataRoot { get; set; }

		LocalisationService localisationService;

		public LocationLoader(LocalisationService localisationService)
		{
			this.localisationService = localisationService;
		}

		public List<LocationIndexEntry> Load()
		{
			//Console.WriteLine(JsonConvert.SerializeObject(Directory.GetDirectories(Path.Combine(DataRoot, @"Data\Libs\Foundry\Records\starmap\pu"))));

			var index = new List<LocationIndexEntry>();
			index.AddRange(Load(@"Data\Libs\Subsumption\Platforms\PU\System\Stanton"));

			return index;
		}

		List<LocationIndexEntry> Load(string entityFolder)
		{
			var index = new List<LocationIndexEntry>();

			foreach (var entityFilename in Directory.EnumerateFiles(Path.Combine(DataRoot, entityFolder), "*.xml", SearchOption.AllDirectories))
			{
				Console.WriteLine(entityFilename);

				var parser = new StarmapParser();
				var entity = parser.Parse(entityFilename);
				if (entity == null) continue;

				var indexEntry = new LocationIndexEntry
				{
					name = localisationService.GetText(entity.name),
					description = localisationService.GetText(entity.description),
					callout1 = localisationService.GetText(entity.callout1),
					callout2 = localisationService.GetText(entity.callout2),
					callout3 = localisationService.GetText(entity.callout3),
					type = entity.type,
					navIcon = entity.navIcon,
					jurisdiction = entity.jurisdiction,
					parent = entity.parent,
					size = entity.size,
					reference = entity.__ref,
					path = entity.__path
				};

				index.Add(indexEntry);
			}

			return index;
		}
	}
}
