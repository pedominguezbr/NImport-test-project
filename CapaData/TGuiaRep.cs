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
	public class TGuiaRep : ClaseBaseRep, ITGuiaRep
	{
		public List<TGuiaEnt> GetAllTGuia(string cadenaquery)
		{
			List<TGuiaEnt> tGuiaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTGuiaList, 0, cadenaquery);
				tGuiaList = GetTGuiaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tGuiaList;
		}
		public int? Save(ref TGuiaEnt tGuiaEnt, string language)
		{
			int? resultado = null;
			if (tGuiaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTGuiaUpdateById, tGuiaEnt.Cliente, tGuiaEnt.Enc_Id, tGuiaEnt.Fecha, tGuiaEnt.IGV, tGuiaEnt.Total, tGuiaEnt.Importe, tGuiaEnt.Cod_Ven, tGuiaEnt.Observa, tGuiaEnt.Fech1, tGuiaEnt.Fech2, tGuiaEnt.TRIAL716,  language);
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
		public int? Delete(ref TGuiaEnt tGuiaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTGuiaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TGuiaEnt tGuiaEnt, string language)
		{
			int? resultado = null;
			if (tGuiaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTGuiaInsert, tGuiaEnt.Cliente, tGuiaEnt.Enc_Id, tGuiaEnt.Fecha, tGuiaEnt.IGV, tGuiaEnt.Total, tGuiaEnt.Importe, tGuiaEnt.Cod_Ven, tGuiaEnt.Observa, tGuiaEnt.Fech1, tGuiaEnt.Fech2, tGuiaEnt.TRIAL716,  language);
                    //tGuiaEnt.Cliente = (long) resultado;
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
		public virtual List<TGuiaEnt> GetTGuiaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TGuiaEnt { Cliente = dataRow.Field<string>("Cliente"), Enc_Id = dataRow.Field<string>("Enc_Id"), Fecha = dataRow.Field<DateTime>("Fecha"), IGV = dataRow.Field<double>("IGV"), Total = dataRow.Field<double>("Total"), Importe = dataRow.Field<double>("Importe"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), Observa = dataRow.Field<string>("Observa"), Fech1 = dataRow.Field<DateTime>("Fech1"), Fech2 = dataRow.Field<DateTime>("Fech2"), TRIAL716 = dataRow.Field<string>("TRIAL716"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
