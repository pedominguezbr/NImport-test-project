using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class Temp3App:ITemp3App
	{
		public List<Temp3Ent> GetAllTemp3(string cadenaquery)
		{
			ITemp3Rep temp3Rep = new Temp3Rep();
			try
			{
				return temp3Rep.GetAllTemp3(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref Temp3Ent temp3Ent, string language)
		{
			ITemp3Rep temp3Rep = new Temp3Rep();
			try
			{
				return temp3Rep.Save(ref temp3Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref Temp3Ent temp3Ent, string language)
		{
			ITemp3Rep temp3Rep = new Temp3Rep();
			try
			{
				return temp3Rep.Delete(ref temp3Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref Temp3Ent temp3Ent, string language)
		{
			ITemp3Rep temp3Rep = new Temp3Rep();
			try
			{
				return temp3Rep.Add(ref temp3Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
