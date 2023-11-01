using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITempVliRep
	{
		List<TempVliEnt> GetAllTempVli(string cadenaquery);
		int? Save(ref TempVliEnt tempVliEnt, string language);
		int? Delete(ref TempVliEnt tempVliEnt, string language);
		int? Add(ref TempVliEnt tempVliEnt, string language);
	}
}
