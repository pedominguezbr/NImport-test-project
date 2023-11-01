using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TablaConsulta2App:ITablaConsulta2App
	{
		public List<TablaConsulta2Ent> GetAllTablaConsulta2(string cadenaquery)
		{
			ITablaConsulta2Rep tablaConsulta2Rep = new TablaConsulta2Rep();
			try
			{
				return tablaConsulta2Rep.GetAllTablaConsulta2(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TablaConsulta2Ent tablaConsulta2Ent, string language)
		{
			ITablaConsulta2Rep tablaConsulta2Rep = new TablaConsulta2Rep();
			try
			{
				return tablaConsulta2Rep.Save(ref tablaConsulta2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TablaConsulta2Ent tablaConsulta2Ent, string language)
		{
			ITablaConsulta2Rep tablaConsulta2Rep = new TablaConsulta2Rep();
			try
			{
				return tablaConsulta2Rep.Delete(ref tablaConsulta2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TablaConsulta2Ent tablaConsulta2Ent, string language)
		{
			ITablaConsulta2Rep tablaConsulta2Rep = new TablaConsulta2Rep();
			try
			{
				return tablaConsulta2Rep.Add(ref tablaConsulta2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
