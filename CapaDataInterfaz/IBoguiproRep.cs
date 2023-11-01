using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface IBoguiproRep
	{
		List<BoguiproEnt> GetAllBoguipro(string cadenaquery);
		int? Save(ref BoguiproEnt boguiproEnt, string language);
		int? Delete(ref BoguiproEnt boguiproEnt, string language);
		int? Add(ref BoguiproEnt boguiproEnt, string language);
	}
}
