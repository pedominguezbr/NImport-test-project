using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IECancelaApp
	{
		List<ECancelaEnt> GetAllECancela(string cadenaquery);
		int? Save(ref ECancelaEnt eCancelaEnt, string language);
		int? Delete(ref ECancelaEnt eCancelaEnt, string language);
		int? Add(ref ECancelaEnt eCancelaEnt, string language);
	}
}
