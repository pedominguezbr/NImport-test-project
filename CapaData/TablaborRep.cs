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
	public class TablaborRep : ClaseBaseRep, ITablaborRep
	{
		public List<TablaborEnt> GetAllTablabor(string cadenaquery)
		{
			List<TablaborEnt> tablaborList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTablaborList, 0, cadenaquery);
				tablaborList = GetTablaborCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tablaborList;
		}
		public int? Save(ref TablaborEnt tablaborEnt, string language)
		{
			int? resultado = null;
			if (tablaborEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTablaborUpdateById, tablaborEnt.Fecha, tablaborEnt.Total, tablaborEnt.Igv, tablaborEnt.Importe, tablaborEnt.Cli_id, tablaborEnt.Enc_id, tablaborEnt.N_Factur, tablaborEnt.F_Factur, tablaborEnt.TRIAL713,  language);
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
		public int? Delete(ref TablaborEnt tablaborEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTablaborDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TablaborEnt tablaborEnt, string language)
		{
			int? resultado = null;
			if (tablaborEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTablaborInsert, tablaborEnt.Fecha, tablaborEnt.Total, tablaborEnt.Igv, tablaborEnt.Importe, tablaborEnt.Cli_id, tablaborEnt.Enc_id, tablaborEnt.N_Factur, tablaborEnt.F_Factur, tablaborEnt.TRIAL713,  language);
                    //tablaborEnt.Fecha = (long) resultado;
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
		public virtual List<TablaborEnt> GetTablaborCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TablaborEnt { Fecha = dataRow.Field<DateTime>("Fecha"), Total = dataRow.Field<double>("Total"), Igv = dataRow.Field<double>("Igv"), Importe = dataRow.Field<double>("Importe"), Cli_id = dataRow.Field<int>("Cli_id"), Enc_id = dataRow.Field<string>("Enc_id"), N_Factur = dataRow.Field<string>("N_Factur"), F_Factur = dataRow.Field<DateTime>("F_Factur"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
