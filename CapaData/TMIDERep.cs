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
	public class TMIDERep : ClaseBaseRep, ITMIDERep
	{
		public List<TMIDEEnt> GetAllTMIDE(string cadenaquery)
		{
			List<TMIDEEnt> tMIDEList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspTMIDEList, 0, cadenaquery);
				tMIDEList = GetTMIDECollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return tMIDEList;
		}
		public int? Save(ref TMIDEEnt tMIDEEnt, string language)
		{
			int? resultado = null;
			if (tMIDEEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTMIDEUpdateById, tMIDEEnt.CODIGO, tMIDEEnt.TIPO, tMIDEEnt.MARCA, tMIDEEnt.Intt, tMIDEEnt.EXT, tMIDEEnt.EXT_2_, tMIDEEnt.ALT, tMIDEEnt.ALT_2_, tMIDEEnt.DESCRIPCION, tMIDEEnt.PRECIO, tMIDEEnt.TRIAL726,  language);
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
		public int? Delete(ref TMIDEEnt tMIDEEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspTMIDEDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref TMIDEEnt tMIDEEnt, string language)
		{
			int? resultado = null;
			if (tMIDEEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspTMIDEInsert, tMIDEEnt.CODIGO, tMIDEEnt.TIPO, tMIDEEnt.MARCA, tMIDEEnt.Intt, tMIDEEnt.EXT, tMIDEEnt.EXT_2_, tMIDEEnt.ALT, tMIDEEnt.ALT_2_, tMIDEEnt.DESCRIPCION, tMIDEEnt.PRECIO, tMIDEEnt.TRIAL726,  language);
                    //tMIDEEnt.CODIGO = (long) resultado;
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
		public virtual List<TMIDEEnt> GetTMIDECollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new TMIDEEnt { CODIGO = dataRow.Field<string>("CODIGO"), TIPO = dataRow.Field<string>("TIPO"), MARCA = dataRow.Field<string>("MARCA"), Intt = dataRow.Field<string>("intt"), EXT = dataRow.Field<double>("EXT"), EXT_2_ = dataRow.Field<double>("EXT_2_"), ALT = dataRow.Field<double>("ALT"), ALT_2_ = dataRow.Field<double>("ALT_2_"), DESCRIPCION = dataRow.Field<string>("DESCRIPCION"), PRECIO = dataRow.Field<double>("PRECIO"), TRIAL726 = dataRow.Field<string>("TRIAL726"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
