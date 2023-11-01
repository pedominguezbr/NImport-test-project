using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class ProformaApp:IProformaApp
	{
		public List<ProformaEnt> GetAllProforma(string cadenaquery)
		{
			IProformaRep proformaRep = new ProformaRep();
			try
			{
				return proformaRep.GetAllProforma(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref ProformaEnt proformaEnt, string language)
		{
			IProformaRep proformaRep = new ProformaRep();
			try
			{
				return proformaRep.Save(ref proformaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref ProformaEnt proformaEnt, string language)
		{
			IProformaRep proformaRep = new ProformaRep();
			try
			{
				return proformaRep.Delete(ref proformaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref ProformaEnt proformaEnt, string language)
		{
			IProformaRep proformaRep = new ProformaRep();
			try
			{
				return proformaRep.Add(ref proformaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
