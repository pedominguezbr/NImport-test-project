using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TDebiApp:ITDebiApp
	{
		public List<TDebiEnt> GetAllTDebi(string cadenaquery)
		{
			ITDebiRep tDebiRep = new TDebiRep();
			try
			{
				return tDebiRep.GetAllTDebi(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TDebiEnt tDebiEnt, string language)
		{
			ITDebiRep tDebiRep = new TDebiRep();
			try
			{
				return tDebiRep.Save(ref tDebiEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TDebiEnt tDebiEnt, string language)
		{
			ITDebiRep tDebiRep = new TDebiRep();
			try
			{
				return tDebiRep.Delete(ref tDebiEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TDebiEnt tDebiEnt, string language)
		{
			ITDebiRep tDebiRep = new TDebiRep();
			try
			{
				return tDebiRep.Add(ref tDebiEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
