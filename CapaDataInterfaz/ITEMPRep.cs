using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITEMPRep
	{
		List<TEMPEnt> GetAllTEMP(string cadenaquery);
		int? Save(ref TEMPEnt tEMPEnt, string language);
		int? Delete(ref TEMPEnt tEMPEnt, string language);
		int? Add(ref TEMPEnt tEMPEnt, string language);
	}
}
