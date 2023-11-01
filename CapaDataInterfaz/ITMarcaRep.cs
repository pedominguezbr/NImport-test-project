using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITMarcaRep
	{
		List<TMarcaEnt> GetAllTMarca(string cadenaquery);
		int? Save(ref TMarcaEnt tMarcaEnt, string language);
		int? Delete(ref TMarcaEnt tMarcaEnt, string language);
		int? Add(ref TMarcaEnt tMarcaEnt, string language);
	}
}
