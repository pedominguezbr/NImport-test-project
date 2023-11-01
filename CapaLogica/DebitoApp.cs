using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class DebitoApp:IDebitoApp
	{
		public List<DebitoEnt> GetAllDebito(string cadenaquery)
		{
			IDebitoRep debitoRep = new DebitoRep();
			try
			{
				return debitoRep.GetAllDebito(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref DebitoEnt debitoEnt, string language)
		{
			IDebitoRep debitoRep = new DebitoRep();
			try
			{
				return debitoRep.Save(ref debitoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref DebitoEnt debitoEnt, string language)
		{
			IDebitoRep debitoRep = new DebitoRep();
			try
			{
				return debitoRep.Delete(ref debitoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref DebitoEnt debitoEnt, string language)
		{
			IDebitoRep debitoRep = new DebitoRep();
			try
			{
				return debitoRep.Add(ref debitoEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
