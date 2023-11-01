using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class CHPagosApp:ICHPagosApp
	{
		public List<CHPagosEnt> GetAllCHPagos(string cadenaquery)
		{
			ICHPagosRep cHPagosRep = new CHPagosRep();
			try
			{
				return cHPagosRep.GetAllCHPagos(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref CHPagosEnt cHPagosEnt, string language)
		{
			ICHPagosRep cHPagosRep = new CHPagosRep();
			try
			{
				return cHPagosRep.Save(ref cHPagosEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref CHPagosEnt cHPagosEnt, string language)
		{
			ICHPagosRep cHPagosRep = new CHPagosRep();
			try
			{
				return cHPagosRep.Delete(ref cHPagosEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref CHPagosEnt cHPagosEnt, string language)
		{
			ICHPagosRep cHPagosRep = new CHPagosRep();
			try
			{
				return cHPagosRep.Add(ref cHPagosEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
