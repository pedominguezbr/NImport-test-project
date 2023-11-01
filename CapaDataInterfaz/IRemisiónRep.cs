using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IRemisiónRep
	{
		List<RemisiónEnt> GetAllRemisión(string cadenaquery);
		int? Save(ref RemisiónEnt remisiónEnt, string language);
		int? Delete(ref RemisiónEnt remisiónEnt, string language);
		int? Add(ref RemisiónEnt remisiónEnt, string language);
	}
}
