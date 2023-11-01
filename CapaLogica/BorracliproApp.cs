using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class BorracliproApp:IBorracliproApp
	{
		public List<BorracliproEnt> GetAllBorraclipro(string cadenaquery)
		{
			IBorracliproRep borracliproRep = new BorracliproRep();
			try
			{
				return borracliproRep.GetAllBorraclipro(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref BorracliproEnt borracliproEnt, string language)
		{
			IBorracliproRep borracliproRep = new BorracliproRep();
			try
			{
				return borracliproRep.Save(ref borracliproEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref BorracliproEnt borracliproEnt, string language)
		{
			IBorracliproRep borracliproRep = new BorracliproRep();
			try
			{
				return borracliproRep.Delete(ref borracliproEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref BorracliproEnt borracliproEnt, string language)
		{
			IBorracliproRep borracliproRep = new BorracliproRep();
			try
			{
				return borracliproRep.Add(ref borracliproEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
