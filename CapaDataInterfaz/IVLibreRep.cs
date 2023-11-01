using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IVLibreRep
	{
		List<VLibreEnt> GetAllVLibre(string cadenaquery);
		int? Save(ref VLibreEnt vLibreEnt, string language);
		int? Delete(ref VLibreEnt vLibreEnt, string language);
		int? Add(ref VLibreEnt vLibreEnt, string language);
	}
}
