using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IAnuVlibApp
	{
		List<AnuVlibEnt> GetAllAnuVlib(string cadenaquery);
		int? Save(ref AnuVlibEnt anuVlibEnt, string language);
		int? Delete(ref AnuVlibEnt anuVlibEnt, string language);
		int? Add(ref AnuVlibEnt anuVlibEnt, string language);
	}
}
