using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class FactpendApp:IFactpendApp
	{
		public List<FactpendEnt> GetAllFactpend(string cadenaquery)
		{
			IFactpendRep factpendRep = new FactpendRep();
			try
			{
				return factpendRep.GetAllFactpend(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref FactpendEnt factpendEnt, string language)
		{
			IFactpendRep factpendRep = new FactpendRep();
			try
			{
				return factpendRep.Save(ref factpendEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref FactpendEnt factpendEnt, string language)
		{
			IFactpendRep factpendRep = new FactpendRep();
			try
			{
				return factpendRep.Delete(ref factpendEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref FactpendEnt factpendEnt, string language)
		{
			IFactpendRep factpendRep = new FactpendRep();
			try
			{
				return factpendRep.Add(ref factpendEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
