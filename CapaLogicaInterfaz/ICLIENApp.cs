using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ICLIENApp
	{
        List<CLIENEnt> GetAllCLIEN(int codigo, string nombre);
		int? Save(ref CLIENEnt cLIENEnt, string language);
		int? Delete(ref CLIENEnt cLIENEnt, string language);
		int? Add(ref CLIENEnt cLIENEnt, string language);
	}
}
