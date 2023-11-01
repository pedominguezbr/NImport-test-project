using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IDeProformaRep
	{
		List<DeProformaEnt> GetAllDeProforma(string cadenaquery);
		int? Save(ref DeProformaEnt deProformaEnt, string language);
		int? Delete(ref DeProformaEnt deProformaEnt, string language);
		int? Add(ref DeProformaEnt deProformaEnt, string language);
	}
}
