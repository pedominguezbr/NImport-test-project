using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITemp_2Rep
	{
		List<Temp_2Ent> GetAllTemp_2(string cadenaquery);
		int? Save(ref Temp_2Ent temp_2Ent, string language);
		int? Delete(ref Temp_2Ent temp_2Ent, string language);
		int? Add(ref Temp_2Ent temp_2Ent, string language);
	}
}
