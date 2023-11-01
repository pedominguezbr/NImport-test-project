using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IDeVLibreApp
	{
		List<DeVLibreEnt> GetAllDeVLibre(string cadenaquery);
		int? Save(ref DeVLibreEnt deVLibreEnt, string language);
		int? Delete(ref DeVLibreEnt deVLibreEnt, string language);
		int? Add(ref DeVLibreEnt deVLibreEnt, string language);
	}
}
