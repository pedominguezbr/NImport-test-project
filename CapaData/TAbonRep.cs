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
	public class TAbonRep : ClaseBaseRep, ITAbonRep
	{
		public List<TAbonEnt> GetAllTAbon(string cadenaquery)
		{
			List<TAbonEnt> tAbonList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTAbonList, 0, cadenaquery);
				tAbonList = GetTAbonCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tAbonList;
		}
		public int? Save(ref TAbonEnt tAbonEnt, string language)
		{
			int? resultado = null;
			if (tAbonEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTAbonUpdateById, tAbonEnt.Enc_Id, tAbonEnt.Fecha, tAbonEnt.Total, tAbonEnt.Igv, tAbonEnt.Importe, tAbonEnt.Cli_ID, tAbonEnt.N_Factur, tAbonEnt.F_Factur, tAbonEnt.Fech1, tAbonEnt.Fech2, tAbonEnt.TRIAL713,  language);
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
		public int? Delete(ref TAbonEnt tAbonEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTAbonDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TAbonEnt tAbonEnt, string language)
		{
			int? resultado = null;
			if (tAbonEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTAbonInsert, tAbonEnt.Enc_Id, tAbonEnt.Fecha, tAbonEnt.Total, tAbonEnt.Igv, tAbonEnt.Importe, tAbonEnt.Cli_ID, tAbonEnt.N_Factur, tAbonEnt.F_Factur, tAbonEnt.Fech1, tAbonEnt.Fech2, tAbonEnt.TRIAL713,  language);
                    //tAbonEnt.Enc_Id = (long) resultado;
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
		public virtual List<TAbonEnt> GetTAbonCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TAbonEnt { Enc_Id = dataRow.Field<string>("Enc_Id"), Fecha = dataRow.Field<DateTime>("Fecha"), Total = dataRow.Field<double>("Total"), Igv = dataRow.Field<double>("Igv"), Importe = dataRow.Field<double>("Importe"), Cli_ID = dataRow.Field<int>("Cli_ID"), N_Factur = dataRow.Field<string>("N_Factur"), F_Factur = dataRow.Field<DateTime>("F_Factur"), Fech1 = dataRow.Field<DateTime>("Fech1"), Fech2 = dataRow.Field<DateTime>("Fech2"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
