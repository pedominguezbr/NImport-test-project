using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IProformaApp
	{
		List<ProformaEnt> GetAllProforma(string cadenaquery);
		int? Save(ref ProformaEnt proformaEnt, string language);
		int? Delete(ref ProformaEnt proformaEnt, string language);
		int? Add(ref ProformaEnt proformaEnt, string language);
	}
}
