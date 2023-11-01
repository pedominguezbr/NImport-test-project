using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IFCarteraRep
	{
		List<FCarteraEnt> GetAllFCartera(string cadenaquery);
		int? Save(ref FCarteraEnt fCarteraEnt, string language);
		int? Delete(ref FCarteraEnt fCarteraEnt, string language);
		int? Add(ref FCarteraEnt fCarteraEnt, string language);
	}
}
