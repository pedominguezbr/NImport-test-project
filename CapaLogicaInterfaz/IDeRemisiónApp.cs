using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IDeRemisiónApp
	{
		List<DeRemisiónEnt> GetAllDeRemisión(string cadenaquery);
		int? Save(ref DeRemisiónEnt deRemisiónEnt, string language);
		int? Delete(ref DeRemisiónEnt deRemisiónEnt, string language);
		int? Add(ref DeRemisiónEnt deRemisiónEnt, string language);
	}
}
