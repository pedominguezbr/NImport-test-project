using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class Temp_2App:ITemp_2App
	{
		public List<Temp_2Ent> GetAllTemp_2(string cadenaquery)
		{
			ITemp_2Rep temp_2Rep = new Temp_2Rep();
			try
			{
				return temp_2Rep.GetAllTemp_2(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref Temp_2Ent temp_2Ent, string language)
		{
			ITemp_2Rep temp_2Rep = new Temp_2Rep();
			try
			{
				return temp_2Rep.Save(ref temp_2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref Temp_2Ent temp_2Ent, string language)
		{
			ITemp_2Rep temp_2Rep = new Temp_2Rep();
			try
			{
				return temp_2Rep.Delete(ref temp_2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref Temp_2Ent temp_2Ent, string language)
		{
			ITemp_2Rep temp_2Rep = new Temp_2Rep();
			try
			{
				return temp_2Rep.Add(ref temp_2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
