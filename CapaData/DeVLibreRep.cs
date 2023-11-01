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
	public class DeVLibreRep : ClaseBaseRep, IDeVLibreRep
	{
		public List<DeVLibreEnt> GetAllDeVLibre(string cadenaquery)
		{
			List<DeVLibreEnt> deVLibreList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspDeVLibreList, 0, cadenaquery);
				deVLibreList = GetDeVLibreCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return deVLibreList;
		}
		public int? Save(ref DeVLibreEnt deVLibreEnt, string language)
		{
			int? resultado = null;
			if (deVLibreEnt != null)
				try
				{
                    resultado = ExecuteNonQuery(Constantes.UspDeVLibreUpdateById,
                        deVLibreEnt.ART_ID.ART_ID,
                        deVLibreEnt.ENC_ID.Enc_id,
                        deVLibreEnt.TEM_NOMB,
                        deVLibreEnt.CANTIDAD,
                        deVLibreEnt.PRECIO,
                        deVLibreEnt.Predescto,
                        deVLibreEnt.Descuento,
                        deVLibreEnt.TEM_SUBT,
                        deVLibreEnt.TRIAL605);
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
		public int? Delete(ref DeVLibreEnt deVLibreEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspDeVLibreDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref DeVLibreEnt deVLibreEnt, string language)
		{
			int? resultado = null;
			if (deVLibreEnt != null)
				try
				{
                    resultado = ExecuteNonQuery(Constantes.UspDeVLibreInsert, deVLibreEnt.ART_ID.ART_ID,
                        deVLibreEnt.ENC_ID.Enc_id,
                        deVLibreEnt.TEM_NOMB,
                        deVLibreEnt.CANTIDAD,
                        deVLibreEnt.PRECIO,
                        deVLibreEnt.Predescto,
                        deVLibreEnt.Descuento,
                        deVLibreEnt.TEM_SUBT,
                        deVLibreEnt.TRIAL605);
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
		public virtual List<DeVLibreEnt> GetDeVLibreCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new DeVLibreEnt { ART_ID = dataRow.Field<int>("ART_ID"), ENC_ID = dataRow.Field<string>("ENC_ID"), TEM_NOMB = dataRow.Field<string>("TEM_NOMB"), CANTIDAD = dataRow.Field<double>("CANTIDAD"), PRECIO = dataRow.Field<double>("PRECIO"), Predescto = dataRow.Field<double>("Predescto"), Descuento = dataRow.Field<double>("Descuento"), TEM_SUBT = dataRow.Field<double>("TEM_SUBT"), TRIAL605 = dataRow.Field<string>("TRIAL605"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
