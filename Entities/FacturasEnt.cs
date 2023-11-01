using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class FacturasEnt
	{
		#region Private Properties
		private CLIENEnt cli_id;
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private double? igv = 0;
		private double? total = 0;
		private double? ctasaldo = 0;
		private double? importe = 0;
		private VENDEDOREnt cod_ven;
		private string vendedor = string.Empty;
		private DateTime? femision = null;
		private string gremision = string.Empty;
		private string refact = string.Empty;
		private string cliente = string.Empty;
		private string numletra = string.Empty;
		private string observa = string.Empty;
		private string tipo = string.Empty;
		private string condicion = string.Empty;
		private DateTime? fvencim = null;
		private string trans1 = string.Empty;
		private string trans2 = string.Empty;
		private string rut = string.Empty;
		private string vent = string.Empty;
		private string consig = string.Empty;
		private string trial615 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public CLIENEnt Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string Enc_id
		{
			get { return this.enc_id; }
			set { this.enc_id = value; }
		}

		[DataMember()]
		public DateTime? Fecha
		{
			get { return this.fecha; }
			set { this.fecha = value; }
		}

		[DataMember()]
		public double? Igv
		{
			get { return this.igv; }
			set { this.igv = value; }
		}

		[DataMember()]
		public double? Total
		{
			get { return this.total; }
			set { this.total = value; }
		}

		[DataMember()]
		public double? CtaSaldo
		{
			get { return this.ctasaldo; }
			set { this.ctasaldo = value; }
		}

		[DataMember()]
		public double? Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public VENDEDOREnt Cod_ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public string Vendedor
		{
			get { return this.vendedor; }
			set { this.vendedor = value; }
		}

		[DataMember()]
		public DateTime? Femision
		{
			get { return this.femision; }
			set { this.femision = value; }
		}

		[DataMember()]
		public string Gremision
		{
			get { return this.gremision; }
			set { this.gremision = value; }
		}

		[DataMember()]
		public string Refact
		{
			get { return this.refact; }
			set { this.refact = value; }
		}

		[DataMember()]
		public string CLIENTE
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public string Numletra
		{
			get { return this.numletra; }
			set { this.numletra = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public string Tipo
		{
			get { return this.tipo; }
			set { this.tipo = value; }
		}

		[DataMember()]
		public string Condicion
		{
			get { return this.condicion; }
			set { this.condicion = value; }
		}

		[DataMember()]
		public DateTime? Fvencim
		{
			get { return this.fvencim; }
			set { this.fvencim = value; }
		}

		[DataMember()]
		public string Trans1
		{
			get { return this.trans1; }
			set { this.trans1 = value; }
		}

		[DataMember()]
		public string Trans2
		{
			get { return this.trans2; }
			set { this.trans2 = value; }
		}

		[DataMember()]
		public string Rut
		{
			get { return this.rut; }
			set { this.rut = value; }
		}

		[DataMember()]
		public string Vent
		{
			get { return this.vent; }
			set { this.vent = value; }
		}

		[DataMember()]
		public string Consig
		{
			get { return this.consig; }
			set { this.consig = value; }
		}

		[DataMember()]
		public string TRIAL615
		{
			get { return this.trial615; }
			set { this.trial615 = value; }
		}
		#endregion

		public FacturasEnt() { }

		public FacturasEnt(CLIENEnt cli_id, string enc_id, DateTime? fecha, double? igv, double? total, double? ctasaldo, double? importe, VENDEDOREnt cod_ven, string vendedor, DateTime? femision, string gremision, string refact, string cliente, string numletra, string observa, string tipo, string condicion, DateTime? fvencim, string trans1, string trans2, string rut, string vent, string consig, string trial615)
		{
			this.Cli_id = cli_id;
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.Igv = igv;
			this.Total = total;
			this.CtaSaldo = ctasaldo;
			this.Importe = importe;
			this.Cod_ven = cod_ven;
			this.Vendedor = vendedor;
			this.Femision = femision;
			this.Gremision = gremision;
			this.Refact = refact;
			this.CLIENTE = cliente;
			this.Numletra = numletra;
			this.Observa = observa;
			this.Tipo = tipo;
			this.Condicion = condicion;
			this.Fvencim = fvencim;
			this.Trans1 = trans1;
			this.Trans2 = trans2;
			this.Rut = rut;
			this.Vent = vent;
			this.Consig = consig;
			this.TRIAL615 = trial615;
		}
	}
}
