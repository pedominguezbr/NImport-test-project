using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITAbonRep
	{
		List<TAbonEnt> GetAllTAbon(string cadenaquery);
		int? Save(ref TAbonEnt tAbonEnt, string language);
		int? Delete(ref TAbonEnt tAbonEnt, string language);
		int? Add(ref TAbonEnt tAbonEnt, string language);
	}
}
