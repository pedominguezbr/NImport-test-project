using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class RESULTADApp:IRESULTADApp
	{
		public List<RESULTADEnt> GetAllRESULTAD(string cadenaquery)
		{
			IRESULTADRep rESULTADRep = new RESULTADRep();
			try
			{
				return rESULTADRep.GetAllRESULTAD(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref RESULTADEnt rESULTADEnt, string language)
		{
			IRESULTADRep rESULTADRep = new RESULTADRep();
			try
			{
				return rESULTADRep.Save(ref rESULTADEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref RESULTADEnt rESULTADEnt, string language)
		{
			IRESULTADRep rESULTADRep = new RESULTADRep();
			try
			{
				return rESULTADRep.Delete(ref rESULTADEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref RESULTADEnt rESULTADEnt, string language)
		{
			IRESULTADRep rESULTADRep = new RESULTADRep();
			try
			{
				return rESULTADRep.Add(ref rESULTADEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
