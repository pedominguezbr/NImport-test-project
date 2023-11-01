using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IFactpendRep
	{
		List<FactpendEnt> GetAllFactpend(string cadenaquery);
		int? Save(ref FactpendEnt factpendEnt, string language);
		int? Delete(ref FactpendEnt factpendEnt, string language);
		int? Add(ref FactpendEnt factpendEnt, string language);
	}
}
