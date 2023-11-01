using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class FCarteraApp:IFCarteraApp
	{
		public List<FCarteraEnt> GetAllFCartera(string cadenaquery)
		{
			IFCarteraRep fCarteraRep = new FCarteraRep();
			try
			{
				return fCarteraRep.GetAllFCartera(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref FCarteraEnt fCarteraEnt, string language)
		{
			IFCarteraRep fCarteraRep = new FCarteraRep();
			try
			{
				return fCarteraRep.Save(ref fCarteraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref FCarteraEnt fCarteraEnt, string language)
		{
			IFCarteraRep fCarteraRep = new FCarteraRep();
			try
			{
				return fCarteraRep.Delete(ref fCarteraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref FCarteraEnt fCarteraEnt, string language)
		{
			IFCarteraRep fCarteraRep = new FCarteraRep();
			try
			{
				return fCarteraRep.Add(ref fCarteraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
