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
	public class FACTENTREFECHARep : ClaseBaseRep, IFACTENTREFECHARep
	{
		public List<FACTENTREFECHAEnt> GetAllFACTENTREFECHA(string cadenaquery)
		{
			List<FACTENTREFECHAEnt> fACTENTREFECHAList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspFACTENTREFECHAList, 0, cadenaquery);
				fACTENTREFECHAList = GetFACTENTREFECHACollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return fACTENTREFECHAList;
		}
		public int? Save(ref FACTENTREFECHAEnt fACTENTREFECHAEnt, string language)
		{
			int? resultado = null;
			if (fACTENTREFECHAEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspFACTENTREFECHAUpdateById, fACTENTREFECHAEnt.Enc_id, fACTENTREFECHAEnt.Fecha, fACTENTREFECHAEnt.TRIAL609,  language);
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
		public int? Delete(ref FACTENTREFECHAEnt fACTENTREFECHAEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspFACTENTREFECHADeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref FACTENTREFECHAEnt fACTENTREFECHAEnt, string language)
		{
			int? resultado = null;
			if (fACTENTREFECHAEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspFACTENTREFECHAInsert, fACTENTREFECHAEnt.Enc_id, fACTENTREFECHAEnt.Fecha, fACTENTREFECHAEnt.TRIAL609,  language);
                    //fACTENTREFECHAEnt.Enc_id = (long) resultado;
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
		public virtual List<FACTENTREFECHAEnt> GetFACTENTREFECHACollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new FACTENTREFECHAEnt { Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), TRIAL609 = dataRow.Field<string>("TRIAL609"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
