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
	public class BorracliproRep : ClaseBaseRep, IBorracliproRep
	{
		public List<BorracliproEnt> GetAllBorraclipro(string cadenaquery)
		{
			List<BorracliproEnt> borracliproList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspBorracliproList, 0, cadenaquery);
				borracliproList = GetBorracliproCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return borracliproList;
		}
		public int? Save(ref BorracliproEnt borracliproEnt, string language)
		{
			int? resultado = null;
			if (borracliproEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspBorracliproUpdateById, borracliproEnt.Nombre, borracliproEnt.Cantidad, borracliproEnt.Cliente, borracliproEnt.Fi, borracliproEnt.FF, borracliproEnt.TRIAL543,  language);
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
		public int? Delete(ref BorracliproEnt borracliproEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspBorracliproDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref BorracliproEnt borracliproEnt, string language)
		{
			int? resultado = null;
			if (borracliproEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspBorracliproInsert, borracliproEnt.Nombre, borracliproEnt.Cantidad, borracliproEnt.Cliente, borracliproEnt.Fi, borracliproEnt.FF, borracliproEnt.TRIAL543,  language);
                    //borracliproEnt.Nombre = (long) resultado;
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
		public virtual List<BorracliproEnt> GetBorracliproCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new BorracliproEnt { Nombre = dataRow.Field<string>("Nombre"), Cantidad = dataRow.Field<int>("Cantidad"), Cliente = dataRow.Field<string>("Cliente"), Fi = dataRow.Field<DateTime>("Fi"), FF = dataRow.Field<DateTime>("FF"), TRIAL543 = dataRow.Field<string>("TRIAL543"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
