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
	public class Tabla1Rep : ClaseBaseRep, ITabla1Rep
	{
		public List<Tabla1Ent> GetAllTabla1(string cadenaquery)
		{
			List<Tabla1Ent> tabla1List = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTabla1List, 0, cadenaquery);
				tabla1List = GetTabla1CollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tabla1List;
		}
		public int? Save(ref Tabla1Ent tabla1Ent, string language)
		{
			int? resultado = null;
			if (tabla1Ent != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTabla1UpdateById, tabla1Ent.ART_ID, tabla1Ent.ENC_ID, tabla1Ent.TEM_NOMB, tabla1Ent.CANTIDAD, tabla1Ent.PRECIO, tabla1Ent.Predescto, tabla1Ent.Descuento, tabla1Ent.TEM_SUBT, tabla1Ent.TRIAL713,  language);
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
		public int? Delete(ref Tabla1Ent tabla1Ent, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTabla1DeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref Tabla1Ent tabla1Ent, string language)
		{
			int? resultado = null;
			if (tabla1Ent != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTabla1Insert, tabla1Ent.ART_ID, tabla1Ent.ENC_ID, tabla1Ent.TEM_NOMB, tabla1Ent.CANTIDAD, tabla1Ent.PRECIO, tabla1Ent.Predescto, tabla1Ent.Descuento, tabla1Ent.TEM_SUBT, tabla1Ent.TRIAL713,  language);
                    //tabla1Ent.ART_ID = (long) resultado;
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
		public virtual List<Tabla1Ent> GetTabla1CollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new Tabla1Ent { ART_ID = dataRow.Field<int>("ART_ID"), ENC_ID = dataRow.Field<string>("ENC_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<double>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), Predescto = dataRow.Field<double>("Predescto"), Descuento = dataRow.Field<double>("Descuento"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
