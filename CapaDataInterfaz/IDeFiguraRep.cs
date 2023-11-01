using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IDeFiguraRep
	{
		List<DeFiguraEnt> GetAllDeFigura(string cadenaquery);
		int? Save(ref DeFiguraEnt deFiguraEnt, string language);
		int? Delete(ref DeFiguraEnt deFiguraEnt, string language);
		int? Add(ref DeFiguraEnt deFiguraEnt, string language);
	}
}
