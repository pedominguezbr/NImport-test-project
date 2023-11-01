using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITMIDEApp
	{
		List<TMIDEEnt> GetAllTMIDE(string cadenaquery);
		int? Save(ref TMIDEEnt tMIDEEnt, string language);
		int? Delete(ref TMIDEEnt tMIDEEnt, string language);
		int? Add(ref TMIDEEnt tMIDEEnt, string language);
	}
}
