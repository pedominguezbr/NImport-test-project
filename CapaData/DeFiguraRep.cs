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
	public class DeFiguraRep : ClaseBaseRep, IDeFiguraRep
	{
		public List<DeFiguraEnt> GetAllDeFigura(string cadenaquery)
		{
			List<DeFiguraEnt> deFiguraList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspDeFiguraList, 0, cadenaquery);
				deFiguraList = GetDeFiguraCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return deFiguraList;
		}
		public int? Save(ref DeFiguraEnt deFiguraEnt, string language)
		{
			int? resultado = null;
			if (deFiguraEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeFiguraUpdateById, deFiguraEnt.ART_ID, deFiguraEnt.ENC_ID, deFiguraEnt.TEM_NOMB, deFiguraEnt.CANTIDAD, deFiguraEnt.PRECIO, deFiguraEnt.Predescto, deFiguraEnt.Descuento, deFiguraEnt.TEM_SUBT, deFiguraEnt.TRIAL556,  language);
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
		public int? Delete(ref DeFiguraEnt deFiguraEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeFiguraDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref DeFiguraEnt deFiguraEnt, string language)
		{
			int? resultado = null;
			if (deFiguraEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspDeFiguraInsert, deFiguraEnt.ART_ID, deFiguraEnt.ENC_ID, deFiguraEnt.TEM_NOMB, deFiguraEnt.CANTIDAD, deFiguraEnt.PRECIO, deFiguraEnt.Predescto, deFiguraEnt.Descuento, deFiguraEnt.TEM_SUBT, deFiguraEnt.TRIAL556,  language);
                    //deFiguraEnt.ART_ID = (long) resultado;
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
		public virtual List<DeFiguraEnt> GetDeFiguraCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new DeFiguraEnt { ART_ID = dataRow.Field<int>("ART_ID"), ENC_ID = dataRow.Field<string>("ENC_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<double>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), Predescto = dataRow.Field<double>("Predescto"), Descuento = dataRow.Field<double>("Descuento"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), TRIAL556 = dataRow.Field<string>("TRIAL556"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
