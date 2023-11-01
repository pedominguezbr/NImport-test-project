using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITletApp
	{
		List<TletEnt> GetAllTlet(string cadenaquery);
		int? Save(ref TletEnt tletEnt, string language);
		int? Delete(ref TletEnt tletEnt, string language);
		int? Add(ref TletEnt tletEnt, string language);
	}
}
