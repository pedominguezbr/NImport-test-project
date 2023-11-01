using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class DeGuiaApp:IDeGuiaApp
	{
		public List<DeGuiaEnt> GetAllDeGuia(string cadenaquery)
		{
			IDeGuiaRep deGuiaRep = new DeGuiaRep();
			try
			{
				return deGuiaRep.GetAllDeGuia(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref DeGuiaEnt deGuiaEnt, string language)
		{
			IDeGuiaRep deGuiaRep = new DeGuiaRep();
			try
			{
				return deGuiaRep.Save(ref deGuiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref DeGuiaEnt deGuiaEnt, string language)
		{
			IDeGuiaRep deGuiaRep = new DeGuiaRep();
			try
			{
				return deGuiaRep.Delete(ref deGuiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref DeGuiaEnt deGuiaEnt, string language)
		{
			IDeGuiaRep deGuiaRep = new DeGuiaRep();
			try
			{
				return deGuiaRep.Add(ref deGuiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
