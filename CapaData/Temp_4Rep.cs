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
	public class Temp_4Rep : ClaseBaseRep, ITemp_4Rep
	{
		public List<Temp_4Ent> GetAllTemp_4(string cadenaquery)
		{
			List<Temp_4Ent> temp_4List = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTemp_4List, 0, cadenaquery);
				temp_4List = GetTemp_4CollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return temp_4List;
		}
		public int? Save(ref Temp_4Ent temp_4Ent, string language)
		{
			int? resultado = null;
			if (temp_4Ent != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTemp_4UpdateById, temp_4Ent.Enc_id, temp_4Ent.Cliente, temp_4Ent.Cantidad, temp_4Ent.Cli_id, temp_4Ent.Fechal, temp_4Ent.Fvencimiento, temp_4Ent.TRIAL713,  language);
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
		public int? Delete(ref Temp_4Ent temp_4Ent, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTemp_4DeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref Temp_4Ent temp_4Ent, string language)
		{
			int? resultado = null;
			if (temp_4Ent != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTemp_4Insert, temp_4Ent.Enc_id, temp_4Ent.Cliente, temp_4Ent.Cantidad, temp_4Ent.Cli_id, temp_4Ent.Fechal, temp_4Ent.Fvencimiento, temp_4Ent.TRIAL713,  language);
                    //temp_4Ent.Enc_id = (long) resultado;
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
		public virtual List<Temp_4Ent> GetTemp_4CollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new Temp_4Ent { Enc_id = dataRow.Field<string>("Enc_id"), Cliente = dataRow.Field<string>("Cliente"), Cantidad = dataRow.Field<double>("Cantidad"), Cli_id = dataRow.Field<int>("cli_id"), Fechal = dataRow.Field<DateTime>("Fechal"), Fvencimiento = dataRow.Field<DateTime>("Fvencimiento"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
