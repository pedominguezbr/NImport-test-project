using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TMIDEApp:ITMIDEApp
	{
		public List<TMIDEEnt> GetAllTMIDE(string cadenaquery)
		{
			ITMIDERep tMIDERep = new TMIDERep();
			try
			{
				return tMIDERep.GetAllTMIDE(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TMIDEEnt tMIDEEnt, string language)
		{
			ITMIDERep tMIDERep = new TMIDERep();
			try
			{
				return tMIDERep.Save(ref tMIDEEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TMIDEEnt tMIDEEnt, string language)
		{
			ITMIDERep tMIDERep = new TMIDERep();
			try
			{
				return tMIDERep.Delete(ref tMIDEEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TMIDEEnt tMIDEEnt, string language)
		{
			ITMIDERep tMIDERep = new TMIDERep();
			try
			{
				return tMIDERep.Add(ref tMIDEEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
