using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ICategoríaRep
	{
		List<CategoríaEnt> GetAllCategoría(string cadenaquery);
		int? Save(ref CategoríaEnt categoríaEnt, string language);
		int? Delete(ref CategoríaEnt categoríaEnt, string language);
		int? Add(ref CategoríaEnt categoríaEnt, string language);
	}
}
