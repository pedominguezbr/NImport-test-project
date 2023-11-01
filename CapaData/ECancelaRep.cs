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
	public class ECancelaRep : ClaseBaseRep, IECancelaRep
	{
		public List<ECancelaEnt> GetAllECancela(string cadenaquery)
		{
			List<ECancelaEnt> eCancelaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspECancelaList, 0, cadenaquery);
				eCancelaList = GetECancelaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return eCancelaList;
		}
		public int? Save(ref ECancelaEnt eCancelaEnt, string language)
		{
			int? resultado = null;
			if (eCancelaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspECancelaUpdateById, eCancelaEnt.Enc_id, eCancelaEnt.Fecha, eCancelaEnt.CLIENTE, eCancelaEnt.CtaSaldo, eCancelaEnt.FVencimiento, eCancelaEnt.Importe, eCancelaEnt.Cli_id, eCancelaEnt.COD_VEN, eCancelaEnt.Cantidad, eCancelaEnt.Observa, eCancelaEnt.Ide_Canf, eCancelaEnt.Fpago, eCancelaEnt.TRIAL609,  language);
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
		public int? Delete(ref ECancelaEnt eCancelaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspECancelaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref ECancelaEnt eCancelaEnt, string language)
		{
			int? resultado = null;
			if (eCancelaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspECancelaInsert, eCancelaEnt.Enc_id, eCancelaEnt.Fecha, eCancelaEnt.CLIENTE, eCancelaEnt.CtaSaldo, eCancelaEnt.FVencimiento, eCancelaEnt.Importe, eCancelaEnt.Cli_id, eCancelaEnt.COD_VEN, eCancelaEnt.Cantidad, eCancelaEnt.Observa, eCancelaEnt.Ide_Canf, eCancelaEnt.Fpago, eCancelaEnt.TRIAL609,  language);
                    //eCancelaEnt.Enc_id = (long) resultado;
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
		public virtual List<ECancelaEnt> GetECancelaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new ECancelaEnt { Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), CLIENTE = dataRow.Field<string>("CLIENTE"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), FVencimiento = dataRow.Field<DateTime>("FVencimiento"), Importe = dataRow.Field<double>("Importe"), Cli_id = dataRow.Field<int>("Cli_id"), COD_VEN = dataRow.Field<string>("COD_VEN"), Cantidad = dataRow.Field<double>("Cantidad"), Observa = dataRow.Field<string>("Observa"), Ide_Canf = dataRow.Field<int>("Ide_Canf"), Fpago = dataRow.Field<DateTime>("Fpago"), TRIAL609 = dataRow.Field<string>("TRIAL609"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
