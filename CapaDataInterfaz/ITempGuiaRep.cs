using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITempGuiaRep
	{
		List<TempGuiaEnt> GetAllTempGuia(string cadenaquery);
		int? Save(ref TempGuiaEnt tempGuiaEnt, string language);
		int? Delete(ref TempGuiaEnt tempGuiaEnt, string language);
		int? Add(ref TempGuiaEnt tempGuiaEnt, string language);
	}
}
