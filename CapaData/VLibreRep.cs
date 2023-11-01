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
	public class VLibreRep : ClaseBaseRep, IVLibreRep
	{
		public List<VLibreEnt> GetAllVLibre(string cadenaquery)
		{
			List<VLibreEnt> vLibreList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspVLibreList, 0, cadenaquery);
				vLibreList = GetVLibreCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return vLibreList;
		}
		public int? Save(ref VLibreEnt vLibreEnt, string language)
		{
			int? resultado = null;
			if (vLibreEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspVLibreUpdateById, vLibreEnt.Cli_id, vLibreEnt.Enc_id, vLibreEnt.Fecha, vLibreEnt.Total, vLibreEnt.CtaSaldo, vLibreEnt.Vendedor, vLibreEnt.Cod_Ven, vLibreEnt.Femision, vLibreEnt.Gremision, vLibreEnt.Cliente, vLibreEnt.Refact, vLibreEnt.Observa, vLibreEnt.Condicion, vLibreEnt.Fvencim, vLibreEnt.TRIAL726,  language);
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
		public int? Delete(ref VLibreEnt vLibreEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspVLibreDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref VLibreEnt vLibreEnt, string language)
		{
			int? resultado = null;
			if (vLibreEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspVLibreInsert,
                        vLibreEnt.Cli_id.Cli_id,
                        vLibreEnt.Enc_id, 
                        vLibreEnt.Fecha,
                        vLibreEnt.Total, 
                        vLibreEnt.CtaSaldo,
                        vLibreEnt.Vendedor,
                        vLibreEnt.Cod_Ven.Cod_Ven, 
                        vLibreEnt.Femision, 
                        vLibreEnt.Gremision,
                        vLibreEnt.Cliente,
                        vLibreEnt.Refact,
                        vLibreEnt.Observa, 
                        vLibreEnt.Condicion, 
                        vLibreEnt.Fvencim, 
                        vLibreEnt.TRIAL726
                        );
                    //vLibreEnt.Cli_id = (long) resultado;
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
		public virtual List<VLibreEnt> GetVLibreCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new VLibreEnt { Cli_id = dataRow.Field<int>("Cli_id"), Enc_id = dataRow.Field<string>("Enc_id"), Fecha = dataRow.Field<DateTime>("Fecha"), Total = dataRow.Field<double>("Total"), CtaSaldo = dataRow.Field<double>("CtaSaldo"), Vendedor = dataRow.Field<string>("Vendedor"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), Femision = dataRow.Field<DateTime>("Femision"), Gremision = dataRow.Field<string>("Gremision"), Cliente = dataRow.Field<string>("Cliente"), Refact = dataRow.Field<string>("Refact"), Observa = dataRow.Field<string>("Observa"), Condicion = dataRow.Field<string>("Condicion"), Fvencim = dataRow.Field<DateTime>("Fvencim"), TRIAL726 = dataRow.Field<string>("TRIAL726"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
