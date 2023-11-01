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
	public class CHPagosRep : ClaseBaseRep, ICHPagosRep
	{
		public List<CHPagosEnt> GetAllCHPagos(string cadenaquery)
		{
			List<CHPagosEnt> cHPagosList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspCHPagosList, 0, cadenaquery);
				cHPagosList = GetCHPagosCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return cHPagosList;
		}
		public int? Save(ref CHPagosEnt cHPagosEnt, string language)
		{
			int? resultado = null;
			if (cHPagosEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCHPagosUpdateById, cHPagosEnt.Enc_id, cHPagosEnt.Fecha, cHPagosEnt.CLIENTE, cHPagosEnt.CtaSaldo, cHPagosEnt.FVencimiento, cHPagosEnt.Fpago, cHPagosEnt.Banco, cHPagosEnt.Cheque, cHPagosEnt.Id_CHpagos, cHPagosEnt.Cli_id, cHPagosEnt.Cantidad, cHPagosEnt.Importe, cHPagosEnt.COD_VEN, cHPagosEnt.Observa, cHPagosEnt.TRIAL543,  language);
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
		public int? Delete(ref CHPagosEnt cHPagosEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCHPagosDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref CHPagosEnt cHPagosEnt, string language)
		{
			int? resultado = null;
			if (cHPagosEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspCHPagosInsert, cHPagosEnt.Enc_id, cHPagosEnt.Fecha, cHPagosEnt.CLIENTE, cHPagosEnt.CtaSaldo, cHPagosEnt.FVencimiento, cHPagosEnt.Fpago, cHPagosEnt.Banco, cHPagosEnt.Cheque, cHPagosEnt.Id_CHpagos, cHPagosEnt.Cli_id, cHPagosEnt.Cantidad, cHPagosEnt.Importe, cHPagosEnt.COD_VEN, cHPagosEnt.Observa, cHPagosEnt.TRIAL543,  language);
                    //cHPagosEnt.Enc_id = (long) resultado;
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
		public virtual List<CHPagosEnt> GetCHPagosCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new CHPagosEnt { Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), CLIENTE = dataRow.Field<string>("CLIENTE"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), FVencimiento = dataRow.Field<DateTime>("FVencimiento"), Fpago = dataRow.Field<DateTime>("Fpago"), Banco = dataRow.Field<string>("Banco"), Cheque = dataRow.Field<string>("Cheque"), Id_CHpagos = dataRow.Field<int>("Id_CHpagos"), Cli_id = dataRow.Field<int>("Cli_id"), Cantidad = dataRow.Field<double>("Cantidad"), Importe = dataRow.Field<double>("Importe"), COD_VEN = dataRow.Field<string>("COD_VEN"), Observa = dataRow.Field<string>("Observa"), TRIAL543 = dataRow.Field<string>("TRIAL543"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
