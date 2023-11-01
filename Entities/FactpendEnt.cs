using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class FactpendEnt
	{
		#region Private Properties
		private int? cli_id = 0;
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private double? igv = 0;
		private double? total = 0;
		private double? ctasaldo = 0;
		private double? importe = 0;
		private string cod_ven = string.Empty;
		private string vendedor = string.Empty;
		private DateTime? femision = null;
		private string gremision = string.Empty;
		private string refact = string.Empty;
		private string cliente = string.Empty;
		private string numletra = string.Empty;
		private string trial609 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public int? Cli_id
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
		public string Cod_ven
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
		public string TRIAL609
		{
			get { return this.trial609; }
			set { this.trial609 = value; }
		}
		#endregion

		public FactpendEnt() { }

		public FactpendEnt(int? cli_id, string enc_id, DateTime? fecha, double? igv, double? total, double? ctasaldo, double? importe, string cod_ven, string vendedor, DateTime? femision, string gremision, string refact, string cliente, string numletra, string trial609)
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
			this.TRIAL609 = trial609;
		}
	}
}
