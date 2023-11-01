using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IRepcancelaApp
	{
		List<RepcancelaEnt> GetAllRepcancela(string cadenaquery);
		int? Save(ref RepcancelaEnt repcancelaEnt, string language);
		int? Delete(ref RepcancelaEnt repcancelaEnt, string language);
		int? Add(ref RepcancelaEnt repcancelaEnt, string language);
	}
}
