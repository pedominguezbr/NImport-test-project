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
	public class ContadoRep : ClaseBaseRep, IContadoRep
	{
		public List<ContadoEnt> GetAllContado(string cadenaquery)
		{
			List<ContadoEnt> contadoList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspContadoList, 0, cadenaquery);
				contadoList = GetContadoCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return contadoList;
		}
		public int? Save(ref ContadoEnt contadoEnt, string language)
		{
			int? resultado = null;
			if (contadoEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspContadoUpdateById, contadoEnt.Cli_id, contadoEnt.Enc_id, contadoEnt.Fecha, contadoEnt.Igv, contadoEnt.Total, contadoEnt.CtaSaldo, contadoEnt.Importe, contadoEnt.Cod_ven, contadoEnt.Vendedor, contadoEnt.CLIENTE, contadoEnt.Numletra, contadoEnt.Observa, contadoEnt.TRIAL547,  language);
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
		public int? Delete(ref ContadoEnt contadoEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspContadoDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref ContadoEnt contadoEnt, string language)
		{
			int? resultado = null;
			if (contadoEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspContadoInsert, contadoEnt.Cli_id, contadoEnt.Enc_id, contadoEnt.Fecha, contadoEnt.Igv, contadoEnt.Total, contadoEnt.CtaSaldo, contadoEnt.Importe, contadoEnt.Cod_ven, contadoEnt.Vendedor, contadoEnt.CLIENTE, contadoEnt.Numletra, contadoEnt.Observa, contadoEnt.TRIAL547,  language);
                    //contadoEnt.Cli_id = (long) resultado;
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
		public virtual List<ContadoEnt> GetContadoCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new ContadoEnt { Cli_id = dataRow.Field<int>("Cli_id"), Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), Igv = dataRow.Field<string>("Igv"), Total = dataRow.Field<double>("Total"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), Importe = dataRow.Field<double>("Importe"), Cod_ven = dataRow.Field<string>("Cod_ven"), Vendedor = dataRow.Field<string>("Vendedor"), CLIENTE = dataRow.Field<string>("CLIENTE"), Numletra = dataRow.Field<string>("Numletra"), Observa = dataRow.Field<string>("Observa"), TRIAL547 = dataRow.Field<string>("TRIAL547"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
