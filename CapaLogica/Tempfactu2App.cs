using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class Tempfactu2App:ITempfactu2App
	{
		public List<Tempfactu2Ent> GetAllTempfactu2(string cadenaquery)
		{
			ITempfactu2Rep tempfactu2Rep = new Tempfactu2Rep();
			try
			{
				return tempfactu2Rep.GetAllTempfactu2(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref Tempfactu2Ent tempfactu2Ent, string language)
		{
			ITempfactu2Rep tempfactu2Rep = new Tempfactu2Rep();
			try
			{
				return tempfactu2Rep.Save(ref tempfactu2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref Tempfactu2Ent tempfactu2Ent, string language)
		{
			ITempfactu2Rep tempfactu2Rep = new Tempfactu2Rep();
			try
			{
				return tempfactu2Rep.Delete(ref tempfactu2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref Tempfactu2Ent tempfactu2Ent, string language)
		{
			ITempfactu2Rep tempfactu2Rep = new Tempfactu2Rep();
			try
			{
				return tempfactu2Rep.Add(ref tempfactu2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
