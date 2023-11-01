using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IRESULTADRep
	{
		List<RESULTADEnt> GetAllRESULTAD(string cadenaquery);
		int? Save(ref RESULTADEnt rESULTADEnt, string language);
		int? Delete(ref RESULTADEnt rESULTADEnt, string language);
		int? Add(ref RESULTADEnt rESULTADEnt, string language);
	}
}
