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
	public class TDebiRep : ClaseBaseRep, ITDebiRep
	{
		public List<TDebiEnt> GetAllTDebi(string cadenaquery)
		{
			List<TDebiEnt> tDebiList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTDebiList, 0, cadenaquery);
				tDebiList = GetTDebiCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tDebiList;
		}
		public int? Save(ref TDebiEnt tDebiEnt, string language)
		{
			int? resultado = null;
			if (tDebiEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTDebiUpdateById, tDebiEnt.Enc_Id, tDebiEnt.Fecha, tDebiEnt.Cli_ID, tDebiEnt.Ruc, tDebiEnt.Doc, tDebiEnt.Fech, tDebiEnt.Observa, tDebiEnt.Cant, tDebiEnt.Precio, tDebiEnt.Importe, tDebiEnt.Igv, tDebiEnt.Total, tDebiEnt.Fech1, tDebiEnt.Fech2, tDebiEnt.TRIAL713,  language);
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
		public int? Delete(ref TDebiEnt tDebiEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTDebiDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TDebiEnt tDebiEnt, string language)
		{
			int? resultado = null;
			if (tDebiEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTDebiInsert, tDebiEnt.Enc_Id, tDebiEnt.Fecha, tDebiEnt.Cli_ID, tDebiEnt.Ruc, tDebiEnt.Doc, tDebiEnt.Fech, tDebiEnt.Observa, tDebiEnt.Cant, tDebiEnt.Precio, tDebiEnt.Importe, tDebiEnt.Igv, tDebiEnt.Total, tDebiEnt.Fech1, tDebiEnt.Fech2, tDebiEnt.TRIAL713,  language);
                    //tDebiEnt.Enc_Id = (long) resultado;
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
		public virtual List<TDebiEnt> GetTDebiCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TDebiEnt { Enc_Id = dataRow.Field<string>("Enc_Id"), Fecha = dataRow.Field<DateTime>("Fecha"), Cli_ID = dataRow.Field<int>("Cli_ID"), Ruc = dataRow.Field<string>("Ruc"), Doc = dataRow.Field<string>("Doc"), Fech = dataRow.Field<DateTime>("Fech"), Observa = dataRow.Field<string>("Observa"), Cant = dataRow.Field<double>("Cant"), Precio = dataRow.Field<double>("Precio"), Importe = dataRow.Field<double>("Importe"), Igv = dataRow.Field<double>("Igv"), Total = dataRow.Field<double>("Total"), Fech1 = dataRow.Field<DateTime>("Fech1"), Fech2 = dataRow.Field<DateTime>("Fech2"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
