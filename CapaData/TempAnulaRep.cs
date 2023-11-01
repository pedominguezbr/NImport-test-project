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
	public class TempAnulaRep : ClaseBaseRep, ITempAnulaRep
	{
		public List<TempAnulaEnt> GetAllTempAnula(string cadenaquery)
		{
			List<TempAnulaEnt> tempAnulaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTempAnulaList, 0, cadenaquery);
				tempAnulaList = GetTempAnulaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tempAnulaList;
		}
		public int? Save(ref TempAnulaEnt tempAnulaEnt, string language)
		{
			int? resultado = null;
			if (tempAnulaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempAnulaUpdateById, tempAnulaEnt.ENC_ID, tempAnulaEnt.ART_ID, tempAnulaEnt.TEM_NOMB, tempAnulaEnt.CANTIDAD, tempAnulaEnt.PRECIO, tempAnulaEnt.PRECIO2, tempAnulaEnt.DESCUENTO, tempAnulaEnt.Predescto, tempAnulaEnt.IGV, tempAnulaEnt.TEM_SUBT, tempAnulaEnt.FECHA, tempAnulaEnt.Cli_Id, tempAnulaEnt.Cod_Ven, tempAnulaEnt.TRIAL713,  language);
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
		public int? Delete(ref TempAnulaEnt tempAnulaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempAnulaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TempAnulaEnt tempAnulaEnt, string language)
		{
			int? resultado = null;
			if (tempAnulaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTempAnulaInsert, tempAnulaEnt.ENC_ID, tempAnulaEnt.ART_ID, tempAnulaEnt.TEM_NOMB, tempAnulaEnt.CANTIDAD, tempAnulaEnt.PRECIO, tempAnulaEnt.PRECIO2, tempAnulaEnt.DESCUENTO, tempAnulaEnt.Predescto, tempAnulaEnt.IGV, tempAnulaEnt.TEM_SUBT, tempAnulaEnt.FECHA, tempAnulaEnt.Cli_Id, tempAnulaEnt.Cod_Ven, tempAnulaEnt.TRIAL713,  language);
                    //tempAnulaEnt.ENC_ID = (long) resultado;
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
		public virtual List<TempAnulaEnt> GetTempAnulaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TempAnulaEnt { ENC_ID = dataRow.Field<string>("ENC_ID"), ART_ID = dataRow.Field<int>("ART_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<int>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), PRECIO2 = dataRow.Field<double>("PRECIO2"), DESCUENTO = dataRow.Field<double>("DESCUENTO"), Predescto = dataRow.Field<double>("Predescto"), IGV = dataRow.Field<double>("IGV"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), FECHA = dataRow.Field<DateTime>("FECHA"), Cli_Id = dataRow.Field<int>("Cli_Id"), Cod_Ven = dataRow.Field<int>("Cod_Ven"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
