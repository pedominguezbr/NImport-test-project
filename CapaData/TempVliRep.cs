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
	public class TempVliRep : ClaseBaseRep, ITempVliRep
	{
		public List<TempVliEnt> GetAllTempVli(string cadenaquery)
		{
			List<TempVliEnt> tempVliList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTempVliList, 0, cadenaquery);
				tempVliList = GetTempVliCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tempVliList;
		}
		public int? Save(ref TempVliEnt tempVliEnt, string language)
		{
			int? resultado = null;
			if (tempVliEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempVliUpdateById, tempVliEnt.Cliente, tempVliEnt.Cod_Ven, tempVliEnt.ENC_ID, tempVliEnt.Fecha, tempVliEnt.Total, tempVliEnt.Observa, tempVliEnt.Fecha_1, tempVliEnt.Fecha_2, tempVliEnt.TRIAL716,  language);
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
		public int? Delete(ref TempVliEnt tempVliEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempVliDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TempVliEnt tempVliEnt, string language)
		{
			int? resultado = null;
			if (tempVliEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTempVliInsert, tempVliEnt.Cliente, tempVliEnt.Cod_Ven, tempVliEnt.ENC_ID, tempVliEnt.Fecha, tempVliEnt.Total, tempVliEnt.Observa, tempVliEnt.Fecha_1, tempVliEnt.Fecha_2, tempVliEnt.TRIAL716,  language);
                    //tempVliEnt.Cliente = (long) resultado;
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
		public virtual List<TempVliEnt> GetTempVliCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TempVliEnt { Cliente = dataRow.Field<string>("Cliente"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), ENC_ID = dataRow.Field<string>("ENC_ID"), Fecha = dataRow.Field<DateTime>("Fecha"), Total = dataRow.Field<double>("Total"), Observa = dataRow.Field<string>("Observa"), Fecha_1 = dataRow.Field<DateTime>("Fecha_1"), Fecha_2 = dataRow.Field<DateTime>("Fecha_2"), TRIAL716 = dataRow.Field<string>("TRIAL716"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
