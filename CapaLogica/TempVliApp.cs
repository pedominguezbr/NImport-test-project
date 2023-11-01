using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TempVliApp:ITempVliApp
	{
		public List<TempVliEnt> GetAllTempVli(string cadenaquery)
		{
			ITempVliRep tempVliRep = new TempVliRep();
			try
			{
				return tempVliRep.GetAllTempVli(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TempVliEnt tempVliEnt, string language)
		{
			ITempVliRep tempVliRep = new TempVliRep();
			try
			{
				return tempVliRep.Save(ref tempVliEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TempVliEnt tempVliEnt, string language)
		{
			ITempVliRep tempVliRep = new TempVliRep();
			try
			{
				return tempVliRep.Delete(ref tempVliEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TempVliEnt tempVliEnt, string language)
		{
			ITempVliRep tempVliRep = new TempVliRep();
			try
			{
				return tempVliRep.Add(ref tempVliEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
