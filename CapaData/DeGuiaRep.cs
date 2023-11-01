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
	public class DeGuiaRep : ClaseBaseRep, IDeGuiaRep
	{
		public List<DeGuiaEnt> GetAllDeGuia(string cadenaquery)
		{
			List<DeGuiaEnt> deGuiaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspDeGuiaList, 0, cadenaquery);
				deGuiaList = GetDeGuiaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return deGuiaList;
		}
		public int? Save(ref DeGuiaEnt deGuiaEnt, string language)
		{
			int? resultado = null;
			if (deGuiaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeGuiaUpdateById, deGuiaEnt.ART_ID, deGuiaEnt.ENC_ID, deGuiaEnt.TEM_NOMB, deGuiaEnt.CANTIDAD, deGuiaEnt.PRECIO, deGuiaEnt.Predescto, deGuiaEnt.Descuento, deGuiaEnt.TEM_SUBT, deGuiaEnt.TRIAL556,  language);
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
		public int? Delete(ref DeGuiaEnt deGuiaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeGuiaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref DeGuiaEnt deGuiaEnt, string language)
		{
			int? resultado = null;
			if (deGuiaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspDeGuiaInsert, deGuiaEnt.ART_ID, deGuiaEnt.ENC_ID, deGuiaEnt.TEM_NOMB, deGuiaEnt.CANTIDAD, deGuiaEnt.PRECIO, deGuiaEnt.Predescto, deGuiaEnt.Descuento, deGuiaEnt.TEM_SUBT, deGuiaEnt.TRIAL556,  language);
                    //deGuiaEnt.ART_ID = (long) resultado;
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
		public virtual List<DeGuiaEnt> GetDeGuiaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new DeGuiaEnt { ART_ID = dataRow.Field<int>("ART_ID"), ENC_ID = dataRow.Field<string>("ENC_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<double>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), Predescto = dataRow.Field<double>("Predescto"), Descuento = dataRow.Field<double>("Descuento"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), TRIAL556 = dataRow.Field<string>("TRIAL556"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
