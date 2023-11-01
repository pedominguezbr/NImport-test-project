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
	public class FactpendRep : ClaseBaseRep, IFactpendRep
	{
		public List<FactpendEnt> GetAllFactpend(string cadenaquery)
		{
			List<FactpendEnt> factpendList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspFactpendList, 0, cadenaquery);
				factpendList = GetFactpendCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return factpendList;
		}
		public int? Save(ref FactpendEnt factpendEnt, string language)
		{
			int? resultado = null;
			if (factpendEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspFactpendUpdateById, factpendEnt.Cli_id, factpendEnt.Enc_id, factpendEnt.Fecha, factpendEnt.Igv, factpendEnt.Total, factpendEnt.CtaSaldo, factpendEnt.Importe, factpendEnt.Cod_ven, factpendEnt.Vendedor, factpendEnt.Femision, factpendEnt.Gremision, factpendEnt.Refact, factpendEnt.CLIENTE, factpendEnt.Numletra, factpendEnt.TRIAL609,  language);
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
		public int? Delete(ref FactpendEnt factpendEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspFactpendDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref FactpendEnt factpendEnt, string language)
		{
			int? resultado = null;
			if (factpendEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspFactpendInsert, factpendEnt.Cli_id, factpendEnt.Enc_id, factpendEnt.Fecha, factpendEnt.Igv, factpendEnt.Total, factpendEnt.CtaSaldo, factpendEnt.Importe, factpendEnt.Cod_ven, factpendEnt.Vendedor, factpendEnt.Femision, factpendEnt.Gremision, factpendEnt.Refact, factpendEnt.CLIENTE, factpendEnt.Numletra, factpendEnt.TRIAL609,  language);
                    //factpendEnt.Cli_id = (long) resultado;
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
		public virtual List<FactpendEnt> GetFactpendCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new FactpendEnt { Cli_id = dataRow.Field<int>("Cli_id"), Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), Igv = dataRow.Field<string>("Igv"), Total = dataRow.Field<double>("Total"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), Importe = dataRow.Field<double>("Importe"), Cod_ven = dataRow.Field<string>("Cod_ven"), Vendedor = dataRow.Field<string>("Vendedor"), Femision = dataRow.Field<DateTime>("Femision"), Gremision = dataRow.Field<string>("Gremision"), Refact = dataRow.Field<string>("Refact"), CLIENTE = dataRow.Field<string>("CLIENTE"), Numletra = dataRow.Field<string>("Numletra"), TRIAL609 = dataRow.Field<string>("TRIAL609"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
