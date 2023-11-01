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
	public class RepcancelaRep : ClaseBaseRep, IRepcancelaRep
	{
		public List<RepcancelaEnt> GetAllRepcancela(string cadenaquery)
		{
			List<RepcancelaEnt> repcancelaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspRepcancelaList, 0, cadenaquery);
				repcancelaList = GetRepcancelaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return repcancelaList;
		}
		public int? Save(ref RepcancelaEnt repcancelaEnt, string language)
		{
			int? resultado = null;
			if (repcancelaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspRepcancelaUpdateById, repcancelaEnt.Enc_id, repcancelaEnt.Fecha, repcancelaEnt.CLIENTE, repcancelaEnt.Importe, repcancelaEnt.Cod_Ven, repcancelaEnt.FCancela, repcancelaEnt.Cli_id, repcancelaEnt.FVencimiento, repcancelaEnt.Ctasaldo, repcancelaEnt.TRIAL664,  language);
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
		public int? Delete(ref RepcancelaEnt repcancelaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspRepcancelaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref RepcancelaEnt repcancelaEnt, string language)
		{
			int? resultado = null;
			if (repcancelaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspRepcancelaInsert, repcancelaEnt.Enc_id, repcancelaEnt.Fecha, repcancelaEnt.CLIENTE, repcancelaEnt.Importe, repcancelaEnt.Cod_Ven, repcancelaEnt.FCancela, repcancelaEnt.Cli_id, repcancelaEnt.FVencimiento, repcancelaEnt.Ctasaldo, repcancelaEnt.TRIAL664,  language);
                    //repcancelaEnt.Enc_id = (long) resultado;
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
		public virtual List<RepcancelaEnt> GetRepcancelaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new RepcancelaEnt { Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), CLIENTE = dataRow.Field<string>("CLIENTE"), Importe = dataRow.Field<double>("Importe"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), FCancela = dataRow.Field<DateTime>("FCancela"), Cli_id = dataRow.Field<int>("Cli_id"), FVencimiento = dataRow.Field<DateTime>("FVencimiento"), Ctasaldo = dataRow.Field<double>("Ctasaldo"), TRIAL664 = dataRow.Field<string>("TRIAL664"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
