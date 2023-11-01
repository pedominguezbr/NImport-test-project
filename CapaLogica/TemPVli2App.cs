using System;
using System.Collections.Generic;
using NImport.Dom.Ent;
using NImport.Dom.RepInterface;
using NImport.Inf.Rep;
using NImport.AppInterface;

namespace NImport.App
{
	public class TemPVli2App:ITemPVli2App
	{
		public List<TemPVli2Ent> GetAllTemPVli2(string cadenaquery)
		{
			ITemPVli2Rep temPVli2Rep = new TemPVli2Rep();
			try
			{
				return temPVli2Rep.GetAllTemPVli2(cadenaquery);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Save(ref TemPVli2Ent temPVli2Ent, string language)
		{
			ITemPVli2Rep temPVli2Rep = new TemPVli2Rep();
			try
			{
				return temPVli2Rep.Save(ref temPVli2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Delete(ref TemPVli2Ent temPVli2Ent, string language)
		{
			ITemPVli2Rep temPVli2Rep = new TemPVli2Rep();
			try
			{
				return temPVli2Rep.Delete(ref temPVli2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int? Add(ref TemPVli2Ent temPVli2Ent, string language)
		{
			ITemPVli2Rep temPVli2Rep = new TemPVli2Rep();
			try
			{
				return temPVli2Rep.Add(ref temPVli2Ent, language);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
