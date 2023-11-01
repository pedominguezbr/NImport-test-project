using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class CategoríaApp:ICategoríaApp
	{
		public List<CategoríaEnt> GetAllCategoría(string cadenaquery)
		{
			ICategoríaRep categoríaRep = new CategoríaRep();
			try
			{
				return categoríaRep.GetAllCategoría(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref CategoríaEnt categoríaEnt, string language)
		{
			ICategoríaRep categoríaRep = new CategoríaRep();
			try
			{
				return categoríaRep.Save(ref categoríaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref CategoríaEnt categoríaEnt, string language)
		{
			ICategoríaRep categoríaRep = new CategoríaRep();
			try
			{
				return categoríaRep.Delete(ref categoríaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref CategoríaEnt categoríaEnt, string language)
		{
			ICategoríaRep categoríaRep = new CategoríaRep();
			try
			{
				return categoríaRep.Add(ref categoríaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
