using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TMarcaApp:ITMarcaApp
	{
		public List<TMarcaEnt> GetAllTMarca(string cadenaquery)
		{
			ITMarcaRep tMarcaRep = new TMarcaRep();
			try
			{
				return tMarcaRep.GetAllTMarca(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TMarcaEnt tMarcaEnt, string language)
		{
			ITMarcaRep tMarcaRep = new TMarcaRep();
			try
			{
				return tMarcaRep.Save(ref tMarcaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TMarcaEnt tMarcaEnt, string language)
		{
			ITMarcaRep tMarcaRep = new TMarcaRep();
			try
			{
				return tMarcaRep.Delete(ref tMarcaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TMarcaEnt tMarcaEnt, string language)
		{
			ITMarcaRep tMarcaRep = new TMarcaRep();
			try
			{
				return tMarcaRep.Add(ref tMarcaEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
