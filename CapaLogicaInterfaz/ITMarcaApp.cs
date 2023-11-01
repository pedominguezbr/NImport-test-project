using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITMarcaApp
	{
		List<TMarcaEnt> GetAllTMarca(string cadenaquery);
		int? Save(ref TMarcaEnt tMarcaEnt, string language);
		int? Delete(ref TMarcaEnt tMarcaEnt, string language);
		int? Add(ref TMarcaEnt tMarcaEnt, string language);
	}
}
