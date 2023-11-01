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
	public class TEMPRep : ClaseBaseRep, ITEMPRep
	{
		public List<TEMPEnt> GetAllTEMP(string cadenaquery)
		{
			List<TEMPEnt> tEMPList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTEMPList, 0, cadenaquery);
				tEMPList = GetTEMPCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tEMPList;
		}
		public int? Save(ref TEMPEnt tEMPEnt, string language)
		{
			int? resultado = null;
			if (tEMPEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTEMPUpdateById, tEMPEnt.LETRAS, tEMPEnt.TRIAL713,  language);
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
		public int? Delete(ref TEMPEnt tEMPEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTEMPDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TEMPEnt tEMPEnt, string language)
		{
			int? resultado = null;
			if (tEMPEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTEMPInsert, tEMPEnt.LETRAS, tEMPEnt.TRIAL713,  language);
                    //tEMPEnt.LETRAS = (long) resultado;
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
		public virtual List<TEMPEnt> GetTEMPCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TEMPEnt { LETRAS = dataRow.Field<string>("LETRAS"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
