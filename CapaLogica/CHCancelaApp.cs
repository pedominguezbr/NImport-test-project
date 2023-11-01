using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class CHCancelaApp:ICHCancelaApp
	{
		public List<CHCancelaEnt> GetAllCHCancela(string cadenaquery)
		{
			ICHCancelaRep cHCancelaRep = new CHCancelaRep();
			try
			{
				return cHCancelaRep.GetAllCHCancela(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref CHCancelaEnt cHCancelaEnt, string language)
		{
			ICHCancelaRep cHCancelaRep = new CHCancelaRep();
			try
			{
				return cHCancelaRep.Save(ref cHCancelaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref CHCancelaEnt cHCancelaEnt, string language)
		{
			ICHCancelaRep cHCancelaRep = new CHCancelaRep();
			try
			{
				return cHCancelaRep.Delete(ref cHCancelaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref CHCancelaEnt cHCancelaEnt, string language)
		{
			ICHCancelaRep cHCancelaRep = new CHCancelaRep();
			try
			{
				return cHCancelaRep.Add(ref cHCancelaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
