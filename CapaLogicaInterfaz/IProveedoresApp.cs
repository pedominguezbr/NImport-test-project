using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IProveedoresApp
	{
		List<ProveedoresEnt> GetAllProveedores(string cadenaquery);
		int? Save(ref ProveedoresEnt proveedoresEnt, string language);
		int? Delete(ref ProveedoresEnt proveedoresEnt, string language);
		int? Add(ref ProveedoresEnt proveedoresEnt, string language);
	}
}
