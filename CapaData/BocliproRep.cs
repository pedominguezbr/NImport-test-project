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
	public class BocliproRep : ClaseBaseRep, IBocliproRep
	{
		public List<BocliproEnt> GetAllBoclipro(string cadenaquery)
		{
			List<BocliproEnt> bocliproList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspBocliproList, 0, cadenaquery);
				bocliproList = GetBocliproCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return bocliproList;
		}
		public int? Save(ref BocliproEnt bocliproEnt, string language)
		{
			int? resultado = null;
			if (bocliproEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspBocliproUpdateById, bocliproEnt.Nombre, bocliproEnt.Cantidad, bocliproEnt.Cliente, bocliproEnt.TRIAL543,  language);
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
		public int? Delete(ref BocliproEnt bocliproEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspBocliproDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref BocliproEnt bocliproEnt, string language)
		{
			int? resultado = null;
			if (bocliproEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspBocliproInsert, bocliproEnt.Nombre, bocliproEnt.Cantidad, bocliproEnt.Cliente, bocliproEnt.TRIAL543,  language);
                    //bocliproEnt.Nombre = (long) resultado;
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
		public virtual List<BocliproEnt> GetBocliproCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new BocliproEnt { Nombre = dataRow.Field<string>("Nombre"), Cantidad = dataRow.Field<int>("Cantidad"), Cliente = dataRow.Field<string>("Cliente"), TRIAL543 = dataRow.Field<string>("TRIAL543"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
