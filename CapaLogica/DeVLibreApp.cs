using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class DeVLibreApp:IDeVLibreApp
	{
		public List<DeVLibreEnt> GetAllDeVLibre(string cadenaquery)
		{
			IDeVLibreRep deVLibreRep = new DeVLibreRep();
			try
			{
				return deVLibreRep.GetAllDeVLibre(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref DeVLibreEnt deVLibreEnt, string language)
		{
			IDeVLibreRep deVLibreRep = new DeVLibreRep();
			try
			{
				return deVLibreRep.Save(ref deVLibreEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref DeVLibreEnt deVLibreEnt, string language)
		{
			IDeVLibreRep deVLibreRep = new DeVLibreRep();
			try
			{
				return deVLibreRep.Delete(ref deVLibreEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref DeVLibreEnt deVLibreEnt, string language)
		{
			IDeVLibreRep deVLibreRep = new DeVLibreRep();
			try
			{
				return deVLibreRep.Add(ref deVLibreEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
