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
	public class ECanletraRep : ClaseBaseRep, IECanletraRep
	{
		public List<ECanletraEnt> GetAllECanletra(string cadenaquery)
		{
			List<ECanletraEnt> eCanletraList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspECanletraList, 0, cadenaquery);
				eCanletraList = GetECanletraCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return eCanletraList;
		}
		public int? Save(ref ECanletraEnt eCanletraEnt, string language)
		{
			int? resultado = null;
			if (eCanletraEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspECanletraUpdateById, eCanletraEnt.Enc_id, eCanletraEnt.Fecha, eCanletraEnt.CLIENTE, eCanletraEnt.CtaSaldo, eCanletraEnt.FVencimiento, eCanletraEnt.Importe, eCanletraEnt.Cli_id, eCanletraEnt.COD_VEN, eCanletraEnt.Cantidad, eCanletraEnt.Observa, eCanletraEnt.Ide_CanL, eCanletraEnt.Fpago, eCanletraEnt.Numfactura, eCanletraEnt.Procedencia, eCanletraEnt.N_Unico, eCanletraEnt.TRIAL609,  language);
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
		public int? Delete(ref ECanletraEnt eCanletraEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspECanletraDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref ECanletraEnt eCanletraEnt, string language)
		{
			int? resultado = null;
			if (eCanletraEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspECanletraInsert, eCanletraEnt.Enc_id, eCanletraEnt.Fecha, eCanletraEnt.CLIENTE, eCanletraEnt.CtaSaldo, eCanletraEnt.FVencimiento, eCanletraEnt.Importe, eCanletraEnt.Cli_id, eCanletraEnt.COD_VEN, eCanletraEnt.Cantidad, eCanletraEnt.Observa, eCanletraEnt.Ide_CanL, eCanletraEnt.Fpago, eCanletraEnt.Numfactura, eCanletraEnt.Procedencia, eCanletraEnt.N_Unico, eCanletraEnt.TRIAL609,  language);
                    //eCanletraEnt.Enc_id = (long) resultado;
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
		public virtual List<ECanletraEnt> GetECanletraCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new ECanletraEnt { Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), CLIENTE = dataRow.Field<string>("CLIENTE"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), FVencimiento = dataRow.Field<DateTime>("FVencimiento"), Importe = dataRow.Field<double>("Importe"), Cli_id = dataRow.Field<int>("Cli_id"), COD_VEN = dataRow.Field<string>("COD_VEN"), Cantidad = dataRow.Field<double>("Cantidad"), Observa = dataRow.Field<string>("Observa"), Ide_CanL = dataRow.Field<int>("Ide_CanL"), Fpago = dataRow.Field<DateTime>("Fpago"), Numfactura = dataRow.Field<string>("Numfactura"), Procedencia = dataRow.Field<string>("Procedencia"), N_Unico = dataRow.Field<string>("N_Unico"), TRIAL609 = dataRow.Field<string>("TRIAL609"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
