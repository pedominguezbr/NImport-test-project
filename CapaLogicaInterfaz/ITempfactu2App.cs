using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITempfactu2App
	{
		List<Tempfactu2Ent> GetAllTempfactu2(string cadenaquery);
		int? Save(ref Tempfactu2Ent tempfactu2Ent, string language);
		int? Delete(ref Tempfactu2Ent tempfactu2Ent, string language);
		int? Add(ref Tempfactu2Ent tempfactu2Ent, string language);
	}
}
