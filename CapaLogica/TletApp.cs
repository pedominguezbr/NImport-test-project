using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TletApp:ITletApp
	{
		public List<TletEnt> GetAllTlet(string cadenaquery)
		{
			ITletRep tletRep = new TletRep();
			try
			{
				return tletRep.GetAllTlet(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TletEnt tletEnt, string language)
		{
			ITletRep tletRep = new TletRep();
			try
			{
				return tletRep.Save(ref tletEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TletEnt tletEnt, string language)
		{
			ITletRep tletRep = new TletRep();
			try
			{
				return tletRep.Delete(ref tletEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TletEnt tletEnt, string language)
		{
			ITletRep tletRep = new TletRep();
			try
			{
				return tletRep.Add(ref tletEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
