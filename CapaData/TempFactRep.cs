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
	public class TempFactRep : ClaseBaseRep, ITempFactRep
	{
		public List<TempFactEnt> GetAllTempFact(string cadenaquery)
		{
			List<TempFactEnt> tempFactList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTempFactList, 0, cadenaquery);
				tempFactList = GetTempFactCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tempFactList;
		}
		public int? Save(ref TempFactEnt tempFactEnt, string language)
		{
			int? resultado = null;
			if (tempFactEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempFactUpdateById, tempFactEnt.Cliente, tempFactEnt.Cod_Ven, tempFactEnt.ENC_ID, tempFactEnt.Fecha, tempFactEnt.Importe, tempFactEnt.Observa, tempFactEnt.IGV, tempFactEnt.Total, tempFactEnt.Fecha_1, tempFactEnt.Fecha_2, tempFactEnt.TRIAL716,  language);
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
		public int? Delete(ref TempFactEnt tempFactEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempFactDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TempFactEnt tempFactEnt, string language)
		{
			int? resultado = null;
			if (tempFactEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTempFactInsert, tempFactEnt.Cliente, tempFactEnt.Cod_Ven, tempFactEnt.ENC_ID, tempFactEnt.Fecha, tempFactEnt.Importe, tempFactEnt.Observa, tempFactEnt.IGV, tempFactEnt.Total, tempFactEnt.Fecha_1, tempFactEnt.Fecha_2, tempFactEnt.TRIAL716,  language);
                    //tempFactEnt.Cliente = (long) resultado;
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
		public virtual List<TempFactEnt> GetTempFactCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TempFactEnt { Cliente = dataRow.Field<string>("Cliente"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), ENC_ID = dataRow.Field<string>("ENC_ID"), Fecha = dataRow.Field<DateTime>("Fecha"), Importe = dataRow.Field<double>("Importe"), Observa = dataRow.Field<string>("Observa"), IGV = dataRow.Field<double>("IGV"), Total = dataRow.Field<double>("Total"), Fecha_1 = dataRow.Field<DateTime>("Fecha_1"), Fecha_2 = dataRow.Field<string>("Fecha_2"), TRIAL716 = dataRow.Field<string>("TRIAL716"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
