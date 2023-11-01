using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IContadoRep
	{
		List<ContadoEnt> GetAllContado(string cadenaquery);
		int? Save(ref ContadoEnt contadoEnt, string language);
		int? Delete(ref ContadoEnt contadoEnt, string language);
		int? Add(ref ContadoEnt contadoEnt, string language);
	}
}
