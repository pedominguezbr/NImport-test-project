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
	public class TablaConsulta2Rep : ClaseBaseRep, ITablaConsulta2Rep
	{
		public List<TablaConsulta2Ent> GetAllTablaConsulta2(string cadenaquery)
		{
			List<TablaConsulta2Ent> tablaConsulta2List = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTablaConsulta2List, 0, cadenaquery);
				tablaConsulta2List = GetTablaConsulta2CollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tablaConsulta2List;
		}
		public int? Save(ref TablaConsulta2Ent tablaConsulta2Ent, string language)
		{
			int? resultado = null;
			if (tablaConsulta2Ent != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTablaConsulta2UpdateById, tablaConsulta2Ent.Proveedor, tablaConsulta2Ent.Enc_Id, tablaConsulta2Ent.Fecha, tablaConsulta2Ent.Total, tablaConsulta2Ent.TRIAL713,  language);
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
		public int? Delete(ref TablaConsulta2Ent tablaConsulta2Ent, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTablaConsulta2DeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TablaConsulta2Ent tablaConsulta2Ent, string language)
		{
			int? resultado = null;
			if (tablaConsulta2Ent != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTablaConsulta2Insert, tablaConsulta2Ent.Proveedor, tablaConsulta2Ent.Enc_Id, tablaConsulta2Ent.Fecha, tablaConsulta2Ent.Total, tablaConsulta2Ent.TRIAL713,  language);
                    //tablaConsulta2Ent.Proveedor = (long) resultado;
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
		public virtual List<TablaConsulta2Ent> GetTablaConsulta2CollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TablaConsulta2Ent { Proveedor = dataRow.Field<string>("Proveedor"), Enc_Id = dataRow.Field<string>("Enc_Id"), Fecha = dataRow.Field<DateTime>("Fecha"), Total = dataRow.Field<double>("Total"), TRIAL713 = dataRow.Field<string>("TRIAL713"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
