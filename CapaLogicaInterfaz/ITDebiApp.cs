using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITDebiApp
	{
		List<TDebiEnt> GetAllTDebi(string cadenaquery);
		int? Save(ref TDebiEnt tDebiEnt, string language);
		int? Delete(ref TDebiEnt tDebiEnt, string language);
		int? Add(ref TDebiEnt tDebiEnt, string language);
	}
}
