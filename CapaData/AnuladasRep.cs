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
	public class AnuladasRep : ClaseBaseRep, IAnuladasRep
	{
		public List<AnuladasEnt> GetAllAnuladas(string cadenaquery)
		{
			List<AnuladasEnt> anuladasList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspAnuladasList, 0, cadenaquery);
				anuladasList = GetAnuladasCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return anuladasList;
		}
		public int? Save(ref AnuladasEnt anuladasEnt, string language)
		{
			int? resultado = null;
			if (anuladasEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspAnuladasUpdateById, anuladasEnt.Enc_Id, anuladasEnt.Cli_Id, anuladasEnt.Cliente, anuladasEnt.Importe, anuladasEnt.Fecha, anuladasEnt.Cod_Ven, anuladasEnt.F_Anulación, anuladasEnt.TRIAL540,  language);
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
		public int? Delete(ref AnuladasEnt anuladasEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspAnuladasDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref AnuladasEnt anuladasEnt, string language)
		{
			int? resultado = null;
			if (anuladasEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspAnuladasInsert, anuladasEnt.Enc_Id, anuladasEnt.Cli_Id, anuladasEnt.Cliente, anuladasEnt.Importe, anuladasEnt.Fecha, anuladasEnt.Cod_Ven, anuladasEnt.F_Anulación, anuladasEnt.TRIAL540,  language);
                    //anuladasEnt.Enc_Id = (long) resultado;
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
		public virtual List<AnuladasEnt> GetAnuladasCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new AnuladasEnt { Enc_Id = dataRow.Field<string>("Enc_Id"), Cli_Id = dataRow.Field<int>("Cli_Id"), Cliente = dataRow.Field<string>("Cliente"), Importe = dataRow.Field<double>("Importe"), Fecha = dataRow.Field<DateTime>("Fecha"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), F_Anulación = dataRow.Field<DateTime>("F_Anulación"), TRIAL540 = dataRow.Field<string>("TRIAL540"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
