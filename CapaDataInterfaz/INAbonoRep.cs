using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface INAbonoRep
	{
		List<NAbonoEnt> GetAllNAbono(string cadenaquery);
		int? Save(ref NAbonoEnt nAbonoEnt, string language);
		int? Delete(ref NAbonoEnt nAbonoEnt, string language);
		int? Add(ref NAbonoEnt nAbonoEnt, string language);
	}
}
