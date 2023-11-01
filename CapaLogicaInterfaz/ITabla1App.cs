using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITabla1App
	{
		List<Tabla1Ent> GetAllTabla1(string cadenaquery);
		int? Save(ref Tabla1Ent tabla1Ent, string language);
		int? Delete(ref Tabla1Ent tabla1Ent, string language);
		int? Add(ref Tabla1Ent tabla1Ent, string language);
	}
}
