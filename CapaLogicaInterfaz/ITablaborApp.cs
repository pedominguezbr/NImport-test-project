using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITablaborApp
	{
		List<TablaborEnt> GetAllTablabor(string cadenaquery);
		int? Save(ref TablaborEnt tablaborEnt, string language);
		int? Delete(ref TablaborEnt tablaborEnt, string language);
		int? Add(ref TablaborEnt tablaborEnt, string language);
	}
}
