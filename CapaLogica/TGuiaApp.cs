using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TGuiaApp:ITGuiaApp
	{
		public List<TGuiaEnt> GetAllTGuia(string cadenaquery)
		{
			ITGuiaRep tGuiaRep = new TGuiaRep();
			try
			{
				return tGuiaRep.GetAllTGuia(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TGuiaEnt tGuiaEnt, string language)
		{
			ITGuiaRep tGuiaRep = new TGuiaRep();
			try
			{
				return tGuiaRep.Save(ref tGuiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TGuiaEnt tGuiaEnt, string language)
		{
			ITGuiaRep tGuiaRep = new TGuiaRep();
			try
			{
				return tGuiaRep.Delete(ref tGuiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TGuiaEnt tGuiaEnt, string language)
		{
			ITGuiaRep tGuiaRep = new TGuiaRep();
			try
			{
				return tGuiaRep.Add(ref tGuiaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
