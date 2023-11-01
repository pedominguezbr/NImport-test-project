using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IBorracliproRep
	{
		List<BorracliproEnt> GetAllBorraclipro(string cadenaquery);
		int? Save(ref BorracliproEnt borracliproEnt, string language);
		int? Delete(ref BorracliproEnt borracliproEnt, string language);
		int? Add(ref BorracliproEnt borracliproEnt, string language);
	}
}
