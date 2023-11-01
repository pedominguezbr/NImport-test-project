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
	public class TempCoRep : ClaseBaseRep, ITempCoRep
	{
		public List<TempCoEnt> GetAllTempCo(string cadenaquery)
		{
			List<TempCoEnt> tempCoList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTempCoList, 0, cadenaquery);
				tempCoList = GetTempCoCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tempCoList;
		}
		public int? Save(ref TempCoEnt tempCoEnt, string language)
		{
			int? resultado = null;
			if (tempCoEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempCoUpdateById, tempCoEnt.LETRAS, tempCoEnt.TRIAL713,  language);
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
		public int? Delete(ref TempCoEnt tempCoEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempCoDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TempCoEnt tempCoEnt, string language)
		{
			int? resultado = null;
			if (tempCoEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTempCoInsert, tempCoEnt.LETRAS, tempCoEnt.TRIAL713,  language);
                    //tempCoEnt.LETRAS = (long) resultado;
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
		public virtual List<TempCoEnt> GetTempCoCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TempCoEnt { LETRAS = dataRow.Field<string>("LETRAS"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
