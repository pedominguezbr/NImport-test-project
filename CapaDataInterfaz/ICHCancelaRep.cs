using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ICHCancelaRep
	{
		List<CHCancelaEnt> GetAllCHCancela(string cadenaquery);
		int? Save(ref CHCancelaEnt cHCancelaEnt, string language);
		int? Delete(ref CHCancelaEnt cHCancelaEnt, string language);
		int? Add(ref CHCancelaEnt cHCancelaEnt, string language);
	}
}
