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
	public class TemPVli2Rep : ClaseBaseRep, ITemPVli2Rep
	{
		public List<TemPVli2Ent> GetAllTemPVli2(string cadenaquery)
		{
			List<TemPVli2Ent> temPVli2List = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTemPVli2List, 0, cadenaquery);
				temPVli2List = GetTemPVli2CollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return temPVli2List;
		}
		public int? Save(ref TemPVli2Ent temPVli2Ent, string language)
		{
			int? resultado = null;
			if (temPVli2Ent != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTemPVli2UpdateById, temPVli2Ent.Enc_Id, temPVli2Ent.Fecha, temPVli2Ent.Producto, temPVli2Ent.Cantidad, temPVli2Ent.Cliente, temPVli2Ent.Fech1, temPVli2Ent.Fech2, temPVli2Ent.TRIAL716,  language);
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
		public int? Delete(ref TemPVli2Ent temPVli2Ent, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTemPVli2DeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TemPVli2Ent temPVli2Ent, string language)
		{
			int? resultado = null;
			if (temPVli2Ent != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTemPVli2Insert, temPVli2Ent.Enc_Id, temPVli2Ent.Fecha, temPVli2Ent.Producto, temPVli2Ent.Cantidad, temPVli2Ent.Cliente, temPVli2Ent.Fech1, temPVli2Ent.Fech2, temPVli2Ent.TRIAL716,  language);
                    //temPVli2Ent.Enc_Id = (long) resultado;
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
		public virtual List<TemPVli2Ent> GetTemPVli2CollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TemPVli2Ent { Enc_Id = dataRow.Field<string>("Enc_Id"), Fecha = dataRow.Field<DateTime>("Fecha"), Producto = dataRow.Field<string>("Producto"), Cantidad = dataRow.Field<int>("Cantidad"), Cliente = dataRow.Field<string>("Cliente"), Fech1 = dataRow.Field<DateTime>("Fech1"), Fech2 = dataRow.Field<DateTime>("Fech2"), TRIAL716 = dataRow.Field<string>("TRIAL716"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
