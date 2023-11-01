using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class ProveedoresApp:IProveedoresApp
	{
		public List<ProveedoresEnt> GetAllProveedores(string cadenaquery)
		{
			IProveedoresRep proveedoresRep = new ProveedoresRep();
			try
			{
				return proveedoresRep.GetAllProveedores(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref ProveedoresEnt proveedoresEnt, string language)
		{
			IProveedoresRep proveedoresRep = new ProveedoresRep();
			try
			{
				return proveedoresRep.Save(ref proveedoresEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref ProveedoresEnt proveedoresEnt, string language)
		{
			IProveedoresRep proveedoresRep = new ProveedoresRep();
			try
			{
				return proveedoresRep.Delete(ref proveedoresEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref ProveedoresEnt proveedoresEnt, string language)
		{
			IProveedoresRep proveedoresRep = new ProveedoresRep();
			try
			{
				return proveedoresRep.Add(ref proveedoresEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
