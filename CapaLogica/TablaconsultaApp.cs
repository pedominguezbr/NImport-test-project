using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TablaconsultaApp:ITablaconsultaApp
	{
		public List<TablaconsultaEnt> GetAllTablaconsulta(string cadenaquery)
		{
			ITablaconsultaRep tablaconsultaRep = new TablaconsultaRep();
			try
			{
				return tablaconsultaRep.GetAllTablaconsulta(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TablaconsultaEnt tablaconsultaEnt, string language)
		{
			ITablaconsultaRep tablaconsultaRep = new TablaconsultaRep();
			try
			{
				return tablaconsultaRep.Save(ref tablaconsultaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TablaconsultaEnt tablaconsultaEnt, string language)
		{
			ITablaconsultaRep tablaconsultaRep = new TablaconsultaRep();
			try
			{
				return tablaconsultaRep.Delete(ref tablaconsultaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TablaconsultaEnt tablaconsultaEnt, string language)
		{
			ITablaconsultaRep tablaconsultaRep = new TablaconsultaRep();
			try
			{
				return tablaconsultaRep.Add(ref tablaconsultaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
