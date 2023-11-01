using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IFechaRep
	{
		List<FechaEnt> GetAllFecha(string cadenaquery);
		int? Save(ref FechaEnt fechaEnt, string language);
		int? Delete(ref FechaEnt fechaEnt, string language);
		int? Add(ref FechaEnt fechaEnt, string language);
	}
}
