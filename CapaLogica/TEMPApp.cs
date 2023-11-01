using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TEMPApp:ITEMPApp
	{
		public List<TEMPEnt> GetAllTEMP(string cadenaquery)
		{
			ITEMPRep tEMPRep = new TEMPRep();
			try
			{
				return tEMPRep.GetAllTEMP(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TEMPEnt tEMPEnt, string language)
		{
			ITEMPRep tEMPRep = new TEMPRep();
			try
			{
				return tEMPRep.Save(ref tEMPEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TEMPEnt tEMPEnt, string language)
		{
			ITEMPRep tEMPRep = new TEMPRep();
			try
			{
				return tEMPRep.Delete(ref tEMPEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TEMPEnt tEMPEnt, string language)
		{
			ITEMPRep tEMPRep = new TEMPRep();
			try
			{
				return tEMPRep.Add(ref tEMPEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
