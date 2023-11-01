using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class DeNAbonoApp:IDeNAbonoApp
	{
		public List<DeNAbonoEnt> GetAllDeNAbono(string cadenaquery)
		{
			IDeNAbonoRep deNAbonoRep = new DeNAbonoRep();
			try
			{
				return deNAbonoRep.GetAllDeNAbono(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref DeNAbonoEnt deNAbonoEnt, string language)
		{
			IDeNAbonoRep deNAbonoRep = new DeNAbonoRep();
			try
			{
				return deNAbonoRep.Save(ref deNAbonoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref DeNAbonoEnt deNAbonoEnt, string language)
		{
			IDeNAbonoRep deNAbonoRep = new DeNAbonoRep();
			try
			{
				return deNAbonoRep.Delete(ref deNAbonoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref DeNAbonoEnt deNAbonoEnt, string language)
		{
			IDeNAbonoRep deNAbonoRep = new DeNAbonoRep();
			try
			{
				return deNAbonoRep.Add(ref deNAbonoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
