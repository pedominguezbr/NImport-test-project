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
	public class Temp_2Rep : ClaseBaseRep, ITemp_2Rep
	{
		public List<Temp_2Ent> GetAllTemp_2(string cadenaquery)
		{
			List<Temp_2Ent> temp_2List = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTemp_2List, 0, cadenaquery);
				temp_2List = GetTemp_2CollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return temp_2List;
		}
		public int? Save(ref Temp_2Ent temp_2Ent, string language)
		{
			int? resultado = null;
			if (temp_2Ent != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTemp_2UpdateById, temp_2Ent.ART_ID, temp_2Ent.ENC_ID, temp_2Ent.TEM_NOMB, temp_2Ent.CANTIDAD, temp_2Ent.PRECIO, temp_2Ent.Predescto, temp_2Ent.Descuento, temp_2Ent.TEM_SUBT, temp_2Ent.Fecha, temp_2Ent.Cli_Id, temp_2Ent.Cod_Ven, temp_2Ent.TRIAL713,  language);
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
		public int? Delete(ref Temp_2Ent temp_2Ent, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTemp_2DeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref Temp_2Ent temp_2Ent, string language)
		{
			int? resultado = null;
			if (temp_2Ent != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTemp_2Insert, temp_2Ent.ART_ID, temp_2Ent.ENC_ID, temp_2Ent.TEM_NOMB, temp_2Ent.CANTIDAD, temp_2Ent.PRECIO, temp_2Ent.Predescto, temp_2Ent.Descuento, temp_2Ent.TEM_SUBT, temp_2Ent.Fecha, temp_2Ent.Cli_Id, temp_2Ent.Cod_Ven, temp_2Ent.TRIAL713,  language);
                    //temp_2Ent.ART_ID = (long) resultado;
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
		public virtual List<Temp_2Ent> GetTemp_2CollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new Temp_2Ent { ART_ID = dataRow.Field<int>("ART_ID"), ENC_ID = dataRow.Field<string>("ENC_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<double>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), Predescto = dataRow.Field<double>("Predescto"), Descuento = dataRow.Field<double>("Descuento"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), Fecha = dataRow.Field<DateTime>("Fecha"), Cli_Id = dataRow.Field<int>("Cli_Id"), Cod_Ven = dataRow.Field<int>("Cod_Ven"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
