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
	public class CHCancelaRep : ClaseBaseRep, ICHCancelaRep
	{
		public List<CHCancelaEnt> GetAllCHCancela(string cadenaquery)
		{
			List<CHCancelaEnt> cHCancelaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspCHCancelaList, 0, cadenaquery);
				cHCancelaList = GetCHCancelaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return cHCancelaList;
		}
		public int? Save(ref CHCancelaEnt cHCancelaEnt, string language)
		{
			int? resultado = null;
			if (cHCancelaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCHCancelaUpdateById, cHCancelaEnt.Enc_id, cHCancelaEnt.Fecha, cHCancelaEnt.CLIENTE, cHCancelaEnt.CtaSaldo, cHCancelaEnt.FVencimiento, cHCancelaEnt.Importe, cHCancelaEnt.Cli_id, cHCancelaEnt.COD_VEN, cHCancelaEnt.Cantidad, cHCancelaEnt.Observa, cHCancelaEnt.Ide_Canch, cHCancelaEnt.Banco, cHCancelaEnt.Cheque, cHCancelaEnt.Fpago, cHCancelaEnt.TRIAL543,  language);
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
		public int? Delete(ref CHCancelaEnt cHCancelaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCHCancelaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref CHCancelaEnt cHCancelaEnt, string language)
		{
			int? resultado = null;
			if (cHCancelaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspCHCancelaInsert, cHCancelaEnt.Enc_id, cHCancelaEnt.Fecha, cHCancelaEnt.CLIENTE, cHCancelaEnt.CtaSaldo, cHCancelaEnt.FVencimiento, cHCancelaEnt.Importe, cHCancelaEnt.Cli_id, cHCancelaEnt.COD_VEN, cHCancelaEnt.Cantidad, cHCancelaEnt.Observa, cHCancelaEnt.Ide_Canch, cHCancelaEnt.Banco, cHCancelaEnt.Cheque, cHCancelaEnt.Fpago, cHCancelaEnt.TRIAL543,  language);
                    //cHCancelaEnt.Enc_id = (long) resultado;
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
		public virtual List<CHCancelaEnt> GetCHCancelaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new CHCancelaEnt { Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), CLIENTE = dataRow.Field<string>("CLIENTE"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), FVencimiento = dataRow.Field<DateTime>("FVencimiento"), Importe = dataRow.Field<double>("Importe"), Cli_id = dataRow.Field<int>("Cli_id"), COD_VEN = dataRow.Field<string>("COD_VEN"), Cantidad = dataRow.Field<double>("Cantidad"), Observa = dataRow.Field<string>("Observa"), Ide_Canch = dataRow.Field<int>("Ide_Canch"), Banco = dataRow.Field<string>("Banco"), Cheque = dataRow.Field<string>("Cheque"), Fpago = dataRow.Field<DateTime>("Fpago"), TRIAL543 = dataRow.Field<string>("TRIAL543"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
