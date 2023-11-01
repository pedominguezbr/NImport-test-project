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
	public class MovimientoRep : ClaseBaseRep, IMovimientoRep
	{
		public List<MovimientoEnt> GetAllMovimiento(string cadenaquery)
		{
			List<MovimientoEnt> movimientoList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspMovimientoList, 0, cadenaquery);
				movimientoList = GetMovimientoCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return movimientoList;
		}
		public int? Save(ref MovimientoEnt movimientoEnt, string language)
		{
			int? resultado = null;
			if (movimientoEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspMovimientoUpdateById,
                        movimientoEnt.ART_ID.ART_ID,
                        movimientoEnt.ENC_ID,
                        movimientoEnt.CANTIDAD, 
                        movimientoEnt.FECHA,
                        movimientoEnt.Cli_Id.Cli_id,
                        movimientoEnt.Cod_ven.Cod_Ven);
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
		public int? Delete(ref MovimientoEnt movimientoEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspMovimientoDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref MovimientoEnt movimientoEnt, string language)
		{
			int? resultado = null;
			if (movimientoEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspMovimientoInsert,
                        movimientoEnt.ART_ID.ART_ID,
                        movimientoEnt.ENC_ID,
                        movimientoEnt.CANTIDAD, 
                        movimientoEnt.FECHA,
                        movimientoEnt.Cli_Id.Cli_id,
                        movimientoEnt.Cod_ven.Cod_Ven);
                    //movimientoEnt.ART_ID = (long) resultado;
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
		public virtual List<MovimientoEnt> GetMovimientoCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new MovimientoEnt { ART_ID = dataRow.Field<int>("ART_ID"), ENC_ID = dataRow.Field<string>("ENC_ID"), CANTIDAD = dataRow.Field<double>("CANTIDAD"), FECHA = dataRow.Field<DateTime>("FECHA"), Cli_Id = dataRow.Field<int>("Cli_Id"), Cod_ven = dataRow.Field<string>("Cod_ven"), TRIAL628 = dataRow.Field<string>("TRIAL628"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
