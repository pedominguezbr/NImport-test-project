using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TAbonApp:ITAbonApp
	{
		public List<TAbonEnt> GetAllTAbon(string cadenaquery)
		{
			ITAbonRep tAbonRep = new TAbonRep();
			try
			{
				return tAbonRep.GetAllTAbon(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TAbonEnt tAbonEnt, string language)
		{
			ITAbonRep tAbonRep = new TAbonRep();
			try
			{
				return tAbonRep.Save(ref tAbonEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TAbonEnt tAbonEnt, string language)
		{
			ITAbonRep tAbonRep = new TAbonRep();
			try
			{
				return tAbonRep.Delete(ref tAbonEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TAbonEnt tAbonEnt, string language)
		{
			ITAbonRep tAbonRep = new TAbonRep();
			try
			{
				return tAbonRep.Add(ref tAbonEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
