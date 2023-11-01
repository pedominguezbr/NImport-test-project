using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITablaconsultaApp
	{
		List<TablaconsultaEnt> GetAllTablaconsulta(string cadenaquery);
		int? Save(ref TablaconsultaEnt tablaconsultaEnt, string language);
		int? Delete(ref TablaconsultaEnt tablaconsultaEnt, string language);
		int? Add(ref TablaconsultaEnt tablaconsultaEnt, string language);
	}
}
