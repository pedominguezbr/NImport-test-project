using System;
using System.Collections.Generic;
using System.Linq;
using NImport.Dom.Ent;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
//using NImport.Dom.RepInterface;
//using NImport.Inf.Trans;

namespace NImport.Inf.Rep
{
    public class Variables
    {
        #region Variables Globales
        public static string Aplicacion = "";
        public static string Language = "";
        public static string Theme = "";
        public static string ConnectionString = "ConnectionString";
        public static string ConnectionStringSeguridad = "";
        public static string ConnectionStringServer = "";
        public static string MensajeConfirmacion = "";
        //public static UsuarioEnt UsuarioEnt = new UsuarioEnt();
        public static bool Relogueo = false;
        public static bool ReloLitologia = false;
        public static bool ReloAlteracion = false;
        public static bool ReloMineralogia = false;
        public static bool ReloEstructura = false;

        public static List<RESULTADEnt> detalleTemporal;
        #endregion
    }
	public class Constantes
	{
		public static readonly string UspAnuladasList = "uspAnuladasList";
		public static readonly string UspAnuladasUpdateById = "uspAnuladasUpdateById";
		public static readonly string UspAnuladasDeleteById = "uspAnuladasDeleteById";
		public static readonly string UspAnuladasInsert = "uspAnuladasInsert";

		public static readonly string UspAnuVlibList = "uspAnuVlibList";
		public static readonly string UspAnuVlibUpdateById = "uspAnuVlibUpdateById";
		public static readonly string UspAnuVlibDeleteById = "uspAnuVlibDeleteById";
		public static readonly string UspAnuVlibInsert = "uspAnuVlibInsert";

		public static readonly string UspBocliproList = "uspBocliproList";
		public static readonly string UspBocliproUpdateById = "uspBocliproUpdateById";
		public static readonly string UspBocliproDeleteById = "uspBocliproDeleteById";
		public static readonly string UspBocliproInsert = "uspBocliproInsert";

		public static readonly string UspBoguiproList = "uspBoguiproList";
		public static readonly string UspBoguiproUpdateById = "uspBoguiproUpdateById";
		public static readonly string UspBoguiproDeleteById = "uspBoguiproDeleteById";
		public static readonly string UspBoguiproInsert = "uspBoguiproInsert";

		public static readonly string UspBorraList = "uspBorraList";
		public static readonly string UspBorraUpdateById = "uspBorraUpdateById";
		public static readonly string UspBorraDeleteById = "uspBorraDeleteById";
		public static readonly string UspBorraInsert = "uspBorraInsert";

		public static readonly string UspBorracliproList = "uspBorracliproList";
		public static readonly string UspBorracliproUpdateById = "uspBorracliproUpdateById";
		public static readonly string UspBorracliproDeleteById = "uspBorracliproDeleteById";
		public static readonly string UspBorracliproInsert = "uspBorracliproInsert";

		public static readonly string UspCategoríaList = "uspCategoríaList";
		public static readonly string UspCategoríaUpdateById = "uspCategoríaUpdateById";
		public static readonly string UspCategoríaDeleteById = "uspCategoríaDeleteById";
		public static readonly string UspCategoríaInsert = "uspCategoríaInsert";

		public static readonly string UspCHCancelaList = "uspCHCancelaList";
		public static readonly string UspCHCancelaUpdateById = "uspCHCancelaUpdateById";
		public static readonly string UspCHCancelaDeleteById = "uspCHCancelaDeleteById";
		public static readonly string UspCHCancelaInsert = "uspCHCancelaInsert";

		public static readonly string UspCHPagosList = "uspCHPagosList";
		public static readonly string UspCHPagosUpdateById = "uspCHPagosUpdateById";
		public static readonly string UspCHPagosDeleteById = "uspCHPagosDeleteById";
		public static readonly string UspCHPagosInsert = "uspCHPagosInsert";

		public static readonly string UspCLIENList = "uspCLIENList";
		public static readonly string UspCLIENUpdateById = "uspCLIENUpdateById";
		public static readonly string UspCLIENDeleteById = "uspCLIENDeleteById";
		public static readonly string UspCLIENInsert = "uspCLIENInsert";

