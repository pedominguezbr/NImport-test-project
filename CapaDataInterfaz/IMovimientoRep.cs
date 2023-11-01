using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IMovimientoRep
	{
		List<MovimientoEnt> GetAllMovimiento(string cadenaquery);
		int? Save(ref MovimientoEnt movimientoEnt, string language);
		int? Delete(ref MovimientoEnt movimientoEnt, string language);
		int? Add(ref MovimientoEnt movimientoEnt, string language);
	}
}
