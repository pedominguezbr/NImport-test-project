using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IDeVLibreRep
	{
		List<DeVLibreEnt> GetAllDeVLibre(string cadenaquery);
		int? Save(ref DeVLibreEnt deVLibreEnt, string language);
		int? Delete(ref DeVLibreEnt deVLibreEnt, string language);
		int? Add(ref DeVLibreEnt deVLibreEnt, string language);
	}
}
