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
	public class RemisiónRep : ClaseBaseRep, IRemisiónRep
	{
		public List<RemisiónEnt> GetAllRemisión(string cadenaquery)
		{
			List<RemisiónEnt> remisiónList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspRemisiónList, 0, cadenaquery);
				remisiónList = GetRemisiónCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return remisiónList;
		}
		public int? Save(ref RemisiónEnt remisiónEnt, string language)
		{
			int? resultado = null;
			if (remisiónEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspRemisiónUpdateById, remisiónEnt.Cli_id, remisiónEnt.Cliente, remisiónEnt.Enc_id, remisiónEnt.Fecha, remisiónEnt.Igv, remisiónEnt.Total, remisiónEnt.Ctasaldo, remisiónEnt.Importe, remisiónEnt.Vendedor, remisiónEnt.Cod_ven, remisiónEnt.Femision, remisiónEnt.Gremision, remisiónEnt.Refact, remisiónEnt.Observa, remisiónEnt.Condición, remisiónEnt.Trans1, remisiónEnt.Trans2, remisiónEnt.Rut, remisiónEnt.Vent, remisiónEnt.Consig, remisiónEnt.TRIAL664,  language);
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
		public int? Delete(ref RemisiónEnt remisiónEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspRemisiónDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref RemisiónEnt remisiónEnt, string language)
		{
			int? resultado = null;
			if (remisiónEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspRemisiónInsert, remisiónEnt.Cli_id, remisiónEnt.Cliente, remisiónEnt.Enc_id, remisiónEnt.Fecha, remisiónEnt.Igv, remisiónEnt.Total, remisiónEnt.Ctasaldo, remisiónEnt.Importe, remisiónEnt.Vendedor, remisiónEnt.Cod_ven, remisiónEnt.Femision, remisiónEnt.Gremision, remisiónEnt.Refact, remisiónEnt.Observa, remisiónEnt.Condición, remisiónEnt.Trans1, remisiónEnt.Trans2, remisiónEnt.Rut, remisiónEnt.Vent, remisiónEnt.Consig, remisiónEnt.TRIAL664,  language);
                    //remisiónEnt.Cli_id = (long) resultado;
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
		public virtual List<RemisiónEnt> GetRemisiónCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new RemisiónEnt { Cli_id = dataRow.Field<int>("cli_id"), Cliente = dataRow.Field<string>("Cliente"), Enc_id = dataRow.Field<string>("enc_id"), Fecha = dataRow.Field<DateTime>("fecha"), Igv = dataRow.Field<string>("igv"), Total = dataRow.Field<double>("total"), Ctasaldo = dataRow.Field<double>("ctasaldo"), Importe = dataRow.Field<double>("importe"), Vendedor = dataRow.Field<string>("vendedor"), Cod_ven = dataRow.Field<string>("Cod_ven"), Femision = dataRow.Field<DateTime>("femision"), Gremision = dataRow.Field<string>("gremision"), Refact = dataRow.Field<string>("Refact"), Observa = dataRow.Field<string>("Observa"), Condición = dataRow.Field<string>("Condición"), Trans1 = dataRow.Field<string>("Trans1"), Trans2 = dataRow.Field<string>("Trans2"), Rut = dataRow.Field<string>("Rut"), Vent = dataRow.Field<string>("Vent"), Consig = dataRow.Field<string>("Consig"), TRIAL664 = dataRow.Field<string>("TRIAL664"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
