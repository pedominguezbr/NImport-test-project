using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class DeRemisiónApp:IDeRemisiónApp
	{
		public List<DeRemisiónEnt> GetAllDeRemisión(string cadenaquery)
		{
			IDeRemisiónRep deRemisiónRep = new DeRemisiónRep();
			try
			{
				return deRemisiónRep.GetAllDeRemisión(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref DeRemisiónEnt deRemisiónEnt, string language)
		{
			IDeRemisiónRep deRemisiónRep = new DeRemisiónRep();
			try
			{
				return deRemisiónRep.Save(ref deRemisiónEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref DeRemisiónEnt deRemisiónEnt, string language)
		{
			IDeRemisiónRep deRemisiónRep = new DeRemisiónRep();
			try
			{
				return deRemisiónRep.Delete(ref deRemisiónEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref DeRemisiónEnt deRemisiónEnt, string language)
		{
			IDeRemisiónRep deRemisiónRep = new DeRemisiónRep();
			try
			{
				return deRemisiónRep.Add(ref deRemisiónEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
