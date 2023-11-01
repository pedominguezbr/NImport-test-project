using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class RepcancelaApp:IRepcancelaApp
	{
		public List<RepcancelaEnt> GetAllRepcancela(string cadenaquery)
		{
			IRepcancelaRep repcancelaRep = new RepcancelaRep();
			try
			{
				return repcancelaRep.GetAllRepcancela(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref RepcancelaEnt repcancelaEnt, string language)
		{
			IRepcancelaRep repcancelaRep = new RepcancelaRep();
			try
			{
				return repcancelaRep.Save(ref repcancelaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref RepcancelaEnt repcancelaEnt, string language)
		{
			IRepcancelaRep repcancelaRep = new RepcancelaRep();
			try
			{
				return repcancelaRep.Delete(ref repcancelaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref RepcancelaEnt repcancelaEnt, string language)
		{
			IRepcancelaRep repcancelaRep = new RepcancelaRep();
			try
			{
				return repcancelaRep.Add(ref repcancelaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
