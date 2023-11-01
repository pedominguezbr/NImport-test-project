using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITablaConsulta2App
	{
		List<TablaConsulta2Ent> GetAllTablaConsulta2(string cadenaquery);
		int? Save(ref TablaConsulta2Ent tablaConsulta2Ent, string language);
		int? Delete(ref TablaConsulta2Ent tablaConsulta2Ent, string language);
		int? Add(ref TablaConsulta2Ent tablaConsulta2Ent, string language);
	}
}
