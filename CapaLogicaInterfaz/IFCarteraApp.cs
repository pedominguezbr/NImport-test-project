using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IFCarteraApp
	{
		List<FCarteraEnt> GetAllFCartera(string cadenaquery);
		int? Save(ref FCarteraEnt fCarteraEnt, string language);
		int? Delete(ref FCarteraEnt fCarteraEnt, string language);
		int? Add(ref FCarteraEnt fCarteraEnt, string language);
	}
}
