using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITMIDERep
	{
		List<TMIDEEnt> GetAllTMIDE(string cadenaquery);
		int? Save(ref TMIDEEnt tMIDEEnt, string language);
		int? Delete(ref TMIDEEnt tMIDEEnt, string language);
		int? Add(ref TMIDEEnt tMIDEEnt, string language);
	}
}
