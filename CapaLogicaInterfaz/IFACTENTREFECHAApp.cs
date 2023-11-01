using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IFACTENTREFECHAApp
	{
		List<FACTENTREFECHAEnt> GetAllFACTENTREFECHA(string cadenaquery);
		int? Save(ref FACTENTREFECHAEnt fACTENTREFECHAEnt, string language);
		int? Delete(ref FACTENTREFECHAEnt fACTENTREFECHAEnt, string language);
		int? Add(ref FACTENTREFECHAEnt fACTENTREFECHAEnt, string language);
	}
}
