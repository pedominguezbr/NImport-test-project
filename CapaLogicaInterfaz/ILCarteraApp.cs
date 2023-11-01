using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ILCarteraApp
	{
		List<LCarteraEnt> GetAllLCartera(string cadenaquery);
		int? Save(ref LCarteraEnt lCarteraEnt, string language);
		int? Delete(ref LCarteraEnt lCarteraEnt, string language);
		int? Add(ref LCarteraEnt lCarteraEnt, string language);
	}
}
