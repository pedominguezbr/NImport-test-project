using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITempGuiaApp
	{
		List<TempGuiaEnt> GetAllTempGuia(string cadenaquery);
		int? Save(ref TempGuiaEnt tempGuiaEnt, string language);
		int? Delete(ref TempGuiaEnt tempGuiaEnt, string language);
		int? Add(ref TempGuiaEnt tempGuiaEnt, string language);
	}
}
