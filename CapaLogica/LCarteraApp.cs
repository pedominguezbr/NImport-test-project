using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class LCarteraApp:ILCarteraApp
	{
		public List<LCarteraEnt> GetAllLCartera(string cadenaquery)
		{
			ILCarteraRep lCarteraRep = new LCarteraRep();
			try
			{
				return lCarteraRep.GetAllLCartera(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref LCarteraEnt lCarteraEnt, string language)
		{
			ILCarteraRep lCarteraRep = new LCarteraRep();
			try
			{
				return lCarteraRep.Save(ref lCarteraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref LCarteraEnt lCarteraEnt, string language)
		{
			ILCarteraRep lCarteraRep = new LCarteraRep();
			try
			{
				return lCarteraRep.Delete(ref lCarteraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref LCarteraEnt lCarteraEnt, string language)
		{
			ILCarteraRep lCarteraRep = new LCarteraRep();
			try
			{
				return lCarteraRep.Add(ref lCarteraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
