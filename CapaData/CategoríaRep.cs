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
	public class CategoríaRep : ClaseBaseRep, ICategoríaRep
	{
		public List<CategoríaEnt> GetAllCategoría(string cadenaquery)
		{
			List<CategoríaEnt> categoríaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspCategoríaList, 0, cadenaquery);
				categoríaList = GetCategoríaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return categoríaList;
		}
		public int? Save(ref CategoríaEnt categoríaEnt, string language)
		{
			int? resultado = null;
			if (categoríaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCategoríaUpdateById, categoríaEnt.Cat_Id, categoríaEnt.Lin, categoríaEnt.TRIAL543,  language);
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
		public int? Delete(ref CategoríaEnt categoríaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCategoríaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref CategoríaEnt categoríaEnt, string language)
		{
			int? resultado = null;
			if (categoríaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspCategoríaInsert, categoríaEnt.Cat_Id, categoríaEnt.Lin, categoríaEnt.TRIAL543,  language);
                    //categoríaEnt.Cat_Id = (long) resultado;
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
		public virtual List<CategoríaEnt> GetCategoríaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new CategoríaEnt { Cat_Id = dataRow.Field<int>("Cat_Id"), Lin = dataRow.Field<string>("Lin"), TRIAL543 = dataRow.Field<string>("TRIAL543"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
