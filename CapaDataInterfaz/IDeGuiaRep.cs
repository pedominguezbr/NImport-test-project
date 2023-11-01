using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IDeGuiaRep
	{
		List<DeGuiaEnt> GetAllDeGuia(string cadenaquery);
		int? Save(ref DeGuiaEnt deGuiaEnt, string language);
		int? Delete(ref DeGuiaEnt deGuiaEnt, string language);
		int? Add(ref DeGuiaEnt deGuiaEnt, string language);
	}
}
