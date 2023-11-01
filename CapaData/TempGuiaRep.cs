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
	public class TempGuiaRep : ClaseBaseRep, ITempGuiaRep
	{
		public List<TempGuiaEnt> GetAllTempGuia(string cadenaquery)
		{
			List<TempGuiaEnt> tempGuiaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTempGuiaList, 0, cadenaquery);
				tempGuiaList = GetTempGuiaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tempGuiaList;
		}
		public int? Save(ref TempGuiaEnt tempGuiaEnt, string language)
		{
			int? resultado = null;
			if (tempGuiaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempGuiaUpdateById, tempGuiaEnt.Enc_Id, tempGuiaEnt.Fecha, tempGuiaEnt.Producto, tempGuiaEnt.Cantidad, tempGuiaEnt.Cliente, tempGuiaEnt.Fech1, tempGuiaEnt.Fech2, tempGuiaEnt.TRIAL716,  language);
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
		public int? Delete(ref TempGuiaEnt tempGuiaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempGuiaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TempGuiaEnt tempGuiaEnt, string language)
		{
			int? resultado = null;
			if (tempGuiaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTempGuiaInsert, tempGuiaEnt.Enc_Id, tempGuiaEnt.Fecha, tempGuiaEnt.Producto, tempGuiaEnt.Cantidad, tempGuiaEnt.Cliente, tempGuiaEnt.Fech1, tempGuiaEnt.Fech2, tempGuiaEnt.TRIAL716,  language);
                    //tempGuiaEnt.Enc_Id = (long) resultado;
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
		public virtual List<TempGuiaEnt> GetTempGuiaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TempGuiaEnt { Enc_Id = dataRow.Field<string>("Enc_Id"), Fecha = dataRow.Field<DateTime>("Fecha"), Producto = dataRow.Field<string>("Producto"), Cantidad = dataRow.Field<string>("Cantidad"), Cliente = dataRow.Field<string>("Cliente"), Fech1 = dataRow.Field<DateTime>("Fech1"), Fech2 = dataRow.Field<DateTime>("Fech2"), TRIAL716 = dataRow.Field<string>("TRIAL716"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
