using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IFacturasApp
	{
		List<FacturasEnt> GetAllFacturas(string cadenaquery);
		int? Save(ref FacturasEnt facturasEnt, string language);
		int? Delete(ref FacturasEnt facturasEnt, string language);
		int? Add(ref FacturasEnt facturasEnt, string language);
	}
}
