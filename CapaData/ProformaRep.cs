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
	public class ProformaRep : ClaseBaseRep, IProformaRep
	{
		public List<ProformaEnt> GetAllProforma(string cadenaquery)
		{
			List<ProformaEnt> proformaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspProformaList, 0, cadenaquery);
				proformaList = GetProformaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return proformaList;
		}
		public int? Save(ref ProformaEnt proformaEnt, string language)
		{
			int? resultado = null;
			if (proformaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspProformaUpdateById, proformaEnt.Cli_id, proformaEnt.Enc_id, proformaEnt.Fecha, proformaEnt.Igv, proformaEnt.Total, proformaEnt.CtaSaldo, proformaEnt.Importe, proformaEnt.Vendedor, proformaEnt.Cod_ven, proformaEnt.Femision, proformaEnt.Gremision, proformaEnt.Condicion, proformaEnt.Forma, proformaEnt.Forma2, proformaEnt.Forma3, proformaEnt.Cliente, proformaEnt.Observa, proformaEnt.TRIAL661,  language);
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
		public int? Delete(ref ProformaEnt proformaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspProformaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref ProformaEnt proformaEnt, string language)
		{
			int? resultado = null;
			if (proformaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspProformaInsert, proformaEnt.Cli_id, proformaEnt.Enc_id, proformaEnt.Fecha, proformaEnt.Igv, proformaEnt.Total, proformaEnt.CtaSaldo, proformaEnt.Importe, proformaEnt.Vendedor, proformaEnt.Cod_ven, proformaEnt.Femision, proformaEnt.Gremision, proformaEnt.Condicion, proformaEnt.Forma, proformaEnt.Forma2, proformaEnt.Forma3, proformaEnt.Cliente, proformaEnt.Observa, proformaEnt.TRIAL661,  language);
                    //proformaEnt.Cli_id = (long) resultado;
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
		public virtual List<ProformaEnt> GetProformaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new ProformaEnt { Cli_id = dataRow.Field<int>("Cli_id"), Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), Igv = dataRow.Field<string>("Igv"), Total = dataRow.Field<double>("Total"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), Importe = dataRow.Field<double>("Importe"), Vendedor = dataRow.Field<string>("Vendedor"), Cod_ven = dataRow.Field<string>("Cod_ven"), Femision = dataRow.Field<DateTime>("Femision"), Gremision = dataRow.Field<string>("Gremision"), Condicion = dataRow.Field<string>("Condicion"), Forma = dataRow.Field<string>("Forma"), Forma2 = dataRow.Field<string>("Forma2"), Forma3 = dataRow.Field<string>("Forma3"), Cliente = dataRow.Field<string>("Cliente"), Observa = dataRow.Field<string>("Observa"), TRIAL661 = dataRow.Field<string>("TRIAL661"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
