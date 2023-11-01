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
	public class TEMPORALRep : ClaseBaseRep, ITEMPORALRep
	{
		public List<TEMPORALEnt> GetAllTEMPORAL(string cadenaquery)
		{
			List<TEMPORALEnt> tEMPORALList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTEMPORALList, 0, cadenaquery);
				tEMPORALList = GetTEMPORALCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tEMPORALList;
		}
		public int? Save(ref TEMPORALEnt tEMPORALEnt, string language)
		{
			int? resultado = null;
			if (tEMPORALEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTEMPORALUpdateById, tEMPORALEnt.ENC_ID, tEMPORALEnt.ART_ID, tEMPORALEnt.TEM_NOMB, tEMPORALEnt.CANTIDAD, tEMPORALEnt.PRECIO, tEMPORALEnt.PRECIO2, tEMPORALEnt.DESCUENTO, tEMPORALEnt.Predescto, tEMPORALEnt.IGV, tEMPORALEnt.TEM_SUBT, tEMPORALEnt.FECHA, tEMPORALEnt.Cli_Id, tEMPORALEnt.Cod_Ven, tEMPORALEnt.TRIAL716,  language);
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
		public int? Delete(ref TEMPORALEnt tEMPORALEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTEMPORALDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TEMPORALEnt tEMPORALEnt, string language)
		{
			int? resultado = null;
			if (tEMPORALEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTEMPORALInsert, tEMPORALEnt.ENC_ID, tEMPORALEnt.ART_ID, tEMPORALEnt.TEM_NOMB, tEMPORALEnt.CANTIDAD, tEMPORALEnt.PRECIO, tEMPORALEnt.PRECIO2, tEMPORALEnt.DESCUENTO, tEMPORALEnt.Predescto, tEMPORALEnt.IGV, tEMPORALEnt.TEM_SUBT, tEMPORALEnt.FECHA, tEMPORALEnt.Cli_Id, tEMPORALEnt.Cod_Ven, tEMPORALEnt.TRIAL716,  language);
                    //tEMPORALEnt.ENC_ID = (long) resultado;
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
		public virtual List<TEMPORALEnt> GetTEMPORALCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TEMPORALEnt { ENC_ID = dataRow.Field<string>("ENC_ID"), ART_ID = dataRow.Field<int>("ART_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<int>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), PRECIO2 = dataRow.Field<double>("PRECIO2"), DESCUENTO = dataRow.Field<double>("DESCUENTO"), Predescto = dataRow.Field<double>("Predescto"), IGV = dataRow.Field<double>("IGV"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), FECHA = dataRow.Field<DateTime>("FECHA"), Cli_Id = dataRow.Field<int>("Cli_Id"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), TRIAL716 = dataRow.Field<string>("TRIAL716"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
