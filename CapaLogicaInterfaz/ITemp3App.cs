using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITemp3App
	{
		List<Temp3Ent> GetAllTemp3(string cadenaquery);
		int? Save(ref Temp3Ent temp3Ent, string language);
		int? Delete(ref Temp3Ent temp3Ent, string language);
		int? Add(ref Temp3Ent temp3Ent, string language);
	}
}
