using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IGuiaApp
	{
		List<GuiaEnt> GetAllGuia(string cadenaquery);
		int? Save(ref GuiaEnt guiaEnt, string language);
		int? Delete(ref GuiaEnt guiaEnt, string language);
		int? Add(ref GuiaEnt guiaEnt, string language);
	}
}
