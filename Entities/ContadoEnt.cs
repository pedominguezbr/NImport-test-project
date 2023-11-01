using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class ContadoEnt
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
		private string cliente = string.Empty;
		private string numletra = string.Empty;
		private string observa = string.Empty;
		private string trial547 = string.Empty;
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
		public string TRIAL547
		{
			get { return this.trial547; }
			set { this.trial547 = value; }
		}
		#endregion

		public ContadoEnt() { }

		public ContadoEnt(CLIENEnt cli_id, string enc_id, DateTime? fecha, double? igv, double? total, double? ctasaldo, double? importe, VENDEDOREnt cod_ven, string vendedor, string cliente, string numletra, string observa, string trial547)
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
			this.CLIENTE = cliente;
			this.Numletra = numletra;
			this.Observa = observa;
			this.TRIAL547 = trial547;
		}
	}
}
