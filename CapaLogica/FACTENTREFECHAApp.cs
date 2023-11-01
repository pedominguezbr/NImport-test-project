using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class FACTENTREFECHAApp:IFACTENTREFECHAApp
	{
		public List<FACTENTREFECHAEnt> GetAllFACTENTREFECHA(string cadenaquery)
		{
			IFACTENTREFECHARep fACTENTREFECHARep = new FACTENTREFECHARep();
			try
			{
				return fACTENTREFECHARep.GetAllFACTENTREFECHA(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref FACTENTREFECHAEnt fACTENTREFECHAEnt, string language)
		{
			IFACTENTREFECHARep fACTENTREFECHARep = new FACTENTREFECHARep();
			try
			{
				return fACTENTREFECHARep.Save(ref fACTENTREFECHAEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref FACTENTREFECHAEnt fACTENTREFECHAEnt, string language)
		{
			IFACTENTREFECHARep fACTENTREFECHARep = new FACTENTREFECHARep();
			try
			{
				return fACTENTREFECHARep.Delete(ref fACTENTREFECHAEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref FACTENTREFECHAEnt fACTENTREFECHAEnt, string language)
		{
			IFACTENTREFECHARep fACTENTREFECHARep = new FACTENTREFECHARep();
			try
			{
				return fACTENTREFECHARep.Add(ref fACTENTREFECHAEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
