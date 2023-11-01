using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class GuiaEnt
	{
		#region Private Properties
		private CLIENEnt cli_id;
		private string cliente = string.Empty;
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private double? igv = 0;
		private double? total = 0;
		private double? ctasaldo = 0;
		private double? importe = 0;
		private string vendedor = string.Empty;
		private VENDEDOREnt cod_ven;
		private DateTime? femision = null;
		private string gremision = string.Empty;
		private string refact = string.Empty;
		private string observa = string.Empty;
		private string condición = string.Empty;
		private string trial625 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public CLIENEnt Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string Cliente
		{
			get { return this.cliente; }
			set { this.cliente = value; }
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
		public double? Ctasaldo
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
		public string Vendedor
		{
			get { return this.vendedor; }
			set { this.vendedor = value; }
		}

		[DataMember()]
		public VENDEDOREnt Cod_ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
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
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public string Condición
		{
			get { return this.condición; }
			set { this.condición = value; }
		}

		[DataMember()]
		public string TRIAL625
		{
			get { return this.trial625; }
			set { this.trial625 = value; }
		}
		#endregion

		public GuiaEnt() { }

		public GuiaEnt(CLIENEnt cli_id, string cliente, string enc_id, DateTime? fecha, double? igv, double? total, double? ctasaldo, double? importe, string vendedor, VENDEDOREnt cod_ven, DateTime? femision, string gremision, string refact, string observa, string condición, string trial625)
		{
			this.cli_id = cli_id;
			this.Cliente = cliente;
			this.enc_id = enc_id;
			this.fecha = fecha;
			this.igv = igv;
			this.total = total;
			this.ctasaldo = ctasaldo;
			this.importe = importe;
			this.vendedor = vendedor;
			this.Cod_ven = cod_ven;
			this.femision = femision;
			this.gremision = gremision;
			this.Refact = refact;
			this.Observa = observa;
			this.Condición = condición;
			this.TRIAL625 = trial625;
		}
	}
}
