using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TIENDAApp:ITIENDAApp
	{
        public List<TIENDAEnt> GetAllTIENDA(int codigoArt, string articulo, string categoria)
		{
			ITIENDARep tIENDARep = new TIENDARep();
			try
			{
                return tIENDARep.GetAllTIENDA(codigoArt, articulo, categoria);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TIENDAEnt tIENDAEnt, string language)
		{
			ITIENDARep tIENDARep = new TIENDARep();
			try
			{
				return tIENDARep.Save(ref tIENDAEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TIENDAEnt tIENDAEnt, string language)
		{
			ITIENDARep tIENDARep = new TIENDARep();
			try
			{
				return tIENDARep.Delete(ref tIENDAEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TIENDAEnt tIENDAEnt, string language)
		{
			ITIENDARep tIENDARep = new TIENDARep();
			try
			{
				return tIENDARep.Add(ref tIENDAEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
