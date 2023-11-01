using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class CuentaApp:ICuentaApp
	{
		public List<CuentaEnt> GetAllCuenta(string cadenaquery)
		{
			ICuentaRep cuentaRep = new CuentaRep();
			try
			{
				return cuentaRep.GetAllCuenta(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref CuentaEnt cuentaEnt, string language)
		{
			ICuentaRep cuentaRep = new CuentaRep();
			try
			{
				return cuentaRep.Save(ref cuentaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref CuentaEnt cuentaEnt, string language)
		{
			ICuentaRep cuentaRep = new CuentaRep();
			try
			{
				return cuentaRep.Delete(ref cuentaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref CuentaEnt cuentaEnt, string language)
		{
			ICuentaRep cuentaRep = new CuentaRep();
			try
			{
				return cuentaRep.Add(ref cuentaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
