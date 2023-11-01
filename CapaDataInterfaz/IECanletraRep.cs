using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IECanletraRep
	{
		List<ECanletraEnt> GetAllECanletra(string cadenaquery);
		int? Save(ref ECanletraEnt eCanletraEnt, string language);
		int? Delete(ref ECanletraEnt eCanletraEnt, string language);
		int? Add(ref ECanletraEnt eCanletraEnt, string language);
	}
}
