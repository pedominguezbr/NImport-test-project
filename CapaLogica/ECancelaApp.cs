using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class ECancelaApp:IECancelaApp
	{
		public List<ECancelaEnt> GetAllECancela(string cadenaquery)
		{
			IECancelaRep eCancelaRep = new ECancelaRep();
			try
			{
				return eCancelaRep.GetAllECancela(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref ECancelaEnt eCancelaEnt, string language)
		{
			IECancelaRep eCancelaRep = new ECancelaRep();
			try
			{
				return eCancelaRep.Save(ref eCancelaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref ECancelaEnt eCancelaEnt, string language)
		{
			IECancelaRep eCancelaRep = new ECancelaRep();
			try
			{
				return eCancelaRep.Delete(ref eCancelaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref ECancelaEnt eCancelaEnt, string language)
		{
			IECancelaRep eCancelaRep = new ECancelaRep();
			try
			{
				return eCancelaRep.Add(ref eCancelaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
