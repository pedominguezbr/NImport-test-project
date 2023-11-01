using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TEMPORALApp:ITEMPORALApp
	{
		public List<TEMPORALEnt> GetAllTEMPORAL(string cadenaquery)
		{
			ITEMPORALRep tEMPORALRep = new TEMPORALRep();
			try
			{
				return tEMPORALRep.GetAllTEMPORAL(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TEMPORALEnt tEMPORALEnt, string language)
		{
			ITEMPORALRep tEMPORALRep = new TEMPORALRep();
			try
			{
				return tEMPORALRep.Save(ref tEMPORALEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TEMPORALEnt tEMPORALEnt, string language)
		{
			ITEMPORALRep tEMPORALRep = new TEMPORALRep();
			try
			{
				return tEMPORALRep.Delete(ref tEMPORALEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TEMPORALEnt tEMPORALEnt, string language)
		{
			ITEMPORALRep tEMPORALRep = new TEMPORALRep();
			try
			{
				return tEMPORALRep.Add(ref tEMPORALEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
