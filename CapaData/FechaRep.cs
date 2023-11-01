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
	public class FechaRep : ClaseBaseRep, IFechaRep
	{
		public List<FechaEnt> GetAllFecha(string cadenaquery)
		{
			List<FechaEnt> fechaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspFechaList, 0, cadenaquery);
				fechaList = GetFechaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return fechaList;
		}
		public int? Save(ref FechaEnt fechaEnt, string language)
		{
			int? resultado = null;
			if (fechaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspFechaUpdateById, fechaEnt.Fecha1, fechaEnt.Fecha2, fechaEnt.TRIAL625,  language);
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
		public int? Delete(ref FechaEnt fechaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspFechaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref FechaEnt fechaEnt, string language)
		{
			int? resultado = null;
			if (fechaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspFechaInsert, fechaEnt.Fecha1, fechaEnt.Fecha2, fechaEnt.TRIAL625,  language);
                    //fechaEnt.Fecha1 = (long) resultado;
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
		public virtual List<FechaEnt> GetFechaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new FechaEnt { Fecha1 = dataRow.Field<DateTime>("Fecha1"), Fecha2 = dataRow.Field<DateTime>("Fecha2"), TRIAL625 = dataRow.Field<string>("TRIAL625"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
