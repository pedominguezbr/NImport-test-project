using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class RepcancelaEnt
	{
		#region Private Properties
		private FacturasEnt enc_id;
		private DateTime? fecha = null;
		private string cliente = string.Empty;
		private double? importe = 0;
		private VENDEDOREnt cod_ven;
		private DateTime? fcancela = null;
		private int? cli_id = 0;
		private DateTime? fvencimiento = null;
		private double? ctasaldo = 0;
		private string trial664 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public FacturasEnt Enc_id
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
		public string CLIENTE
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public double? Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public VENDEDOREnt Cod_Ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public DateTime? FCancela
		{
			get { return this.fcancela; }
			set { this.fcancela = value; }
		}

		[DataMember()]
		public int? Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public DateTime? FVencimiento
		{
			get { return this.fvencimiento; }
			set { this.fvencimiento = value; }
		}

		[DataMember()]
		public double? Ctasaldo
		{
			get { return this.ctasaldo; }
			set { this.ctasaldo = value; }
		}

		[DataMember()]
		public string TRIAL664
		{
			get { return this.trial664; }
			set { this.trial664 = value; }
		}
		#endregion

		public RepcancelaEnt() { }

		public RepcancelaEnt(FacturasEnt enc_id, DateTime? fecha, string cliente, double? importe, VENDEDOREnt cod_ven, DateTime? fcancela, int? cli_id, DateTime? fvencimiento, double? ctasaldo, string trial664)
		{
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.CLIENTE = cliente;
			this.Importe = importe;
			this.Cod_Ven = cod_ven;
			this.FCancela = fcancela;
			this.Cli_id = cli_id;
			this.FVencimiento = fvencimiento;
			this.Ctasaldo = ctasaldo;
			this.TRIAL664 = trial664;
		}
	}
}
