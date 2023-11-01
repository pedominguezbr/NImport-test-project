using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class CLIENApp:ICLIENApp
	{
        public List<CLIENEnt> GetAllCLIEN(int codigo, string nombre)
		{
			ICLIENRep cLIENRep = new CLIENRep();
			try
			{
                return cLIENRep.GetAllCLIEN(codigo, nombre);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref CLIENEnt cLIENEnt, string language)
		{
			ICLIENRep cLIENRep = new CLIENRep();
			try
			{
				return cLIENRep.Save(ref cLIENEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref CLIENEnt cLIENEnt, string language)
		{
			ICLIENRep cLIENRep = new CLIENRep();
			try
			{
				return cLIENRep.Delete(ref cLIENEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref CLIENEnt cLIENEnt, string language)
		{
			ICLIENRep cLIENRep = new CLIENRep();
			try
			{
				return cLIENRep.Add(ref cLIENEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
