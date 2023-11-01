using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class FacturasApp:IFacturasApp
	{
		public List<FacturasEnt> GetAllFacturas(string cadenaquery)
		{
			IFacturasRep facturasRep = new FacturasRep();
			try
			{
				return facturasRep.GetAllFacturas(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref FacturasEnt facturasEnt, string language)
		{
			IFacturasRep facturasRep = new FacturasRep();
			try
			{
				return facturasRep.Save(ref facturasEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref FacturasEnt facturasEnt, string language)
		{
			IFacturasRep facturasRep = new FacturasRep();
			try
			{
				return facturasRep.Delete(ref facturasEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref FacturasEnt facturasEnt, string language)
		{
			IFacturasRep facturasRep = new FacturasRep();
			try
			{
				return facturasRep.Add(ref facturasEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
