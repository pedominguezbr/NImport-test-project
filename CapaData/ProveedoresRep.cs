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
	public class ProveedoresRep : ClaseBaseRep, IProveedoresRep
	{
		public List<ProveedoresEnt> GetAllProveedores(string cadenaquery)
		{
			List<ProveedoresEnt> proveedoresList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspProveedoresList, 0, cadenaquery);
				proveedoresList = GetProveedoresCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return proveedoresList;
		}
		public int? Save(ref ProveedoresEnt proveedoresEnt, string language)
		{
			int? resultado = null;
			if (proveedoresEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspProveedoresUpdateById, proveedoresEnt.Prov_id, proveedoresEnt.Proveedor, proveedoresEnt.ENCARGADO, proveedoresEnt.TELEFONO, proveedoresEnt.Telef2, proveedoresEnt.FAX, proveedoresEnt.RUC, proveedoresEnt.DIRECCION, proveedoresEnt.DIR2, proveedoresEnt.DISTRITO, proveedoresEnt.EMAIL, proveedoresEnt.EMAIL2, proveedoresEnt.TRIAL664,  language);
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
		public int? Delete(ref ProveedoresEnt proveedoresEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspProveedoresDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref ProveedoresEnt proveedoresEnt, string language)
		{
			int? resultado = null;
			if (proveedoresEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspProveedoresInsert, proveedoresEnt.Prov_id, proveedoresEnt.Proveedor, proveedoresEnt.ENCARGADO, proveedoresEnt.TELEFONO, proveedoresEnt.Telef2, proveedoresEnt.FAX, proveedoresEnt.RUC, proveedoresEnt.DIRECCION, proveedoresEnt.DIR2, proveedoresEnt.DISTRITO, proveedoresEnt.EMAIL, proveedoresEnt.EMAIL2, proveedoresEnt.TRIAL664,  language);
                    //proveedoresEnt.Prov_id = (long) resultado;
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
		public virtual List<ProveedoresEnt> GetProveedoresCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new ProveedoresEnt { Prov_id = dataRow.Field<int>("Prov_id"), Proveedor = dataRow.Field<string>("Proveedor"), ENCARGADO = dataRow.Field<string>("ENCARGADO"), TELEFONO = dataRow.Field<string>("TELEFONO"), Telef2 = dataRow.Field<string>("Telef2"), FAX = dataRow.Field<string>("FAX"), RUC = dataRow.Field<string>("RUC"), DIRECCION = dataRow.Field<string>("DIRECCION"), DIR2 = dataRow.Field<string>("DIR2"), DISTRITO = dataRow.Field<string>("DISTRITO"), EMAIL = dataRow.Field<string>("EMAIL"), EMAIL2 = dataRow.Field<string>("EMAIL2"), TRIAL664 = dataRow.Field<string>("TRIAL664"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
