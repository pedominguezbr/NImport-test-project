using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class DeFiguraApp:IDeFiguraApp
	{
		public List<DeFiguraEnt> GetAllDeFigura(string cadenaquery)
		{
			IDeFiguraRep deFiguraRep = new DeFiguraRep();
			try
			{
				return deFiguraRep.GetAllDeFigura(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref DeFiguraEnt deFiguraEnt, string language)
		{
			IDeFiguraRep deFiguraRep = new DeFiguraRep();
			try
			{
				return deFiguraRep.Save(ref deFiguraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref DeFiguraEnt deFiguraEnt, string language)
		{
			IDeFiguraRep deFiguraRep = new DeFiguraRep();
			try
			{
				return deFiguraRep.Delete(ref deFiguraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref DeFiguraEnt deFiguraEnt, string language)
		{
			IDeFiguraRep deFiguraRep = new DeFiguraRep();
			try
			{
				return deFiguraRep.Add(ref deFiguraEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
