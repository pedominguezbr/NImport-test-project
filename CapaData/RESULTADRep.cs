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
	public class RESULTADRep : ClaseBaseRep, IRESULTADRep
	{
		public List<RESULTADEnt> GetAllRESULTAD(string cadenaquery)
		{
			List<RESULTADEnt> rESULTADList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspRESULTADList, 0, cadenaquery);
				rESULTADList = GetRESULTADCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return rESULTADList;
		}
		public int? Save(ref RESULTADEnt rESULTADEnt, string language)
		{
			int? resultado = null;
			if (rESULTADEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspRESULTADUpdateById, 
                        rESULTADEnt.ART_ID.ART_ID,
                        rESULTADEnt.ENC_ID.Enc_id,
                        rESULTADEnt.TEM_NOMB, 
                        rESULTADEnt.CANTIDAD,
                        rESULTADEnt.PRECIO,
                        rESULTADEnt.Predescto,
                        rESULTADEnt.Descuento,
                        rESULTADEnt.TEM_SUBT,
                        rESULTADEnt.TRIAL667);
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
		public int? Delete(ref RESULTADEnt rESULTADEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspRESULTADDeleteById,
                        Constantes.EntidadId);
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
		public int? Add(ref RESULTADEnt rESULTADEnt, string language)
		{
			int? resultado = null;
			if (rESULTADEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspRESULTADInsert,
                        rESULTADEnt.ART_ID.ART_ID,
                        rESULTADEnt.ENC_ID.Enc_id,
                        rESULTADEnt.TEM_NOMB,
                        rESULTADEnt.CANTIDAD,
                        rESULTADEnt.PRECIO,
                        rESULTADEnt.Predescto,
                        rESULTADEnt.Descuento,
                        rESULTADEnt.TEM_SUBT);
                    //rESULTADEnt.ART_ID = (long) resultado;
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
		public virtual List<RESULTADEnt> GetRESULTADCollectionFromDataSet(ref DataSet ds)
		{
            return ds.Tables[0].AsEnumerable().Select(dataRow => new RESULTADEnt
            {
                ART_ID = new TIENDAEnt { ART_ID = dataRow.Field<int>("ART_ID") },
                ENC_ID = new FacturasEnt { Enc_id = dataRow.Field<string>("ENC_ID") },
                TEM_NOMB = dataRow.Field<string>("TEM_NOMB"),
                CANTIDAD = dataRow.Field<double>("CANTIDAD"),
                PRECIO = dataRow.Field<double>("PRECIO"),
                Predescto = dataRow.Field<double>("Predescto"),
                Descuento = dataRow.Field<double>("Descuento"),
                TEM_SUBT = dataRow.Field<double>("TEM_SUBT"),
                TRIAL667 = dataRow.Field<string>("TRIAL667")
            }).ToList();
			throw new NotImplementedException();
		}
	}
}
