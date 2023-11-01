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
	public class TablaconsultaRep : ClaseBaseRep, ITablaconsultaRep
	{
		public List<TablaconsultaEnt> GetAllTablaconsulta(string cadenaquery)
		{
			List<TablaconsultaEnt> tablaconsultaList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTablaconsultaList, 0, cadenaquery);
				tablaconsultaList = GetTablaconsultaCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tablaconsultaList;
		}
		public int? Save(ref TablaconsultaEnt tablaconsultaEnt, string language)
		{
			int? resultado = null;
			if (tablaconsultaEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTablaconsultaUpdateById, tablaconsultaEnt.Cliente, tablaconsultaEnt.Enc_Id, tablaconsultaEnt.Cod_Ven, tablaconsultaEnt.Fecha, tablaconsultaEnt.Importe, tablaconsultaEnt.Fecha1, tablaconsultaEnt.Fecha2, tablaconsultaEnt.TRIAL713,  language);
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
		public int? Delete(ref TablaconsultaEnt tablaconsultaEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTablaconsultaDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TablaconsultaEnt tablaconsultaEnt, string language)
		{
			int? resultado = null;
			if (tablaconsultaEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTablaconsultaInsert, tablaconsultaEnt.Cliente, tablaconsultaEnt.Enc_Id, tablaconsultaEnt.Cod_Ven, tablaconsultaEnt.Fecha, tablaconsultaEnt.Importe, tablaconsultaEnt.Fecha1, tablaconsultaEnt.Fecha2, tablaconsultaEnt.TRIAL713,  language);
                    //tablaconsultaEnt.Cliente = (long) resultado;
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
		public virtual List<TablaconsultaEnt> GetTablaconsultaCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TablaconsultaEnt { Cliente = dataRow.Field<string>("Cliente"), Enc_Id = dataRow.Field<string>("Enc_Id"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), Fecha = dataRow.Field<DateTime>("Fecha"), Importe = dataRow.Field<double>("Importe"), Fecha1 = dataRow.Field<DateTime>("fecha1"), Fecha2 = dataRow.Field<DateTime>("fecha2"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
