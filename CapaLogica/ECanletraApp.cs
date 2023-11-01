using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class ECanletraApp:IECanletraApp
	{
		public List<ECanletraEnt> GetAllECanletra(string cadenaquery)
		{
			IECanletraRep eCanletraRep = new ECanletraRep();
			try
			{
				return eCanletraRep.GetAllECanletra(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref ECanletraEnt eCanletraEnt, string language)
		{
			IECanletraRep eCanletraRep = new ECanletraRep();
			try
			{
				return eCanletraRep.Save(ref eCanletraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref ECanletraEnt eCanletraEnt, string language)
		{
			IECanletraRep eCanletraRep = new ECanletraRep();
			try
			{
				return eCanletraRep.Delete(ref eCanletraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref ECanletraEnt eCanletraEnt, string language)
		{
			IECanletraRep eCanletraRep = new ECanletraRep();
			try
			{
				return eCanletraRep.Add(ref eCanletraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
