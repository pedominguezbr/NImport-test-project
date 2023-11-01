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
	public class BorraRep : ClaseBaseRep, IBorraRep
	{
		public List<BorraEnt> GetAllBorra(string cadenaquery)
		{
			List<BorraEnt> borraList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspBorraList, 0, cadenaquery);
				borraList = GetBorraCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return borraList;
		}
		public int? Save(ref BorraEnt borraEnt, string language)
		{
			int? resultado = null;
			if (borraEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspBorraUpdateById, borraEnt.Cod_ven, borraEnt.Cliente, borraEnt.Lugar, borraEnt.Direccion, borraEnt.TRIAL543,  language);
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
		public int? Delete(ref BorraEnt borraEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspBorraDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref BorraEnt borraEnt, string language)
		{
			int? resultado = null;
			if (borraEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspBorraInsert, borraEnt.Cod_ven, borraEnt.Cliente, borraEnt.Lugar, borraEnt.Direccion, borraEnt.TRIAL543,  language);
                    //borraEnt.Cod_ven = (long) resultado;
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
		public virtual List<BorraEnt> GetBorraCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new BorraEnt { Cod_ven = dataRow.Field<string>("Cod_ven"), Cliente = dataRow.Field<string>("Cliente"), Lugar = dataRow.Field<string>("Lugar"), Direccion = dataRow.Field<string>("Direccion"), TRIAL543 = dataRow.Field<string>("TRIAL543"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