		public static readonly string UspComprasList = "uspComprasList";
		public static readonly string UspComprasUpdateById = "uspComprasUpdateById";
		public static readonly string UspComprasDeleteById = "uspComprasDeleteById";
		public static readonly string UspComprasInsert = "uspComprasInsert";

		public static readonly string UspContadoList = "uspContadoList";
		public static readonly string UspContadoUpdateById = "uspContadoUpdateById";
		public static readonly string UspContadoDeleteById = "uspContadoDeleteById";
		public static readonly string UspContadoInsert = "uspContadoInsert";

		public static readonly string UspCuentaList = "uspCuentaList";
		public static readonly string UspCuentaUpdateById = "uspCuentaUpdateById";
		public static readonly string UspCuentaDeleteById = "uspCuentaDeleteById";
		public static readonly string UspCuentaInsert = "uspCuentaInsert";

		public static readonly string UspDebitoList = "uspDebitoList";
		public static readonly string UspDebitoUpdateById = "uspDebitoUpdateById";
		public static readonly string UspDebitoDeleteById = "uspDebitoDeleteById";
		public static readonly string UspDebitoInsert = "uspDebitoInsert";

		public static readonly string UspDeFiguraList = "uspDeFiguraList";
		public static readonly string UspDeFiguraUpdateById = "uspDeFiguraUpdateById";
		public static readonly string UspDeFiguraDeleteById = "uspDeFiguraDeleteById";
		public static readonly string UspDeFiguraInsert = "uspDeFiguraInsert";

		public static readonly string UspDeGuiaList = "uspDeGuiaList";
		public static readonly string UspDeGuiaUpdateById = "uspDeGuiaUpdateById";
		public static readonly string UspDeGuiaDeleteById = "uspDeGuiaDeleteById";
		public static readonly string UspDeGuiaInsert = "uspDeGuiaInsert";

		public static readonly string UspDeNAbonoList = "uspDeNAbonoList";
		public static readonly string UspDeNAbonoUpdateById = "uspDeNAbonoUpdateById";
		public static readonly string UspDeNAbonoDeleteById = "uspDeNAbonoDeleteById";
		public static readonly string UspDeNAbonoInsert = "uspDeNAbonoInsert";

		public static readonly string UspDeProformaList = "uspDeProformaList";
		public static readonly string UspDeProformaUpdateById = "uspDeProformaUpdateById";
		public static readonly string UspDeProformaDeleteById = "uspDeProformaDeleteById";
		public static readonly string UspDeProformaInsert = "uspDeProformaInsert";

		public static readonly string UspDeRemisiónList = "uspDeRemisiónList";
		public static readonly string UspDeRemisiónUpdateById = "uspDeRemisiónUpdateById";
		public static readonly string UspDeRemisiónDeleteById = "uspDeRemisiónDeleteById";
		public static readonly string UspDeRemisiónInsert = "uspDeRemisiónInsert";

		public static readonly string UspDeVLibreList = "uspDeVLibreList";
		public static readonly string UspDeVLibreUpdateById = "uspDeVLibreUpdateById";
		public static readonly string UspDeVLibreDeleteById = "uspDeVLibreDeleteById";
		public static readonly string UspDeVLibreInsert = "uspDeVLibreInsert";

		public static readonly string UspECancelaList = "uspECancelaList";
		public static readonly string UspECancelaUpdateById = "uspECancelaUpdateById";
		public static readonly string UspECancelaDeleteById = "uspECancelaDeleteById";
		public static readonly string UspECancelaInsert = "uspECancelaInsert";

		public static readonly string UspECanletraList = "uspECanletraList";
		public static readonly string UspECanletraUpdateById = "uspECanletraUpdateById";
		public static readonly string UspECanletraDeleteById = "uspECanletraDeleteById";
		public static readonly string UspECanletraInsert = "uspECanletraInsert";

		public static readonly string UspFACTENTREFECHAList = "uspFACTENTREFECHAList";
		public static readonly string UspFACTENTREFECHAUpdateById = "uspFACTENTREFECHAUpdateById";
		public static readonly string UspFACTENTREFECHADeleteById = "uspFACTENTREFECHADeleteById";
		public static readonly string UspFACTENTREFECHAInsert = "uspFACTENTREFECHAInsert";

