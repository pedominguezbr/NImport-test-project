using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TransporteApp:ITransporteApp
	{
		public List<TransporteEnt> GetAllTransporte(string cadenaquery)
		{
			ITransporteRep transporteRep = new TransporteRep();
			try
			{
				return transporteRep.GetAllTransporte(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TransporteEnt transporteEnt, string language)
		{
			ITransporteRep transporteRep = new TransporteRep();
			try
			{
				return transporteRep.Save(ref transporteEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TransporteEnt transporteEnt, string language)
		{
			ITransporteRep transporteRep = new TransporteRep();
			try
			{
				return transporteRep.Delete(ref transporteEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TransporteEnt transporteEnt, string language)
		{
			ITransporteRep transporteRep = new TransporteRep();
			try
			{
				return transporteRep.Add(ref transporteEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
