using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IAnuladasRep
	{
		List<AnuladasEnt> GetAllAnuladas(string cadenaquery);
		int? Save(ref AnuladasEnt anuladasEnt, string language);
		int? Delete(ref AnuladasEnt anuladasEnt, string language);
		int? Add(ref AnuladasEnt anuladasEnt, string language);
	}
}
