using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class BorraApp:IBorraApp
	{
		public List<BorraEnt> GetAllBorra(string cadenaquery)
		{
			IBorraRep borraRep = new BorraRep();
			try
			{
				return borraRep.GetAllBorra(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref BorraEnt borraEnt, string language)
		{
			IBorraRep borraRep = new BorraRep();
			try
			{
				return borraRep.Save(ref borraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref BorraEnt borraEnt, string language)
		{
			IBorraRep borraRep = new BorraRep();
			try
			{
				return borraRep.Delete(ref borraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref BorraEnt borraEnt, string language)
		{
			IBorraRep borraRep = new BorraRep();
			try
			{
				return borraRep.Add(ref borraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
