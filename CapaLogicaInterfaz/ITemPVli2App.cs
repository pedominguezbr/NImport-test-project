using System;
using System.Collections.Generic;
using NImport.Dom.Ent;

namespace NImport.AppInterface
{
	public interface ITemPVli2App
	{
		List<TemPVli2Ent> GetAllTemPVli2(string cadenaquery);
		int? Save(ref TemPVli2Ent temPVli2Ent, string language);
		int? Delete(ref TemPVli2Ent temPVli2Ent, string language);
		int? Add(ref TemPVli2Ent temPVli2Ent, string language);
	}
}
