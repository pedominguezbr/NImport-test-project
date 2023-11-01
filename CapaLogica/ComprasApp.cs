using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class ComprasApp:IComprasApp
	{
		public List<ComprasEnt> GetAllCompras(string cadenaquery)
		{
			IComprasRep comprasRep = new ComprasRep();
			try
			{
				return comprasRep.GetAllCompras(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref ComprasEnt comprasEnt, string language)
		{
			IComprasRep comprasRep = new ComprasRep();
			try
			{
				return comprasRep.Save(ref comprasEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref ComprasEnt comprasEnt, string language)
		{
			IComprasRep comprasRep = new ComprasRep();
			try
			{
				return comprasRep.Delete(ref comprasEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref ComprasEnt comprasEnt, string language)
		{
			IComprasRep comprasRep = new ComprasRep();
			try
			{
				return comprasRep.Add(ref comprasEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
