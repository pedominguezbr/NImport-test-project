using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITempCoApp
	{
		List<TempCoEnt> GetAllTempCo(string cadenaquery);
		int? Save(ref TempCoEnt tempCoEnt, string language);
		int? Delete(ref TempCoEnt tempCoEnt, string language);
		int? Add(ref TempCoEnt tempCoEnt, string language);
	}
}
