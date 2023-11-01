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
	public class TransporteRep : ClaseBaseRep, ITransporteRep
	{
		public List<TransporteEnt> GetAllTransporte(string cadenaquery)
		{
			List<TransporteEnt> transporteList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTransporteList, 0, cadenaquery);
				transporteList = GetTransporteCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return transporteList;
		}
		public int? Save(ref TransporteEnt transporteEnt, string language)
		{
			int? resultado = null;
			if (transporteEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTransporteUpdateById, transporteEnt.Cod_Tr, transporteEnt.Nombre, transporteEnt.Nomb2, transporteEnt.TELEFONO, transporteEnt.TELEF2, transporteEnt.RUC, transporteEnt.DIRECCION, transporteEnt.DISTRITO, transporteEnt.Nomb3, transporteEnt.Observa, transporteEnt.TRIAL726,  language);
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
		public int? Delete(ref TransporteEnt transporteEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTransporteDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TransporteEnt transporteEnt, string language)
		{
			int? resultado = null;
			if (transporteEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTransporteInsert, transporteEnt.Cod_Tr, transporteEnt.Nombre, transporteEnt.Nomb2, transporteEnt.TELEFONO, transporteEnt.TELEF2, transporteEnt.RUC, transporteEnt.DIRECCION, transporteEnt.DISTRITO, transporteEnt.Nomb3, transporteEnt.Observa, transporteEnt.TRIAL726,  language);
                    //transporteEnt.Cod_Tr = (long) resultado;
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
		public virtual List<TransporteEnt> GetTransporteCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TransporteEnt { Cod_Tr = dataRow.Field<int>("Cod_Tr"), Nombre = dataRow.Field<string>("Nombre"), Nomb2 = dataRow.Field<string>("Nomb2"), TELEFONO = dataRow.Field<string>("TELEFONO"), TELEF2 = dataRow.Field<string>("TELEF2"), RUC = dataRow.Field<string>("RUC"), DIRECCION = dataRow.Field<string>("DIRECCION"), DISTRITO = dataRow.Field<string>("DISTRITO"), Nomb3 = dataRow.Field<string>("Nomb3"), Observa = dataRow.Field<string>("Observa"), TRIAL726 = dataRow.Field<string>("TRIAL726"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
