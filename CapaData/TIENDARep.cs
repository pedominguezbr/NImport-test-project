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
	public class TIENDARep : ClaseBaseRep, ITIENDARep
	{
		public List<TIENDAEnt> GetAllTIENDA(int codigoArt,string articulo, string categoria )
		{
			List<TIENDAEnt> tIENDAList = null;
			try
			{
                DataSet ds = ExecuteDataSet(Constantes.UspTIENDAList, codigoArt, articulo);
				tIENDAList = GetTIENDACollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tIENDAList;
		}
		public int? Save(ref TIENDAEnt tIENDAEnt, string language)
		{
			int? resultado = null;
			if (tIENDAEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTIENDAUpdateById, tIENDAEnt.ART_ID, tIENDAEnt.PRODUCTO, tIENDAEnt.PREVENT, tIENDAEnt.STOCK, tIENDAEnt.PRECIO2, tIENDAEnt.SMIN, tIENDAEnt.DESCUENTO, tIENDAEnt.LINEA, tIENDAEnt.PREPUBLICO, tIENDAEnt.P_Compra, tIENDAEnt.Ubic, tIENDAEnt.MARCA, tIENDAEnt.TRIAL716,  language);
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
		public int? Delete(ref TIENDAEnt tIENDAEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTIENDADeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TIENDAEnt tIENDAEnt, string language)
		{
			int? resultado = null;
			if (tIENDAEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTIENDAInsert, tIENDAEnt.ART_ID, tIENDAEnt.PRODUCTO, tIENDAEnt.PREVENT, tIENDAEnt.STOCK, tIENDAEnt.PRECIO2, tIENDAEnt.SMIN, tIENDAEnt.DESCUENTO, tIENDAEnt.LINEA, tIENDAEnt.PREPUBLICO, tIENDAEnt.P_Compra, tIENDAEnt.Ubic, tIENDAEnt.MARCA, tIENDAEnt.TRIAL716,  language);
                    //tIENDAEnt.ART_ID = (long) resultado;
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
		public virtual List<TIENDAEnt> GetTIENDACollectionFromDataSet(ref DataSet ds)
		{
			return ds.Tables[0].AsEnumerable().Select(dataRow => new TIENDAEnt {
                ART_ID = dataRow.Field<int>("ART_ID"), 
                PRODUCTO = dataRow.Field<string>("PRODUCTO"),
                PREVENT = dataRow.Field<double?>("PREVENT"),
                STOCK = dataRow.Field<double?>("STOCK"), 
                PRECIO2 = dataRow.Field<double?>("PRECIO2"), 
                SMIN = dataRow.Field<double?>("SMIN"),
                DESCUENTO = dataRow.Field<double?>("DESCUENTO"),
                LINEA = dataRow.Field<string>("LINEA"),
                PREPUBLICO = dataRow.Field<double?>("PREPUBLICO"),
                P_Compra = dataRow.Field<double?>("P_Compra"),
                Ubic = dataRow.Field<string>("Ubic"),
                MARCA = dataRow.Field<string>("MARCA"),
                TRIAL716 = dataRow.Field<string>("TRIAL845")
            }).ToList();
			//throw new NotImplementedException();
		}
	}
}
