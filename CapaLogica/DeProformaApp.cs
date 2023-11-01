using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class DeProformaApp:IDeProformaApp
	{
		public List<DeProformaEnt> GetAllDeProforma(string cadenaquery)
		{
			IDeProformaRep deProformaRep = new DeProformaRep();
			try
			{
				return deProformaRep.GetAllDeProforma(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref DeProformaEnt deProformaEnt, string language)
		{
			IDeProformaRep deProformaRep = new DeProformaRep();
			try
			{
				return deProformaRep.Save(ref deProformaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref DeProformaEnt deProformaEnt, string language)
		{
			IDeProformaRep deProformaRep = new DeProformaRep();
			try
			{
				return deProformaRep.Delete(ref deProformaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref DeProformaEnt deProformaEnt, string language)
		{
			IDeProformaRep deProformaRep = new DeProformaRep();
			try
			{
				return deProformaRep.Add(ref deProformaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
