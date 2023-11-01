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
	public class NAbonoRep : ClaseBaseRep, INAbonoRep
	{
		public List<NAbonoEnt> GetAllNAbono(string cadenaquery)
		{
			List<NAbonoEnt> nAbonoList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspNAbonoList, 0, cadenaquery);
				nAbonoList = GetNAbonoCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return nAbonoList;
		}
		public int? Save(ref NAbonoEnt nAbonoEnt, string language)
		{
			int? resultado = null;
			if (nAbonoEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspNAbonoUpdateById, nAbonoEnt.Enc_id, nAbonoEnt.Fecha, nAbonoEnt.Total, nAbonoEnt.Igv, nAbonoEnt.Importe, nAbonoEnt.Cli_id, nAbonoEnt.N_Factur, nAbonoEnt.F_Factur, nAbonoEnt.TRIAL661,  language);
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
		public int? Delete(ref NAbonoEnt nAbonoEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspNAbonoDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref NAbonoEnt nAbonoEnt, string language)
		{
			int? resultado = null;
			if (nAbonoEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspNAbonoInsert, nAbonoEnt.Enc_id, nAbonoEnt.Fecha, nAbonoEnt.Total, nAbonoEnt.Igv, nAbonoEnt.Importe, nAbonoEnt.Cli_id, nAbonoEnt.N_Factur, nAbonoEnt.F_Factur, nAbonoEnt.TRIAL661,  language);
                    //nAbonoEnt.Enc_id = (long) resultado;
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
		public virtual List<NAbonoEnt> GetNAbonoCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new NAbonoEnt { Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), Total = dataRow.Field<double>("Total"), Igv = dataRow.Field<double>("Igv"), Importe = dataRow.Field<double>("Importe"), Cli_id = dataRow.Field<int>("Cli_id"), N_Factur = dataRow.Field<string>("N_Factur"), F_Factur = dataRow.Field<DateTime>("F_Factur"), TRIAL661 = dataRow.Field<string>("TRIAL661"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
