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
	public class TletRep : ClaseBaseRep, ITletRep
	{
		public List<TletEnt> GetAllTlet(string cadenaquery)
		{
			List<TletEnt> tletList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTletList, 0, cadenaquery);
				tletList = GetTletCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tletList;
		}
		public int? Save(ref TletEnt tletEnt, string language)
		{
			int? resultado = null;
			if (tletEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTletUpdateById, tletEnt.Letras, tletEnt.TRIAL723,  language);
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
		public int? Delete(ref TletEnt tletEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTletDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TletEnt tletEnt, string language)
		{
			int? resultado = null;
			if (tletEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTletInsert, tletEnt.Letras, tletEnt.TRIAL723,  language);
                    //tletEnt.Letras = (long) resultado;
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
		public virtual List<TletEnt> GetTletCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TletEnt { Letras = dataRow.Field<string>("Letras"), TRIAL723 = dataRow.Field<string>("TRIAL723"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
