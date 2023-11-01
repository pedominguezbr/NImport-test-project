using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TempCoApp:ITempCoApp
	{
		public List<TempCoEnt> GetAllTempCo(string cadenaquery)
		{
			ITempCoRep tempCoRep = new TempCoRep();
			try
			{
				return tempCoRep.GetAllTempCo(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TempCoEnt tempCoEnt, string language)
		{
			ITempCoRep tempCoRep = new TempCoRep();
			try
			{
				return tempCoRep.Save(ref tempCoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TempCoEnt tempCoEnt, string language)
		{
			ITempCoRep tempCoRep = new TempCoRep();
			try
			{
				return tempCoRep.Delete(ref tempCoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TempCoEnt tempCoEnt, string language)
		{
			ITempCoRep tempCoRep = new TempCoRep();
			try
			{
				return tempCoRep.Add(ref tempCoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