		public static readonly string UspFactpendList = "uspFactpendList";
		public static readonly string UspFactpendUpdateById = "uspFactpendUpdateById";
		public static readonly string UspFactpendDeleteById = "uspFactpendDeleteById";
		public static readonly string UspFactpendInsert = "uspFactpendInsert";

		public static readonly string UspFacturasList = "uspFacturasList";
		public static readonly string UspFacturasUpdateById = "uspFacturasUpdateById";
		public static readonly string UspFacturasDeleteById = "uspFacturasDeleteById";
		public static readonly string UspFacturasInsert = "uspFacturasInsert";

		public static readonly string UspFCarteraList = "uspFCarteraList";
		public static readonly string UspFCarteraUpdateById = "uspFCarteraUpdateById";
		public static readonly string UspFCarteraDeleteById = "uspFCarteraDeleteById";
		public static readonly string UspFCarteraInsert = "uspFCarteraInsert";

		public static readonly string UspFechaList = "uspFechaList";
		public static readonly string UspFechaUpdateById = "uspFechaUpdateById";
		public static readonly string UspFechaDeleteById = "uspFechaDeleteById";
		public static readonly string UspFechaInsert = "uspFechaInsert";

		public static readonly string UspGuiaList = "uspGuiaList";
		public static readonly string UspGuiaUpdateById = "uspGuiaUpdateById";
		public static readonly string UspGuiaDeleteById = "uspGuiaDeleteById";
		public static readonly string UspGuiaInsert = "uspGuiaInsert";

		public static readonly string UspLCarteraList = "uspLCarteraList";
		public static readonly string UspLCarteraUpdateById = "uspLCarteraUpdateById";
		public static readonly string UspLCarteraDeleteById = "uspLCarteraDeleteById";
		public static readonly string UspLCarteraInsert = "uspLCarteraInsert";

		public static readonly string UspMovimientoList = "uspMovimientoList";
		public static readonly string UspMovimientoUpdateById = "uspMovimientoUpdateById";
		public static readonly string UspMovimientoDeleteById = "uspMovimientoDeleteById";
		public static readonly string UspMovimientoInsert = "uspMovimientoInsert";

		public static readonly string UspNAbonoList = "uspNAbonoList";
		public static readonly string UspNAbonoUpdateById = "uspNAbonoUpdateById";
		public static readonly string UspNAbonoDeleteById = "uspNAbonoDeleteById";
		public static readonly string UspNAbonoInsert = "uspNAbonoInsert";

		public static readonly string UspProformaList = "uspProformaList";
		public static readonly string UspProformaUpdateById = "uspProformaUpdateById";
		public static readonly string UspProformaDeleteById = "uspProformaDeleteById";
		public static readonly string UspProformaInsert = "uspProformaInsert";

		public static readonly string UspProveedoresList = "uspProveedoresList";
		public static readonly string UspProveedoresUpdateById = "uspProveedoresUpdateById";
		public static readonly string UspProveedoresDeleteById = "uspProveedoresDeleteById";
		public static readonly string UspProveedoresInsert = "uspProveedoresInsert";

		public static readonly string UspRemisiónList = "uspRemisiónList";
		public static readonly string UspRemisiónUpdateById = "uspRemisiónUpdateById";
		public static readonly string UspRemisiónDeleteById = "uspRemisiónDeleteById";
		public static readonly string UspRemisiónInsert = "uspRemisiónInsert";

		public static readonly string UspRepcancelaList = "uspRepcancelaList";
		public static readonly string UspRepcancelaUpdateById = "uspRepcancelaUpdateById";
		public static readonly string UspRepcancelaDeleteById = "uspRepcancelaDeleteById";
		public static readonly string UspRepcancelaInsert = "uspRepcancelaInsert";

		public static readonly string UspRESULTADList = "uspRESULTADList";
		public static readonly string UspRESULTADUpdateById = "uspRESULTADUpdateById";
		public static readonly string UspRESULTADDeleteById = "uspRESULTADDeleteById";
		public static readonly string UspRESULTADInsert = "uspRESULTADInsert";

