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
	public class Tempfactu2Rep : ClaseBaseRep, ITempfactu2Rep
	{
		public List<Tempfactu2Ent> GetAllTempfactu2(string cadenaquery)
		{
			List<Tempfactu2Ent> tempfactu2List = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTempfactu2List, 0, cadenaquery);
				tempfactu2List = GetTempfactu2CollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tempfactu2List;
		}
		public int? Save(ref Tempfactu2Ent tempfactu2Ent, string language)
		{
			int? resultado = null;
			if (tempfactu2Ent != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempfactu2UpdateById, tempfactu2Ent.Enc_Id, tempfactu2Ent.Fecha, tempfactu2Ent.Producto, tempfactu2Ent.Cantidad, tempfactu2Ent.Cliente, tempfactu2Ent.Fech1, tempfactu2Ent.Fech2, tempfactu2Ent.TRIAL716,  language);
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
		public int? Delete(ref Tempfactu2Ent tempfactu2Ent, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTempfactu2DeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref Tempfactu2Ent tempfactu2Ent, string language)
		{
			int? resultado = null;
			if (tempfactu2Ent != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTempfactu2Insert, tempfactu2Ent.Enc_Id, tempfactu2Ent.Fecha, tempfactu2Ent.Producto, tempfactu2Ent.Cantidad, tempfactu2Ent.Cliente, tempfactu2Ent.Fech1, tempfactu2Ent.Fech2, tempfactu2Ent.TRIAL716,  language);
                    //tempfactu2Ent.Enc_Id = (long) resultado;
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
		public virtual List<Tempfactu2Ent> GetTempfactu2CollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new Tempfactu2Ent { Enc_Id = dataRow.Field<string>("Enc_Id"), Fecha = dataRow.Field<DateTime>("Fecha"), Producto = dataRow.Field<string>("Producto"), Cantidad = dataRow.Field<int>("Cantidad"), Cliente = dataRow.Field<string>("Cliente"), Fech1 = dataRow.Field<DateTime>("Fech1"), Fech2 = dataRow.Field<DateTime>("Fech2"), TRIAL716 = dataRow.Field<string>("TRIAL716"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
