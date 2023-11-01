using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class ContadoApp:IContadoApp
	{
		public List<ContadoEnt> GetAllContado(string cadenaquery)
		{
			IContadoRep contadoRep = new ContadoRep();
			try
			{
				return contadoRep.GetAllContado(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref ContadoEnt contadoEnt, string language)
		{
			IContadoRep contadoRep = new ContadoRep();
			try
			{
				return contadoRep.Save(ref contadoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref ContadoEnt contadoEnt, string language)
		{
			IContadoRep contadoRep = new ContadoRep();
			try
			{
				return contadoRep.Delete(ref contadoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref ContadoEnt contadoEnt, string language)
		{
			IContadoRep contadoRep = new ContadoRep();
			try
			{
				return contadoRep.Add(ref contadoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
