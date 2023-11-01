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
    public class FacturasRep : ClaseBaseRep, IFacturasRep
    {
        public List<FacturasEnt> GetAllFacturas(string cadenaquery)
        {
            List<FacturasEnt> facturasList = null;
            try
            {
                DataSet ds = ExecuteDataSet(Constantes.UspFacturasList, 0, cadenaquery);
                facturasList = GetFacturasCollectionFromDataSet(ref ds);
            }
            catch (SqlException sqlex)
            {
                HandleSqlException(sqlex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return facturasList;
        }
        public int? Save(ref FacturasEnt facturasEnt, string language)
        {
            int? resultado = null;
            if (facturasEnt != null)
                try
                {
                    resultado = ExecuteNonQuery(Constantes.UspFacturasUpdateById,
                        facturasEnt.Cli_id.Cli_id,
                        facturasEnt.Enc_id,
                        facturasEnt.Fecha,
                        facturasEnt.Igv,
                        facturasEnt.Total,
                        facturasEnt.CtaSaldo,
                        facturasEnt.Importe,
                        facturasEnt.Cod_ven,
                        facturasEnt.Vendedor,
                        facturasEnt.Femision,
                        facturasEnt.Gremision,
                        facturasEnt.Refact,
                        facturasEnt.CLIENTE,
                        facturasEnt.Numletra,
                        facturasEnt.Observa,
                        facturasEnt.Tipo,
                        facturasEnt.Condicion,
                        facturasEnt.Fvencim,
                        facturasEnt.Trans1,
                        facturasEnt.Trans2,
                        facturasEnt.Rut,
                        facturasEnt.Vent,
                        facturasEnt.Consig,
                        facturasEnt.TRIAL615);
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
        public int? Delete(ref FacturasEnt facturasEnt, string language)
        {
            int? resultado = null;
            if (Constantes.EntidadId > 0)
                try
                {
                    resultado = ExecuteNonQuery(Constantes.UspFacturasDeleteById, Constantes.EntidadId, language);
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
        public int? Add(ref FacturasEnt facturasEnt, string language)
        {
            int? resultado = null;
            if (facturasEnt != null)
                try
                {
                    resultado = ExecuteNonQuery(Constantes.UspFacturasInsert, 
                        facturasEnt.Cli_id.Cli_id,
                        facturasEnt.Enc_id,
                        facturasEnt.Fecha,
                        facturasEnt.Igv,
                        facturasEnt.Total,
                        facturasEnt.CtaSaldo,
                        facturasEnt.Importe,
                        facturasEnt.Cod_ven.Cod_Ven,
                        facturasEnt.Vendedor,
                        facturasEnt.Femision,
                        facturasEnt.Gremision,
                        facturasEnt.Refact,
                        facturasEnt.CLIENTE,
                        facturasEnt.Numletra,
                        facturasEnt.Observa,
                        facturasEnt.Tipo,
                        facturasEnt.Condicion,
                        facturasEnt.Fvencim,
                        facturasEnt.Trans1,
                        facturasEnt.Trans2,
                        facturasEnt.Rut,
                        facturasEnt.Vent,
                        facturasEnt.Consig);
                    //facturasEnt.Cli_id = (long) resultado;
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
        public virtual List<FacturasEnt> GetFacturasCollectionFromDataSet(ref DataSet ds)
        {
            return ds.Tables[0].AsEnumerable().Select(dataRow => new FacturasEnt
            {
                Cli_id = new CLIENEnt
                {
                    Cli_id = dataRow.Field<int>("Cli_id")
                },
                Enc_id = dataRow.Field<string>("Enc_id"),
                Fecha = dataRow.Field<DateTime>("Fecha"),
                Igv = dataRow.Field<double>("Igv"),
                Total = dataRow.Field<double>("Total"),
                CtaSaldo = dataRow.Field<double>("CtaSaldo"),
                Importe = dataRow.Field<double>("Importe"),
                Cod_ven = new VENDEDOREnt
                {
                    Cod_Ven = dataRow.Field<string>("Cod_ven"),
                    VENDEDOR = dataRow.Field<string>("Vendedor")
                },

                Femision = dataRow.Field<DateTime>("Femision"),
                Gremision = dataRow.Field<string>("Gremision"),
                Refact = dataRow.Field<string>("Refact"),
                CLIENTE = dataRow.Field<string>("CLIENTE"),
                Numletra = dataRow.Field<string>("Numletra"),
                Observa = dataRow.Field<string>("Observa"),
                Tipo = dataRow.Field<string>("Tipo"),
                Condicion = dataRow.Field<string>("Condicion"),
                Fvencim = dataRow.Field<DateTime>("Fvencim"),
                Trans1 = dataRow.Field<string>("Trans1"),
                Trans2 = dataRow.Field<string>("Trans2"),
                Rut = dataRow.Field<string>("Rut"),
                Vent = dataRow.Field<string>("Vent"),
                Consig = dataRow.Field<string>("Consig"),
                TRIAL615 = dataRow.Field<string>("TRIAL615"),
            }).ToList();
            //throw new NotImplementedException();
        }
    }
}