		public static readonly string UspTabla1List = "uspTabla1List";
		public static readonly string UspTabla1UpdateById = "uspTabla1UpdateById";
		public static readonly string UspTabla1DeleteById = "uspTabla1DeleteById";
		public static readonly string UspTabla1Insert = "uspTabla1Insert";

		public static readonly string UspTablaborList = "uspTablaborList";
		public static readonly string UspTablaborUpdateById = "uspTablaborUpdateById";
		public static readonly string UspTablaborDeleteById = "uspTablaborDeleteById";
		public static readonly string UspTablaborInsert = "uspTablaborInsert";

		public static readonly string UspTablaconsultaList = "uspTablaconsultaList";
		public static readonly string UspTablaconsultaUpdateById = "uspTablaconsultaUpdateById";
		public static readonly string UspTablaconsultaDeleteById = "uspTablaconsultaDeleteById";
		public static readonly string UspTablaconsultaInsert = "uspTablaconsultaInsert";

		public static readonly string UspTablaConsulta2List = "uspTablaConsulta2List";
		public static readonly string UspTablaConsulta2UpdateById = "uspTablaConsulta2UpdateById";
		public static readonly string UspTablaConsulta2DeleteById = "uspTablaConsulta2DeleteById";
		public static readonly string UspTablaConsulta2Insert = "uspTablaConsulta2Insert";

		public static readonly string UspTAbonList = "uspTAbonList";
		public static readonly string UspTAbonUpdateById = "uspTAbonUpdateById";
		public static readonly string UspTAbonDeleteById = "uspTAbonDeleteById";
		public static readonly string UspTAbonInsert = "uspTAbonInsert";

		public static readonly string UspTDebiList = "uspTDebiList";
		public static readonly string UspTDebiUpdateById = "uspTDebiUpdateById";
		public static readonly string UspTDebiDeleteById = "uspTDebiDeleteById";
		public static readonly string UspTDebiInsert = "uspTDebiInsert";

		public static readonly string UspTEMPList = "uspTEMPList";
		public static readonly string UspTEMPUpdateById = "uspTEMPUpdateById";
		public static readonly string UspTEMPDeleteById = "uspTEMPDeleteById";
		public static readonly string UspTEMPInsert = "uspTEMPInsert";

		public static readonly string UspTemp_2List = "uspTemp_2List";
		public static readonly string UspTemp_2UpdateById = "uspTemp_2UpdateById";
		public static readonly string UspTemp_2DeleteById = "uspTemp_2DeleteById";
		public static readonly string UspTemp_2Insert = "uspTemp_2Insert";

		public static readonly string UspTemp_4List = "uspTemp_4List";
		public static readonly string UspTemp_4UpdateById = "uspTemp_4UpdateById";
		public static readonly string UspTemp_4DeleteById = "uspTemp_4DeleteById";
		public static readonly string UspTemp_4Insert = "uspTemp_4Insert";

		public static readonly string UspTemp3List = "uspTemp3List";
		public static readonly string UspTemp3UpdateById = "uspTemp3UpdateById";
		public static readonly string UspTemp3DeleteById = "uspTemp3DeleteById";
		public static readonly string UspTemp3Insert = "uspTemp3Insert";

		public static readonly string UspTempAnulaList = "uspTempAnulaList";
		public static readonly string UspTempAnulaUpdateById = "uspTempAnulaUpdateById";
		public static readonly string UspTempAnulaDeleteById = "uspTempAnulaDeleteById";
		public static readonly string UspTempAnulaInsert = "uspTempAnulaInsert";

		public static readonly string UspTempCoList = "uspTempCoList";
		public static readonly string UspTempCoUpdateById = "uspTempCoUpdateById";
		public static readonly string UspTempCoDeleteById = "uspTempCoDeleteById";
		public static readonly string UspTempCoInsert = "uspTempCoInsert";

		public static readonly string UspTempFactList = "uspTempFactList";
		public static readonly string UspTempFactUpdateById = "uspTempFactUpdateById";
		public static readonly string UspTempFactDeleteById = "uspTempFactDeleteById";
		public static readonly string UspTempFactInsert = "uspTempFactInsert";

