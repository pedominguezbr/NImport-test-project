using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TablaborApp:ITablaborApp
	{
		public List<TablaborEnt> GetAllTablabor(string cadenaquery)
		{
			ITablaborRep tablaborRep = new TablaborRep();
			try
			{
				return tablaborRep.GetAllTablabor(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TablaborEnt tablaborEnt, string language)
		{
			ITablaborRep tablaborRep = new TablaborRep();
			try
			{
				return tablaborRep.Save(ref tablaborEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TablaborEnt tablaborEnt, string language)
		{
			ITablaborRep tablaborRep = new TablaborRep();
			try
			{
				return tablaborRep.Delete(ref tablaborEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TablaborEnt tablaborEnt, string language)
		{
			ITablaborRep tablaborRep = new TablaborRep();
			try
			{
				return tablaborRep.Add(ref tablaborEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
