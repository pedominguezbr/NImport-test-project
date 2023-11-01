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
	public class AnuVlibRep : ClaseBaseRep, IAnuVlibRep
	{
		public List<AnuVlibEnt> GetAllAnuVlib(string cadenaquery)
		{
			List<AnuVlibEnt> anuVlibList = null;
			try
			{
				DataSet ds = ExecuteDataSet(Constantes.UspAnuVlibList, 0, cadenaquery);
				anuVlibList = GetAnuVlibCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return anuVlibList;
		}
		public int? Save(ref AnuVlibEnt anuVlibEnt, string language)
		{
			int? resultado = null;
			if (anuVlibEnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspAnuVlibUpdateById, anuVlibEnt.Enc_Id, anuVlibEnt.Cliente, anuVlibEnt.Total, anuVlibEnt.Fecha, anuVlibEnt.Cod_Ven, anuVlibEnt.F_Anulación, anuVlibEnt.Cli_Id, anuVlibEnt.TRIAL543,  language);
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
		public int? Delete(ref AnuVlibEnt anuVlibEnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspAnuVlibDeleteById, Constantes.EntidadId, language);
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
		public int? Add(ref AnuVlibEnt anuVlibEnt, string language)
		{
			int? resultado = null;
			if (anuVlibEnt != null)
				try
				{
					resultado = ExecuteNonQueryIdentity(Constantes.UspAnuVlibInsert, anuVlibEnt.Enc_Id, anuVlibEnt.Cliente, anuVlibEnt.Total, anuVlibEnt.Fecha, anuVlibEnt.Cod_Ven, anuVlibEnt.F_Anulación, anuVlibEnt.Cli_Id, anuVlibEnt.TRIAL543,  language);
                    //anuVlibEnt.Enc_Id = (long) resultado;
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
		public virtual List<AnuVlibEnt> GetAnuVlibCollectionFromDataSet(ref DataSet ds)
		{
			//return ds.Tables[0].AsEnumerable().Select(dataRow => new AnuVlibEnt { Enc_Id = dataRow.Field<string>("Enc_Id"), Cliente = dataRow.Field<string>("Cliente"), Total = dataRow.Field<double>("Total"), Fecha = dataRow.Field<DateTime>("Fecha"), Cod_Ven = dataRow.Field<string>("Cod_Ven"), F_Anulación = dataRow.Field<DateTime>("F_Anulación"), Cli_Id = dataRow.Field<int>("Cli_Id"), TRIAL543 = dataRow.Field<string>("TRIAL543"),  }).ToList();
			throw new NotImplementedException();
		}
	}
}