		public static readonly string UspTempfactu2List = "uspTempfactu2List";
		public static readonly string UspTempfactu2UpdateById = "uspTempfactu2UpdateById";
		public static readonly string UspTempfactu2DeleteById = "uspTempfactu2DeleteById";
		public static readonly string UspTempfactu2Insert = "uspTempfactu2Insert";

		public static readonly string UspTempGuiaList = "uspTempGuiaList";
		public static readonly string UspTempGuiaUpdateById = "uspTempGuiaUpdateById";
		public static readonly string UspTempGuiaDeleteById = "uspTempGuiaDeleteById";
		public static readonly string UspTempGuiaInsert = "uspTempGuiaInsert";

		public static readonly string UspTEMPORALList = "uspTEMPORALList";
		public static readonly string UspTEMPORALUpdateById = "uspTEMPORALUpdateById";
		public static readonly string UspTEMPORALDeleteById = "uspTEMPORALDeleteById";
		public static readonly string UspTEMPORALInsert = "uspTEMPORALInsert";

		public static readonly string UspTempVliList = "uspTempVliList";
		public static readonly string UspTempVliUpdateById = "uspTempVliUpdateById";
		public static readonly string UspTempVliDeleteById = "uspTempVliDeleteById";
		public static readonly string UspTempVliInsert = "uspTempVliInsert";

		public static readonly string UspTemPVli2List = "uspTemPVli2List";
		public static readonly string UspTemPVli2UpdateById = "uspTemPVli2UpdateById";
		public static readonly string UspTemPVli2DeleteById = "uspTemPVli2DeleteById";
		public static readonly string UspTemPVli2Insert = "uspTemPVli2Insert";

		public static readonly string UspTGuiaList = "uspTGuiaList";
		public static readonly string UspTGuiaUpdateById = "uspTGuiaUpdateById";
		public static readonly string UspTGuiaDeleteById = "uspTGuiaDeleteById";
		public static readonly string UspTGuiaInsert = "uspTGuiaInsert";

		public static readonly string UspTIENDAList = "uspTIENDAList";
		public static readonly string UspTIENDAUpdateById = "uspTIENDAUpdateById";
		public static readonly string UspTIENDADeleteById = "uspTIENDADeleteById";
		public static readonly string UspTIENDAInsert = "uspTIENDAInsert";

		public static readonly string UspTletList = "uspTletList";
		public static readonly string UspTletUpdateById = "uspTletUpdateById";
		public static readonly string UspTletDeleteById = "uspTletDeleteById";
		public static readonly string UspTletInsert = "uspTletInsert";

		public static readonly string UspTMarcaList = "uspTMarcaList";
		public static readonly string UspTMarcaUpdateById = "uspTMarcaUpdateById";
		public static readonly string UspTMarcaDeleteById = "uspTMarcaDeleteById";
		public static readonly string UspTMarcaInsert = "uspTMarcaInsert";

		public static readonly string UspTMIDEList = "uspTMIDEList";
		public static readonly string UspTMIDEUpdateById = "uspTMIDEUpdateById";
		public static readonly string UspTMIDEDeleteById = "uspTMIDEDeleteById";
		public static readonly string UspTMIDEInsert = "uspTMIDEInsert";

		public static readonly string UspTransporteList = "uspTransporteList";
		public static readonly string UspTransporteUpdateById = "uspTransporteUpdateById";
		public static readonly string UspTransporteDeleteById = "uspTransporteDeleteById";
		public static readonly string UspTransporteInsert = "uspTransporteInsert";

		public static readonly string UspVENDEDORList = "uspVENDEDORList";
		public static readonly string UspVENDEDORUpdateById = "uspVENDEDORUpdateById";
		public static readonly string UspVENDEDORDeleteById = "uspVENDEDORDeleteById";
		public static readonly string UspVENDEDORInsert = "uspVENDEDORInsert";

		public static readonly string UspVLibreList = "uspVLibreList";
		public static readonly string UspVLibreUpdateById = "uspVLibreUpdateById";
		public static readonly string UspVLibreDeleteById = "uspVLibreDeleteById";
		public static readonly string UspVLibreInsert = "uspVLibreInsert";

        public static readonly int EntidadId = 0;

	}
}
