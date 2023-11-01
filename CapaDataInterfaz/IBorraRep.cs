using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IBorraRep
	{
		List<BorraEnt> GetAllBorra(string cadenaquery);
		int? Save(ref BorraEnt borraEnt, string language);
		int? Delete(ref BorraEnt borraEnt, string language);
		int? Add(ref BorraEnt borraEnt, string language);
	}
}
