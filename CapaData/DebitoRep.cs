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
	public class DebitoRep : ClaseBaseRep, IDebitoRep
	{
		public List<DebitoEnt> GetAllDebito(string cadenaquery)
		{
			List<DebitoEnt> debitoList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspDebitoList, 0, cadenaquery);
				debitoList = GetDebitoCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return debitoList;
		}
		public int? Save(ref DebitoEnt debitoEnt, string language)
		{
			int? resultado = null;
			if (debitoEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDebitoUpdateById, debitoEnt.Enc_Id, debitoEnt.Fecha, debitoEnt.Cli_Id, debitoEnt.Ruc, debitoEnt.Doc, debitoEnt.Fech, debitoEnt.Observa, debitoEnt.Cant, debitoEnt.Precio, debitoEnt.Importe, debitoEnt.Igv, debitoEnt.Total, debitoEnt.Cliente, debitoEnt.Direccion, debitoEnt.Dir2, debitoEnt.TRIAL556,  language);
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
		public int? Delete(ref DebitoEnt debitoEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDebitoDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref DebitoEnt debitoEnt, string language)
		{
			int? resultado = null;
			if (debitoEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspDebitoInsert, debitoEnt.Enc_Id, debitoEnt.Fecha, debitoEnt.Cli_Id, debitoEnt.Ruc, debitoEnt.Doc, debitoEnt.Fech, debitoEnt.Observa, debitoEnt.Cant, debitoEnt.Precio, debitoEnt.Importe, debitoEnt.Igv, debitoEnt.Total, debitoEnt.Cliente, debitoEnt.Direccion, debitoEnt.Dir2, debitoEnt.TRIAL556,  language);
                    //debitoEnt.Enc_Id = (long) resultado;
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
		public virtual List<DebitoEnt> GetDebitoCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new DebitoEnt { Enc_Id = dataRow.Field<string>("Enc_Id"), Fecha = dataRow.Field<DateTime>("Fecha"), Cli_Id = dataRow.Field<int>("Cli_Id"), Ruc = dataRow.Field<string>("Ruc"), Doc = dataRow.Field<string>("Doc"), Fech = dataRow.Field<DateTime>("Fech"), Observa = dataRow.Field<string>("Observa"), Cant = dataRow.Field<double>("Cant"), Precio = dataRow.Field<double>("Precio"), Importe = dataRow.Field<double>("Importe"), Igv = dataRow.Field<double>("Igv"), Total = dataRow.Field<double>("Total"), Cliente = dataRow.Field<string>("Cliente"), Direccion = dataRow.Field<string>("Direccion"), Dir2 = dataRow.Field<string>("Dir2"), TRIAL556 = dataRow.Field<string>("TRIAL556"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
