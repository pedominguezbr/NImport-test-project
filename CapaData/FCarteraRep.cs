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
	public class FCarteraRep : ClaseBaseRep, IFCarteraRep
	{
		public List<FCarteraEnt> GetAllFCartera(string cadenaquery)
		{
			List<FCarteraEnt> fCarteraList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspFCarteraList, 0, cadenaquery);
				fCarteraList = GetFCarteraCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return fCarteraList;
		}
		public int? Save(ref FCarteraEnt fCarteraEnt, string language)
		{
			int? resultado = null;
			if (fCarteraEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspFCarteraUpdateById, fCarteraEnt.Enc_id, fCarteraEnt.Fecha, fCarteraEnt.CLIENTE, fCarteraEnt.CtaSaldo, fCarteraEnt.FVencimiento, fCarteraEnt.Total, fCarteraEnt.Igv, fCarteraEnt.Importe, fCarteraEnt.Vendedor, fCarteraEnt.Id_Cartera, fCarteraEnt.Cli_id, fCarteraEnt.Cod_ven, fCarteraEnt.Cantidad, fCarteraEnt.Observa, fCarteraEnt.TRIAL622,  language);
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
		public int? Delete(ref FCarteraEnt fCarteraEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspFCarteraDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref FCarteraEnt fCarteraEnt, string language)
		{
			int? resultado = null;
			if (fCarteraEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspFCarteraInsert, fCarteraEnt.Enc_id, fCarteraEnt.Fecha, fCarteraEnt.CLIENTE, fCarteraEnt.CtaSaldo, fCarteraEnt.FVencimiento, fCarteraEnt.Total, fCarteraEnt.Igv, fCarteraEnt.Importe, fCarteraEnt.Vendedor, fCarteraEnt.Id_Cartera, fCarteraEnt.Cli_id, fCarteraEnt.Cod_ven, fCarteraEnt.Cantidad, fCarteraEnt.Observa, fCarteraEnt.TRIAL622,  language);
                    //fCarteraEnt.Enc_id = (long) resultado;
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
		public virtual List<FCarteraEnt> GetFCarteraCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new FCarteraEnt { Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), CLIENTE = dataRow.Field<string>("CLIENTE"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), FVencimiento = dataRow.Field<DateTime>("FVencimiento"), Total = dataRow.Field<double>("Total"), Igv = dataRow.Field<string>("Igv"), Importe = dataRow.Field<double>("Importe"), Vendedor = dataRow.Field<string>("Vendedor"), Id_Cartera = dataRow.Field<int>("Id_Cartera"), Cli_id = dataRow.Field<int>("Cli_id"), Cod_ven = dataRow.Field<string>("Cod_ven"), Cantidad = dataRow.Field<double>("Cantidad"), Observa = dataRow.Field<string>("Observa"), TRIAL622 = dataRow.Field<string>("TRIAL622"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
