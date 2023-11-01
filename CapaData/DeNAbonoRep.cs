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
	public class DeNAbonoRep : ClaseBaseRep, IDeNAbonoRep
	{
		public List<DeNAbonoEnt> GetAllDeNAbono(string cadenaquery)
		{
			List<DeNAbonoEnt> deNAbonoList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspDeNAbonoList, 0, cadenaquery);
				deNAbonoList = GetDeNAbonoCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return deNAbonoList;
		}
		public int? Save(ref DeNAbonoEnt deNAbonoEnt, string language)
		{
			int? resultado = null;
			if (deNAbonoEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeNAbonoUpdateById, deNAbonoEnt.ART_ID, deNAbonoEnt.ENC_ID, deNAbonoEnt.TEM_NOMB, deNAbonoEnt.CANTIDAD, deNAbonoEnt.PRECIO, deNAbonoEnt.Predescto, deNAbonoEnt.Descuento, deNAbonoEnt.TEM_SUBT, deNAbonoEnt.TRIAL560,  language);
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
		public int? Delete(ref DeNAbonoEnt deNAbonoEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeNAbonoDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref DeNAbonoEnt deNAbonoEnt, string language)
		{
			int? resultado = null;
			if (deNAbonoEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspDeNAbonoInsert, deNAbonoEnt.ART_ID, deNAbonoEnt.ENC_ID, deNAbonoEnt.TEM_NOMB, deNAbonoEnt.CANTIDAD, deNAbonoEnt.PRECIO, deNAbonoEnt.Predescto, deNAbonoEnt.Descuento, deNAbonoEnt.TEM_SUBT, deNAbonoEnt.TRIAL560,  language);
                    //deNAbonoEnt.ART_ID = (long) resultado;
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
		public virtual List<DeNAbonoEnt> GetDeNAbonoCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new DeNAbonoEnt { ART_ID = dataRow.Field<int>("ART_ID"), ENC_ID = dataRow.Field<string>("ENC_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<double>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), Predescto = dataRow.Field<double>("Predescto"), Descuento = dataRow.Field<double>("Descuento"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), TRIAL560 = dataRow.Field<string>("TRIAL560"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
