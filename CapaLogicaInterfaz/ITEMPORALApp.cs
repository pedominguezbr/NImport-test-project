using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITEMPORALApp
	{
		List<TEMPORALEnt> GetAllTEMPORAL(string cadenaquery);
		int? Save(ref TEMPORALEnt tEMPORALEnt, string language);
		int? Delete(ref TEMPORALEnt tEMPORALEnt, string language);
		int? Add(ref TEMPORALEnt tEMPORALEnt, string language);
	}
}
