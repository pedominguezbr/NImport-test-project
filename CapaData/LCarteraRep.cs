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
	public class LCarteraRep : ClaseBaseRep, ILCarteraRep
	{
		public List<LCarteraEnt> GetAllLCartera(string cadenaquery)
		{
			List<LCarteraEnt> lCarteraList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspLCarteraList, 0, cadenaquery);
				lCarteraList = GetLCarteraCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return lCarteraList;
		}
		public int? Save(ref LCarteraEnt lCarteraEnt, string language)
		{
			int? resultado = null;
			if (lCarteraEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspLCarteraUpdateById, lCarteraEnt.Enc_id, lCarteraEnt.CLIENTE, lCarteraEnt.FVencimiento, lCarteraEnt.Cantidad, lCarteraEnt.Fechal, lCarteraEnt.Fecha, lCarteraEnt.CtaSaldo, lCarteraEnt.Importe, lCarteraEnt.Id_Letras, lCarteraEnt.Numfactura, lCarteraEnt.CLI_ID, lCarteraEnt.Observa, lCarteraEnt.Cod_ven, lCarteraEnt.N_Unico, lCarteraEnt.TRIAL628,  language);
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
		public int? Delete(ref LCarteraEnt lCarteraEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspLCarteraDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref LCarteraEnt lCarteraEnt, string language)
		{
			int? resultado = null;
			if (lCarteraEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspLCarteraInsert, lCarteraEnt.Enc_id, lCarteraEnt.CLIENTE, lCarteraEnt.FVencimiento, lCarteraEnt.Cantidad, lCarteraEnt.Fechal, lCarteraEnt.Fecha, lCarteraEnt.CtaSaldo, lCarteraEnt.Importe, lCarteraEnt.Id_Letras, lCarteraEnt.Numfactura, lCarteraEnt.CLI_ID, lCarteraEnt.Observa, lCarteraEnt.Cod_ven, lCarteraEnt.N_Unico, lCarteraEnt.TRIAL628,  language);
                    //lCarteraEnt.Enc_id = (long) resultado;
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
		public virtual List<LCarteraEnt> GetLCarteraCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new LCarteraEnt { Enc_id = dataRow.Field<string>("Enc_id"), CLIENTE = dataRow.Field<string>("CLIENTE"), FVencimiento = dataRow.Field<DateTime>("FVencimiento"), Cantidad = dataRow.Field<double>("Cantidad"), Fechal = dataRow.Field<DateTime>("Fechal"), Fecha = dataRow.Field<DateTime>("Fecha"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), Importe = dataRow.Field<double>("Importe"), Id_Letras = dataRow.Field<int>("Id_Letras"), Numfactura = dataRow.Field<string>("Numfactura"), CLI_ID = dataRow.Field<int>("CLI_ID"), Observa = dataRow.Field<string>("Observa"), Cod_ven = dataRow.Field<string>("Cod_ven"), N_Unico = dataRow.Field<string>("N_Unico"), TRIAL628 = dataRow.Field<string>("TRIAL628"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
