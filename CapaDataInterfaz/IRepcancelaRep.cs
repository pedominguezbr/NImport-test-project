using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IRepcancelaRep
	{
		List<RepcancelaEnt> GetAllRepcancela(string cadenaquery);
		int? Save(ref RepcancelaEnt repcancelaEnt, string language);
		int? Delete(ref RepcancelaEnt repcancelaEnt, string language);
		int? Add(ref RepcancelaEnt repcancelaEnt, string language);
	}
}
