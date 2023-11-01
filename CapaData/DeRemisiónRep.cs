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
	public class DeRemisiónRep : ClaseBaseRep, IDeRemisiónRep
	{
		public List<DeRemisiónEnt> GetAllDeRemisión(string cadenaquery)
		{
			List<DeRemisiónEnt> deRemisiónList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspDeRemisiónList, 0, cadenaquery);
				deRemisiónList = GetDeRemisiónCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return deRemisiónList;
		}
		public int? Save(ref DeRemisiónEnt deRemisiónEnt, string language)
		{
			int? resultado = null;
			if (deRemisiónEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeRemisiónUpdateById, deRemisiónEnt.ART_ID, deRemisiónEnt.ENC_ID, deRemisiónEnt.TEM_NOMB, deRemisiónEnt.CANTIDAD, deRemisiónEnt.PRECIO, deRemisiónEnt.Predescto, deRemisiónEnt.Descuento, deRemisiónEnt.TEM_SUBT, deRemisiónEnt.TRIAL605,  language);
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
		public int? Delete(ref DeRemisiónEnt deRemisiónEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeRemisiónDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref DeRemisiónEnt deRemisiónEnt, string language)
		{
			int? resultado = null;
			if (deRemisiónEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspDeRemisiónInsert, deRemisiónEnt.ART_ID, deRemisiónEnt.ENC_ID, deRemisiónEnt.TEM_NOMB, deRemisiónEnt.CANTIDAD, deRemisiónEnt.PRECIO, deRemisiónEnt.Predescto, deRemisiónEnt.Descuento, deRemisiónEnt.TEM_SUBT, deRemisiónEnt.TRIAL605,  language);
                    //deRemisiónEnt.ART_ID = (long) resultado;
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
		public virtual List<DeRemisiónEnt> GetDeRemisiónCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new DeRemisiónEnt { ART_ID = dataRow.Field<int>("ART_ID"), ENC_ID = dataRow.Field<string>("ENC_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<double>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), Predescto = dataRow.Field<double>("Predescto"), Descuento = dataRow.Field<double>("Descuento"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), TRIAL605 = dataRow.Field<string>("TRIAL605"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
