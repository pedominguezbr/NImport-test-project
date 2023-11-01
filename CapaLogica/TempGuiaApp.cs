using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TempGuiaApp:ITempGuiaApp
	{
		public List<TempGuiaEnt> GetAllTempGuia(string cadenaquery)
		{
			ITempGuiaRep tempGuiaRep = new TempGuiaRep();
			try
			{
				return tempGuiaRep.GetAllTempGuia(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TempGuiaEnt tempGuiaEnt, string language)
		{
			ITempGuiaRep tempGuiaRep = new TempGuiaRep();
			try
			{
				return tempGuiaRep.Save(ref tempGuiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TempGuiaEnt tempGuiaEnt, string language)
		{
			ITempGuiaRep tempGuiaRep = new TempGuiaRep();
			try
			{
				return tempGuiaRep.Delete(ref tempGuiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TempGuiaEnt tempGuiaEnt, string language)
		{
			ITempGuiaRep tempGuiaRep = new TempGuiaRep();
			try
			{
				return tempGuiaRep.Add(ref tempGuiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
