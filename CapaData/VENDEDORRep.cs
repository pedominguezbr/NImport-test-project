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
	public class VENDEDORRep : ClaseBaseRep, IVENDEDORRep
	{
		public List<VENDEDOREnt> GetAllVENDEDOR(string codigovendedor, string vendedor )
		{
			List<VENDEDOREnt> vENDEDORList = null;
			try
			{
                DataSet ds = ExecuteDataSet(Constantes.UspVENDEDORList, codigovendedor, vendedor);
				vENDEDORList = GetVENDEDORCollectionFromDataSet(ref ds);
			}
			catch (SqlException sqlex)
			{
				HandleSqlException(sqlex);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return vENDEDORList;
		}
		public int? Save(ref VENDEDOREnt vENDEDOREnt, string language)
		{
			int? resultado = null;
			if (vENDEDOREnt != null)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspVENDEDORUpdateById, 
                        vENDEDOREnt.Cod_Ven,
                        vENDEDOREnt.VENDEDOR, 
                        vENDEDOREnt.TELEFONO,
                        vENDEDOREnt.TELEF2, 
                        vENDEDOREnt.FAX, 
                        vENDEDOREnt.RUC, 
                        vENDEDOREnt.DIRECCION, 
                        vENDEDOREnt.DISTRITO,
                        vENDEDOREnt.TRIAL726);
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
		public int? Delete(ref VENDEDOREnt vENDEDOREnt, string language)
		{
			int? resultado = null;
			if (Constantes.EntidadId > 0)
				try
				{
					resultado = ExecuteNonQuery(Constantes.UspVENDEDORDeleteById,
                        vENDEDOREnt.Cod_Ven);
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
		public int? Add(ref VENDEDOREnt vENDEDOREnt, string language)
		{
			int? resultado = null;
			if (vENDEDOREnt != null)
				try
				{
                    //resultado = ExecuteNonQueryIdentity(Constantes.UspVENDEDORInsert,
                    //    vENDEDOREnt.Cod_Ven, 
                    //    vENDEDOREnt.VENDEDOR, 
                    //    vENDEDOREnt.TELEFONO,
                    //    vENDEDOREnt.TELEF2,
                    //    vENDEDOREnt.FAX, 
                    //    vENDEDOREnt.RUC, 
                    //    vENDEDOREnt.DIRECCION, 
                    //    vENDEDOREnt.DISTRITO,
                    //    vENDEDOREnt.TRIAL726);

                    resultado = ExecuteNonQuery(Constantes.UspVENDEDORInsert,
                        vENDEDOREnt.Cod_Ven,
                        vENDEDOREnt.VENDEDOR,
                        vENDEDOREnt.TELEFONO,
                        vENDEDOREnt.TELEF2,
                        vENDEDOREnt.FAX,
                        vENDEDOREnt.RUC,
                        vENDEDOREnt.DIRECCION,
                        vENDEDOREnt.DISTRITO,
                        vENDEDOREnt.TRIAL726);
                    //vENDEDOREnt.Cod_Ven = (long) resultado;
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
		public virtual List<VENDEDOREnt> GetVENDEDORCollectionFromDataSet(ref DataSet ds)
		{
			return ds.Tables[0].AsEnumerable().Select(dataRow => new VENDEDOREnt {
                Cod_Ven = dataRow.Field<string>("Cod_Ven"), 
                VENDEDOR = dataRow.Field<string>("VENDEDOR"), 
                TELEFONO = dataRow.Field<string>("TELEFONO"),
                TELEF2 = dataRow.Field<string>("TELEF2"), 
                FAX = dataRow.Field<string>("FAX"), 
                RUC = dataRow.Field<string>("RUC"), 
                DIRECCION = dataRow.Field<string>("DIRECCION"),
                DISTRITO = dataRow.Field<string>("DISTRITO"),
                TRIAL726 = dataRow.Field<string>("TRIAL858")
            }).ToList();
            //throw new NotImplementedException();
		}
	}
}
