using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITransporteApp
	{
		List<TransporteEnt> GetAllTransporte(string cadenaquery);
		int? Save(ref TransporteEnt transporteEnt, string language);
		int? Delete(ref TransporteEnt transporteEnt, string language);
		int? Add(ref TransporteEnt transporteEnt, string language);
	}
}
