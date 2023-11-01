using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IComprasRep
	{
		List<ComprasEnt> GetAllCompras(string cadenaquery);
		int? Save(ref ComprasEnt comprasEnt, string language);
		int? Delete(ref ComprasEnt comprasEnt, string language);
		int? Add(ref ComprasEnt comprasEnt, string language);
	}
}
