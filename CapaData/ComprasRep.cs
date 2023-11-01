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
	public class ComprasRep : ClaseBaseRep, IComprasRep
	{
		public List<ComprasEnt> GetAllCompras(string cadenaquery)
		{
			List<ComprasEnt> comprasList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspComprasList, 0, cadenaquery);
				comprasList = GetComprasCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return comprasList;
		}
		public int? Save(ref ComprasEnt comprasEnt, string language)
		{
			int? resultado = null;
			if (comprasEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspComprasUpdateById, comprasEnt.Prov_id, comprasEnt.Enc_id, comprasEnt.Fecha, comprasEnt.Total, comprasEnt.Observa, comprasEnt.TRIAL547,  language);
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
		public int? Delete(ref ComprasEnt comprasEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspComprasDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref ComprasEnt comprasEnt, string language)
		{
			int? resultado = null;
			if (comprasEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspComprasInsert, comprasEnt.Prov_id, comprasEnt.Enc_id, comprasEnt.Fecha, comprasEnt.Total, comprasEnt.Observa, comprasEnt.TRIAL547,  language);
                    //comprasEnt.Prov_id = (long) resultado;
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
		public virtual List<ComprasEnt> GetComprasCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new ComprasEnt { Prov_id = dataRow.Field<int>("Prov_id"), Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), Total = dataRow.Field<double>("Total"), Observa = dataRow.Field<string>("Observa"), TRIAL547 = dataRow.Field<string>("TRIAL547"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
