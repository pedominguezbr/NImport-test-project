using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TempFactApp:ITempFactApp
	{
		public List<TempFactEnt> GetAllTempFact(string cadenaquery)
		{
			ITempFactRep tempFactRep = new TempFactRep();
			try
			{
				return tempFactRep.GetAllTempFact(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TempFactEnt tempFactEnt, string language)
		{
			ITempFactRep tempFactRep = new TempFactRep();
			try
			{
				return tempFactRep.Save(ref tempFactEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TempFactEnt tempFactEnt, string language)
		{
			ITempFactRep tempFactRep = new TempFactRep();
			try
			{
				return tempFactRep.Delete(ref tempFactEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TempFactEnt tempFactEnt, string language)
		{
			ITempFactRep tempFactRep = new TempFactRep();
			try
			{
				return tempFactRep.Add(ref tempFactEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
