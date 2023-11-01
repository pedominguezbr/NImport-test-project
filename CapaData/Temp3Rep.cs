using System;
using System.Collections.Generic;
using System.Linq;
using NImport.Dom.Ent;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using NImport.Dom.RepInterface;
//using NImport.Inf.Trans;

namespace NImport.Inf.Rep
{
	public class Temp3Rep : ClaseBaseRep, ITemp3Rep
	{
		public List<Temp3Ent> GetAllTemp3(string cadenaquery)
		{
			List<Temp3Ent> temp3List = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTemp3List, 0, cadenaquery);
				temp3List = GetTemp3CollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return temp3List;
		}
		public int? Save(ref Temp3Ent temp3Ent, string language)
		{
			int? resultado = null;
			if (temp3Ent != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTemp3UpdateById, temp3Ent.Numletra, temp3Ent.Importe, temp3Ent.Fecha, temp3Ent.Fvencimiento, temp3Ent.Observa, temp3Ent.TRIAL713,  language);
				}
				catch (SqlException sqlex)
				{
					HandleSqlException(sqlex);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			return resultado;
		}
		public int? Delete(ref Temp3Ent temp3Ent, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTemp3DeleteById, Constantes.EntidadId, language);
				}
				catch (SqlException sqlex)
				{
					HandleSqlException(sqlex);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			return resultado;
		}
		public int? Add(ref Temp3Ent temp3Ent, string language)
		{
			int? resultado = null;
			if (temp3Ent != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTemp3Insert, temp3Ent.Numletra, temp3Ent.Importe, temp3Ent.Fecha, temp3Ent.Fvencimiento, temp3Ent.Observa, temp3Ent.TRIAL713,  language);
                    //temp3Ent.Numletra = (long) resultado;
				}
				catch (SqlException sqlex)
				{
					HandleSqlException(sqlex);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			return resultado;
		}
		public virtual List<Temp3Ent> GetTemp3CollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new Temp3Ent { Numletra = dataRow.Field<string>("Numletra"), Importe = dataRow.Field<double>("Importe"), Fecha = dataRow.Field<DateTime>("Fecha"), Fvencimiento = dataRow.Field<DateTime>("Fvencimiento"), Observa = dataRow.Field<string>("Observa"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
