using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class Tabla1App:ITabla1App
	{
		public List<Tabla1Ent> GetAllTabla1(string cadenaquery)
		{
			ITabla1Rep tabla1Rep = new Tabla1Rep();
			try
			{
				return tabla1Rep.GetAllTabla1(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref Tabla1Ent tabla1Ent, string language)
		{
			ITabla1Rep tabla1Rep = new Tabla1Rep();
			try
			{
				return tabla1Rep.Save(ref tabla1Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref Tabla1Ent tabla1Ent, string language)
		{
			ITabla1Rep tabla1Rep = new Tabla1Rep();
			try
			{
				return tabla1Rep.Delete(ref tabla1Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref Tabla1Ent tabla1Ent, string language)
		{
			ITabla1Rep tabla1Rep = new Tabla1Rep();
			try
			{
				return tabla1Rep.Add(ref tabla1Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
