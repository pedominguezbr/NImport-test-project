using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class VENDEDORApp:IVENDEDORApp
	{
        public List<VENDEDOREnt> GetAllVENDEDOR(string codigovendedor, string vendedor)
		{
			IVENDEDORRep vENDEDORRep = new VENDEDORRep();
			try
			{
                return vENDEDORRep.GetAllVENDEDOR(codigovendedor, vendedor);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref VENDEDOREnt vENDEDOREnt, string language)
		{
			IVENDEDORRep vENDEDORRep = new VENDEDORRep();
			try
			{
				return vENDEDORRep.Save(ref vENDEDOREnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref VENDEDOREnt vENDEDOREnt, string language)
		{
			IVENDEDORRep vENDEDORRep = new VENDEDORRep();
			try
			{
				return vENDEDORRep.Delete(ref vENDEDOREnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref VENDEDOREnt vENDEDOREnt, string language)
		{
			IVENDEDORRep vENDEDORRep = new VENDEDORRep();
			try
			{
				return vENDEDORRep.Add(ref vENDEDOREnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
