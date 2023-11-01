using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITGuiaApp
	{
		List<TGuiaEnt> GetAllTGuia(string cadenaquery);
		int? Save(ref TGuiaEnt tGuiaEnt, string language);
		int? Delete(ref TGuiaEnt tGuiaEnt, string language);
		int? Add(ref TGuiaEnt tGuiaEnt, string language);
	}
}
