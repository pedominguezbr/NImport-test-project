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
	public class CuentaRep : ClaseBaseRep, ICuentaRep
	{
		public List<CuentaEnt> GetAllCuenta(string cadenaquery)
		{
			List<CuentaEnt> cuentaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspCuentaList, 0, cadenaquery);
				cuentaList = GetCuentaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return cuentaList;
		}
		public int? Save(ref CuentaEnt cuentaEnt, string language)
		{
			int? resultado = null;
			if (cuentaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCuentaUpdateById, cuentaEnt.Enc_Id, cuentaEnt.Cliente, cuentaEnt.Fecha, cuentaEnt.FVencimto, cuentaEnt.Cargo, cuentaEnt.Abono, cuentaEnt.Saldo, cuentaEnt.Observa, cuentaEnt.Id_Cta, cuentaEnt.Cli_Id, cuentaEnt.Cod_Ven, cuentaEnt.Vendedor, cuentaEnt.TRIAL550,  language);
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
		public int? Delete(ref CuentaEnt cuentaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCuentaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref CuentaEnt cuentaEnt, string language)
		{
			int? resultado = null;
			if (cuentaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspCuentaInsert, cuentaEnt.Enc_Id, cuentaEnt.Cliente, cuentaEnt.Fecha, cuentaEnt.FVencimto, cuentaEnt.Cargo, cuentaEnt.Abono, cuentaEnt.Saldo, cuentaEnt.Observa, cuentaEnt.Id_Cta, cuentaEnt.Cli_Id, cuentaEnt.Cod_Ven, cuentaEnt.Vendedor, cuentaEnt.TRIAL550,  language);
                    //cuentaEnt.Enc_Id = (long) resultado;
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
		public virtual List<CuentaEnt> GetCuentaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new CuentaEnt { Enc_Id = dataRow.Field<string>("Enc_Id"), Cliente = dataRow.Field<string>("Cliente"), Fecha = dataRow.Field<DateTime>("Fecha"), FVencimto = dataRow.Field<DateTime>("FVencimto"), Cargo = dataRow.Field<double>("Cargo"), Abono = dataRow.Field<double>("Abono"), Saldo = dataRow.Field<double>("Saldo"), Observa = dataRow.Field<string>("Observa"), Id_Cta = dataRow.Field<int>("Id_Cta"), Cli_Id = dataRow.Field<int>("Cli_Id"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), Vendedor = dataRow.Field<string>("Vendedor"), TRIAL550 = dataRow.Field<string>("TRIAL550"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
