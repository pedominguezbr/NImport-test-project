using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class NAbonoApp:INAbonoApp
	{
		public List<NAbonoEnt> GetAllNAbono(string cadenaquery)
		{
			INAbonoRep nAbonoRep = new NAbonoRep();
			try
			{
				return nAbonoRep.GetAllNAbono(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref NAbonoEnt nAbonoEnt, string language)
		{
			INAbonoRep nAbonoRep = new NAbonoRep();
			try
			{
				return nAbonoRep.Save(ref nAbonoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref NAbonoEnt nAbonoEnt, string language)
		{
			INAbonoRep nAbonoRep = new NAbonoRep();
			try
			{
				return nAbonoRep.Delete(ref nAbonoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref NAbonoEnt nAbonoEnt, string language)
		{
			INAbonoRep nAbonoRep = new NAbonoRep();
			try
			{
				return nAbonoRep.Add(ref nAbonoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
