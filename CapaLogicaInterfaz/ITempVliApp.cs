using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITempVliApp
	{
		List<TempVliEnt> GetAllTempVli(string cadenaquery);
		int? Save(ref TempVliEnt tempVliEnt, string language);
		int? Delete(ref TempVliEnt tempVliEnt, string language);
		int? Add(ref TempVliEnt tempVliEnt, string language);
	}
}
