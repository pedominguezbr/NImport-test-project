using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TempAnulaApp:ITempAnulaApp
	{
		public List<TempAnulaEnt> GetAllTempAnula(string cadenaquery)
		{
			ITempAnulaRep tempAnulaRep = new TempAnulaRep();
			try
			{
				return tempAnulaRep.GetAllTempAnula(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TempAnulaEnt tempAnulaEnt, string language)
		{
			ITempAnulaRep tempAnulaRep = new TempAnulaRep();
			try
			{
				return tempAnulaRep.Save(ref tempAnulaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TempAnulaEnt tempAnulaEnt, string language)
		{
			ITempAnulaRep tempAnulaRep = new TempAnulaRep();
			try
			{
				return tempAnulaRep.Delete(ref tempAnulaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TempAnulaEnt tempAnulaEnt, string language)
		{
			ITempAnulaRep tempAnulaRep = new TempAnulaRep();
			try
			{
				return tempAnulaRep.Add(ref tempAnulaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
