using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class BocliproApp:IBocliproApp
	{
		public List<BocliproEnt> GetAllBoclipro(string cadenaquery)
		{
			IBocliproRep bocliproRep = new BocliproRep();
			try
			{
				return bocliproRep.GetAllBoclipro(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref BocliproEnt bocliproEnt, string language)
		{
			IBocliproRep bocliproRep = new BocliproRep();
			try
			{
				return bocliproRep.Save(ref bocliproEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref BocliproEnt bocliproEnt, string language)
		{
			IBocliproRep bocliproRep = new BocliproRep();
			try
			{
				return bocliproRep.Delete(ref bocliproEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref BocliproEnt bocliproEnt, string language)
		{
			IBocliproRep bocliproRep = new BocliproRep();
			try
			{
				return bocliproRep.Add(ref bocliproEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
