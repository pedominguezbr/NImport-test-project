using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class RemisiónApp:IRemisiónApp
	{
		public List<RemisiónEnt> GetAllRemisión(string cadenaquery)
		{
			IRemisiónRep remisiónRep = new RemisiónRep();
			try
			{
				return remisiónRep.GetAllRemisión(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref RemisiónEnt remisiónEnt, string language)
		{
			IRemisiónRep remisiónRep = new RemisiónRep();
			try
			{
				return remisiónRep.Save(ref remisiónEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref RemisiónEnt remisiónEnt, string language)
		{
			IRemisiónRep remisiónRep = new RemisiónRep();
			try
			{
				return remisiónRep.Delete(ref remisiónEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref RemisiónEnt remisiónEnt, string language)
		{
			IRemisiónRep remisiónRep = new RemisiónRep();
			try
			{
				return remisiónRep.Add(ref remisiónEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
