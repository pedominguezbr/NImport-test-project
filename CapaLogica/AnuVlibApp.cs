using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class AnuVlibApp:IAnuVlibApp
	{
		public List<AnuVlibEnt> GetAllAnuVlib(string cadenaquery)
		{
			IAnuVlibRep anuVlibRep = new AnuVlibRep();
			try
			{
				return anuVlibRep.GetAllAnuVlib(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref AnuVlibEnt anuVlibEnt, string language)
		{
			IAnuVlibRep anuVlibRep = new AnuVlibRep();
			try
			{
				return anuVlibRep.Save(ref anuVlibEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref AnuVlibEnt anuVlibEnt, string language)
		{
			IAnuVlibRep anuVlibRep = new AnuVlibRep();
			try
			{
				return anuVlibRep.Delete(ref anuVlibEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref AnuVlibEnt anuVlibEnt, string language)
		{
			IAnuVlibRep anuVlibRep = new AnuVlibRep();
			try
			{
				return anuVlibRep.Add(ref anuVlibEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
