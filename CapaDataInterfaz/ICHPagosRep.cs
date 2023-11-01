using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ICHPagosRep
	{
		List<CHPagosEnt> GetAllCHPagos(string cadenaquery);
		int? Save(ref CHPagosEnt cHPagosEnt, string language);
		int? Delete(ref CHPagosEnt cHPagosEnt, string language);
		int? Add(ref CHPagosEnt cHPagosEnt, string language);
	}
}
