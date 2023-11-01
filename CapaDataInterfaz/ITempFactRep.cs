using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITempFactRep
	{
		List<TempFactEnt> GetAllTempFact(string cadenaquery);
		int? Save(ref TempFactEnt tempFactEnt, string language);
		int? Delete(ref TempFactEnt tempFactEnt, string language);
		int? Add(ref TempFactEnt tempFactEnt, string language);
	}
}
