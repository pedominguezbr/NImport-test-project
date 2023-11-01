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
	public class TMarcaRep : ClaseBaseRep, ITMarcaRep
	{
		public List<TMarcaEnt> GetAllTMarca(string cadenaquery)
		{
			List<TMarcaEnt> tMarcaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTMarcaList, 0, cadenaquery);
				tMarcaList = GetTMarcaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tMarcaList;
		}
		public int? Save(ref TMarcaEnt tMarcaEnt, string language)
		{
			int? resultado = null;
			if (tMarcaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTMarcaUpdateById, tMarcaEnt.Codigo, tMarcaEnt.Fecha, tMarcaEnt.Marca, tMarcaEnt.Importe, tMarcaEnt.Fecha1, tMarcaEnt.Fecha2, tMarcaEnt.TRIAL726,  language);
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
		public int? Delete(ref TMarcaEnt tMarcaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTMarcaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TMarcaEnt tMarcaEnt, string language)
		{
			int? resultado = null;
			if (tMarcaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTMarcaInsert, tMarcaEnt.Codigo, tMarcaEnt.Fecha, tMarcaEnt.Marca, tMarcaEnt.Importe, tMarcaEnt.Fecha1, tMarcaEnt.Fecha2, tMarcaEnt.TRIAL726,  language);
                    //tMarcaEnt.Codigo = (long) resultado;
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
		public virtual List<TMarcaEnt> GetTMarcaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TMarcaEnt { Codigo = dataRow.Field<string>("Codigo"), Fecha = dataRow.Field<DateTime>("Fecha"), Marca = dataRow.Field<string>("Marca"), Importe = dataRow.Field<double>("Importe"), Fecha1 = dataRow.Field<DateTime>("Fecha1"), Fecha2 = dataRow.Field<DateTime>("Fecha2"), TRIAL726 = dataRow.Field<string>("TRIAL726"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
