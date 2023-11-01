using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.Dom.RepInterface
{
	public interface ITIENDARep
	{
        List<TIENDAEnt> GetAllTIENDA(int codigoArt, string articulo, string categoria);
		int? Save(ref TIENDAEnt tIENDAEnt, string language);
		int? Delete(ref TIENDAEnt tIENDAEnt, string language);
		int? Add(ref TIENDAEnt tIENDAEnt, string language);
	}
}
