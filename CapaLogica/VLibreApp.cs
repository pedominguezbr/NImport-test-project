using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class VLibreApp:IVLibreApp
	{
		public List<VLibreEnt> GetAllVLibre(string cadenaquery)
		{
			IVLibreRep vLibreRep = new VLibreRep();
			try
			{
				return vLibreRep.GetAllVLibre(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref VLibreEnt vLibreEnt, string language)
		{
			IVLibreRep vLibreRep = new VLibreRep();
			try
			{
				return vLibreRep.Save(ref vLibreEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref VLibreEnt vLibreEnt, string language)
		{
			IVLibreRep vLibreRep = new VLibreRep();
			try
			{
				return vLibreRep.Delete(ref vLibreEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref VLibreEnt vLibreEnt, string language)
		{
			IVLibreRep vLibreRep = new VLibreRep();
			try
			{
				return vLibreRep.Add(ref vLibreEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
