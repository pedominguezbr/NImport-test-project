using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ICuentaRep
	{
		List<CuentaEnt> GetAllCuenta(string cadenaquery);
		int? Save(ref CuentaEnt cuentaEnt, string language);
		int? Delete(ref CuentaEnt cuentaEnt, string language);
		int? Add(ref CuentaEnt cuentaEnt, string language);
	}
}
