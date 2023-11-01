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
	public class CLIENRep : ClaseBaseRep, ICLIENRep
	{
		public List<CLIENEnt> GetAllCLIEN(int codigo, string nombre)
		{
			List<CLIENEnt> cLIENList = null;
			try
			{
                
                DataSet ds = ExecuteDataSet(Constantes.UspCLIENList, codigo, nombre);
				cLIENList = GetCLIENCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return cLIENList;
		}
		public int? Save(ref CLIENEnt cLIENEnt, string language)
		{
			int? resultado = null;
			if (cLIENEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCLIENUpdateById, 
                        cLIENEnt.Cli_id, 
                        cLIENEnt.CLIENTE, 
                        cLIENEnt.DESCUENTO, 
                        cLIENEnt.ENCARGADO,
                        cLIENEnt.TELEFONO, 
                        cLIENEnt.TELEF2, 
                        cLIENEnt.FAX, 
                        cLIENEnt.RUC, 
                        cLIENEnt.DIRECCION, 
                        cLIENEnt.DIR2, 
                        cLIENEnt.DISTRITO,
                        cLIENEnt.EMPIEZA,
                        cLIENEnt.LUGAR, 
                        cLIENEnt.FEMISION,
                        cLIENEnt.GREMISION, 
                        cLIENEnt.LE, 
                        cLIENEnt.REFACT,
                        cLIENEnt.E_MAIL, 
                        cLIENEnt.RPM,
                        cLIENEnt.Adicional, 
                        cLIENEnt.TRIAL547);
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
		public int? Delete(ref CLIENEnt cLIENEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspCLIENDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref CLIENEnt cLIENEnt, string language)
		{
			int? resultado = null;
			if (cLIENEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspCLIENInsert, cLIENEnt.Cli_id, cLIENEnt.CLIENTE, cLIENEnt.DESCUENTO, cLIENEnt.ENCARGADO, cLIENEnt.TELEFONO, cLIENEnt.TELEF2, cLIENEnt.FAX, cLIENEnt.RUC, cLIENEnt.DIRECCION, cLIENEnt.DIR2, cLIENEnt.DISTRITO, cLIENEnt.EMPIEZA, cLIENEnt.LUGAR, cLIENEnt.FEMISION, cLIENEnt.GREMISION, cLIENEnt.LE, cLIENEnt.REFACT, cLIENEnt.E_MAIL, cLIENEnt.RPM, cLIENEnt.Adicional, cLIENEnt.TRIAL547,  language);
                    //cLIENEnt.Cli_id = (long) resultado;
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
		public virtual List<CLIENEnt> GetCLIENCollectionFromDataSet(ref DataSet ds)
		{
			return ds.Tables[0].AsEnumerable().Select(dataRow => new 
            CLIENEnt { Cli_id = dataRow.Field<int>("Cli_id"),
                CLIENTE = dataRow.Field<string>("CLIENTE"),
                DESCUENTO = dataRow.Field<string>("DESCUENTO"), 
                ENCARGADO = dataRow.Field<string>("ENCARGADO"), 
                TELEFONO = dataRow.Field<string>("TELEFONO"),
                TELEF2 = dataRow.Field<string>("TELEF2"),
                FAX = dataRow.Field<string>("FAX"), 
                RUC = dataRow.Field<string>("RUC"),
                DIRECCION = dataRow.Field<string>("DIRECCION"), 
                DIR2 = dataRow.Field<string>("DIR2"), 
                DISTRITO = dataRow.Field<string>("DISTRITO"), 
                EMPIEZA = dataRow.Field<string>("EMPIEZA"),
                LUGAR = dataRow.Field<string>("LUGAR"),
                FEMISION = dataRow.Field<DateTime?>("FEMISION"),
                GREMISION = dataRow.Field<string>("GREMISION"), 
                LE = dataRow.Field<string>("LE"),
                REFACT = dataRow.Field<string>("REFACT"),
                E_MAIL = dataRow.Field<string>("E-MAIL"),
                RPM = dataRow.Field<string>("RPM"),
                Adicional = dataRow.Field<string>("Adicional"),
                       TRIAL547 = dataRow.Field<string>("TRIAL587")
            }).ToList();
			//throw new NotImplementedException();
		}
	}
}
