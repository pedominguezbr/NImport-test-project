using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class BoguiproApp:IBoguiproApp
	{
		public List<BoguiproEnt> GetAllBoguipro(string cadenaquery)
		{
			IBoguiproRep boguiproRep = new BoguiproRep();
			try
			{
				return boguiproRep.GetAllBoguipro(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref BoguiproEnt boguiproEnt, string language)
		{
			IBoguiproRep boguiproRep = new BoguiproRep();
			try
			{
				return boguiproRep.Save(ref boguiproEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref BoguiproEnt boguiproEnt, string language)
		{
			IBoguiproRep boguiproRep = new BoguiproRep();
			try
			{
				return boguiproRep.Delete(ref boguiproEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref BoguiproEnt boguiproEnt, string language)
		{
			IBoguiproRep boguiproRep = new BoguiproRep();
			try
			{
				return boguiproRep.Add(ref boguiproEnt, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
