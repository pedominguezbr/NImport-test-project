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
	public class DeProformaRep : ClaseBaseRep, IDeProformaRep
	{
		public List<DeProformaEnt> GetAllDeProforma(string cadenaquery)
		{
			List<DeProformaEnt> deProformaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspDeProformaList, 0, cadenaquery);
				deProformaList = GetDeProformaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return deProformaList;
		}
		public int? Save(ref DeProformaEnt deProformaEnt, string language)
		{
			int? resultado = null;
			if (deProformaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeProformaUpdateById, deProformaEnt.ART_ID, deProformaEnt.ENC_ID, deProformaEnt.TEM_NOMB, deProformaEnt.CANTIDAD, deProformaEnt.PRECIO, deProformaEnt.Predescto, deProformaEnt.DESCUENTO, deProformaEnt.TEM_SUBT, deProformaEnt.TRIAL560,  language);
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
		public int? Delete(ref DeProformaEnt deProformaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeProformaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref DeProformaEnt deProformaEnt, string language)
		{
			int? resultado = null;
			if (deProformaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspDeProformaInsert, deProformaEnt.ART_ID, deProformaEnt.ENC_ID, deProformaEnt.TEM_NOMB, deProformaEnt.CANTIDAD, deProformaEnt.PRECIO, deProformaEnt.Predescto, deProformaEnt.DESCUENTO, deProformaEnt.TEM_SUBT, deProformaEnt.TRIAL560,  language);
                    //deProformaEnt.ART_ID = (long) resultado;
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
		public virtual List<DeProformaEnt> GetDeProformaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new DeProformaEnt { ART_ID = dataRow.Field<int>("ART_ID"), ENC_ID = dataRow.Field<string>("ENC_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<double>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), Predescto = dataRow.Field<double>("Predescto"), DESCUENTO = dataRow.Field<double>("DESCUENTO"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), TRIAL560 = dataRow.Field<string>("TRIAL560"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
