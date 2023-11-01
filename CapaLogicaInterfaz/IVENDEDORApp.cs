using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface IVENDEDORApp
	{
        List<VENDEDOREnt> GetAllVENDEDOR(string codigovendedor, string vendedor);
		int? Save(ref VENDEDOREnt vENDEDOREnt, string language);
		int? Delete(ref VENDEDOREnt vENDEDOREnt, string language);
		int? Add(ref VENDEDOREnt vENDEDOREnt, string language);
	}
}
