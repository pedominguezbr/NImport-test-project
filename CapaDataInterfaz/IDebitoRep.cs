using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IDebitoRep
	{
		List<DebitoEnt> GetAllDebito(string cadenaquery);
		int? Save(ref DebitoEnt debitoEnt, string language);
		int? Delete(ref DebitoEnt debitoEnt, string language);
		int? Add(ref DebitoEnt debitoEnt, string language);
	}
}
