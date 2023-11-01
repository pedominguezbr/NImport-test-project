using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class MovimientoApp:IMovimientoApp
	{
		public List<MovimientoEnt> GetAllMovimiento(string cadenaquery)
		{
			IMovimientoRep movimientoRep = new MovimientoRep();
			try
			{
				return movimientoRep.GetAllMovimiento(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref MovimientoEnt movimientoEnt, string language)
		{
			IMovimientoRep movimientoRep = new MovimientoRep();
			try
			{
				return movimientoRep.Save(ref movimientoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref MovimientoEnt movimientoEnt, string language)
		{
			IMovimientoRep movimientoRep = new MovimientoRep();
			try
			{
				return movimientoRep.Delete(ref movimientoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref MovimientoEnt movimientoEnt, string language)
		{
			IMovimientoRep movimientoRep = new MovimientoRep();
			try
			{
				return movimientoRep.Add(ref movimientoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
