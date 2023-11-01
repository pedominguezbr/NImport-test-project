using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IDeNAbonoRep
	{
		List<DeNAbonoEnt> GetAllDeNAbono(string cadenaquery);
		int? Save(ref DeNAbonoEnt deNAbonoEnt, string language);
		int? Delete(ref DeNAbonoEnt deNAbonoEnt, string language);
		int? Add(ref DeNAbonoEnt deNAbonoEnt, string language);
	}
}
