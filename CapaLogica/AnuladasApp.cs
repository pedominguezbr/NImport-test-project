using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class AnuladasApp:IAnuladasApp
	{
		public List<AnuladasEnt> GetAllAnuladas(string cadenaquery)
		{
			IAnuladasRep anuladasRep = new AnuladasRep();
			try
			{
				return anuladasRep.GetAllAnuladas(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref AnuladasEnt anuladasEnt, string language)
		{
			IAnuladasRep anuladasRep = new AnuladasRep();
			try
			{
				return anuladasRep.Save(ref anuladasEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref AnuladasEnt anuladasEnt, string language)
		{
			IAnuladasRep anuladasRep = new AnuladasRep();
			try
			{
				return anuladasRep.Delete(ref anuladasEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref AnuladasEnt anuladasEnt, string language)
		{
			IAnuladasRep anuladasRep = new AnuladasRep();
			try
			{
				return anuladasRep.Add(ref anuladasEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
