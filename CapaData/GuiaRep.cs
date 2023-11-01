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
	public class GuiaRep : ClaseBaseRep, IGuiaRep
	{
		public List<GuiaEnt> GetAllGuia(string cadenaquery)
		{
			List<GuiaEnt> guiaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspGuiaList, 0, cadenaquery);
				guiaList = GetGuiaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return guiaList;
		}
		public int? Save(ref GuiaEnt guiaEnt, string language)
		{
			int? resultado = null;
			if (guiaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspGuiaUpdateById, guiaEnt.Cli_id, guiaEnt.Cliente, guiaEnt.Enc_id, guiaEnt.Fecha, guiaEnt.Igv, guiaEnt.Total, guiaEnt.Ctasaldo, guiaEnt.Importe, guiaEnt.Vendedor, guiaEnt.Cod_ven, guiaEnt.Femision, guiaEnt.Gremision, guiaEnt.Refact, guiaEnt.Observa, guiaEnt.Condición, guiaEnt.TRIAL625,  language);
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
		public int? Delete(ref GuiaEnt guiaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspGuiaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref GuiaEnt guiaEnt, string language)
		{
			int? resultado = null;
			if (guiaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspGuiaInsert, guiaEnt.Cli_id, guiaEnt.Cliente, guiaEnt.Enc_id, guiaEnt.Fecha, guiaEnt.Igv, guiaEnt.Total, guiaEnt.Ctasaldo, guiaEnt.Importe, guiaEnt.Vendedor, guiaEnt.Cod_ven, guiaEnt.Femision, guiaEnt.Gremision, guiaEnt.Refact, guiaEnt.Observa, guiaEnt.Condición, guiaEnt.TRIAL625,  language);
                    //guiaEnt.Cli_id = (long) resultado;
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
		public virtual List<GuiaEnt> GetGuiaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new GuiaEnt { Cli_id = dataRow.Field<int>("cli_id"), Cliente = dataRow.Field<string>("Cliente"), Enc_id = dataRow.Field<string>("enc_id"), Fecha = dataRow.Field<DateTime>("fecha"), Igv = dataRow.Field<string>("igv"), Total = dataRow.Field<double>("total"), Ctasaldo = dataRow.Field<double>("ctasaldo"), Importe = dataRow.Field<double>("importe"), Vendedor = dataRow.Field<string>("vendedor"), Cod_ven = dataRow.Field<string>("Cod_ven"), Femision = dataRow.Field<DateTime>("femision"), Gremision = dataRow.Field<string>("gremision"), Refact = dataRow.Field<string>("Refact"), Observa = dataRow.Field<string>("Observa"), Condición = dataRow.Field<string>("Condición"), TRIAL625 = dataRow.Field<string>("TRIAL625"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
