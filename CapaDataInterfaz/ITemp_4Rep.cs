using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITemp_4Rep
	{
		List<Temp_4Ent> GetAllTemp_4(string cadenaquery);
		int? Save(ref Temp_4Ent temp_4Ent, string language);
		int? Delete(ref Temp_4Ent temp_4Ent, string language);
		int? Add(ref Temp_4Ent temp_4Ent, string language);
	}
}
