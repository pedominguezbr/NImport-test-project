using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IBocliproRep
	{
		List<BocliproEnt> GetAllBoclipro(string cadenaquery);
		int? Save(ref BocliproEnt bocliproEnt, string language);
		int? Delete(ref BocliproEnt bocliproEnt, string language);
		int? Add(ref BocliproEnt bocliproEnt, string language);
	}
}
