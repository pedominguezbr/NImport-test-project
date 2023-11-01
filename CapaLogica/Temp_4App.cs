using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class Temp_4App:ITemp_4App
	{
		public List<Temp_4Ent> GetAllTemp_4(string cadenaquery)
		{
			ITemp_4Rep temp_4Rep = new Temp_4Rep();
			try
			{
				return temp_4Rep.GetAllTemp_4(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref Temp_4Ent temp_4Ent, string language)
		{
			ITemp_4Rep temp_4Rep = new Temp_4Rep();
			try
			{
				return temp_4Rep.Save(ref temp_4Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref Temp_4Ent temp_4Ent, string language)
		{
			ITemp_4Rep temp_4Rep = new Temp_4Rep();
			try
			{
				return temp_4Rep.Delete(ref temp_4Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref Temp_4Ent temp_4Ent, string language)
		{
			ITemp_4Rep temp_4Rep = new Temp_4Rep();
			try
			{
				return temp_4Rep.Add(ref temp_4Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
