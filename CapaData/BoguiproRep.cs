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
	public class BoguiproRep : ClaseBaseRep, IBoguiproRep
	{
		public List<BoguiproEnt> GetAllBoguipro(string cadenaquery)
		{
			List<BoguiproEnt> boguiproList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspBoguiproList, 0, cadenaquery);
				boguiproList = GetBoguiproCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return boguiproList;
		}
		public int? Save(ref BoguiproEnt boguiproEnt, string language)
		{
			int? resultado = null;
			if (boguiproEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspBoguiproUpdateById, boguiproEnt.Nombre, boguiproEnt.Cantidad, boguiproEnt.Cliente, boguiproEnt.FI, boguiproEnt.FF, boguiproEnt.TRIAL543,  language);
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
		public int? Delete(ref BoguiproEnt boguiproEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspBoguiproDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref BoguiproEnt boguiproEnt, string language)
		{
			int? resultado = null;
			if (boguiproEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspBoguiproInsert, boguiproEnt.Nombre, boguiproEnt.Cantidad, boguiproEnt.Cliente, boguiproEnt.FI, boguiproEnt.FF, boguiproEnt.TRIAL543,  language);
                    //boguiproEnt.Nombre = (long) resultado;
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
		public virtual List<BoguiproEnt> GetBoguiproCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new BoguiproEnt { Nombre = dataRow.Field<string>("Nombre"), Cantidad = dataRow.Field<int>("Cantidad"), Cliente = dataRow.Field<string>("Cliente"), FI = dataRow.Field<DateTime>("FI"), FF = dataRow.Field<DateTime>("FF"), TRIAL543 = dataRow.Field<string>("TRIAL543"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
