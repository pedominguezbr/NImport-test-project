using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class GuiaApp:IGuiaApp
	{
		public List<GuiaEnt> GetAllGuia(string cadenaquery)
		{
			IGuiaRep guiaRep = new GuiaRep();
			try
			{
				return guiaRep.GetAllGuia(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref GuiaEnt guiaEnt, string language)
		{
			IGuiaRep guiaRep = new GuiaRep();
			try
			{
				return guiaRep.Save(ref guiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref GuiaEnt guiaEnt, string language)
		{
			IGuiaRep guiaRep = new GuiaRep();
			try
			{
				return guiaRep.Delete(ref guiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref GuiaEnt guiaEnt, string language)
		{
			IGuiaRep guiaRep = new GuiaRep();
			try
			{
				return guiaRep.Add(ref guiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
