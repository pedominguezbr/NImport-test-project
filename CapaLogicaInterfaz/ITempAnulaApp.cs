using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITempAnulaApp
	{
		List<TempAnulaEnt> GetAllTempAnula(string cadenaquery);
		int? Save(ref TempAnulaEnt tempAnulaEnt, string language);
		int? Delete(ref TempAnulaEnt tempAnulaEnt, string language);
		int? Add(ref TempAnulaEnt tempAnulaEnt, string language);
	}
}
