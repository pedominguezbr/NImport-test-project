using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class FechaApp:IFechaApp
	{
		public List<FechaEnt> GetAllFecha(string cadenaquery)
		{
			IFechaRep fechaRep = new FechaRep();
			try
			{
				return fechaRep.GetAllFecha(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref FechaEnt fechaEnt, string language)
		{
			IFechaRep fechaRep = new FechaRep();
			try
			{
				return fechaRep.Save(ref fechaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref FechaEnt fechaEnt, string language)
		{
			IFechaRep fechaRep = new FechaRep();
			try
			{
				return fechaRep.Delete(ref fechaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref FechaEnt fechaEnt, string language)
		{
			IFechaRep fechaRep = new FechaRep();
			try
			{
				return fechaRep.Add(ref fechaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
