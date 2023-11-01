using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class FCarteraEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private string cliente = string.Empty;
		private double? ctasaldo = 0;
		private DateTime? fvencimiento = null;
		private double? total = 0;
		private double? igv = 0;
		private double? importe = 0;
		private string vendedor = string.Empty;
		private int id_cartera;
		private CLIENEnt cli_id;
		private VENDEDOREnt cod_ven;
		private double? cantidad = 0;
		private string observa = string.Empty;
		private string trial622 = string.Empty;
		#endregion

		#region Public Properties

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
		public string CLIENTE
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public double? CtaSaldo
		{
			get { return this.ctasaldo; }
			set { this.ctasaldo = value; }
		}

		[DataMember()]
		public DateTime? FVencimiento
		{
			get { return this.fvencimiento; }
			set { this.fvencimiento = value; }
		}

		[DataMember()]
		public double? Total
		{
			get { return this.total; }
			set { this.total = value; }
		}

		[DataMember()]
		public double? Igv
		{
			get { return this.igv; }
			set { this.igv = value; }
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
		public int Id_Cartera
		{
			get { return this.id_cartera; }
			set { this.id_cartera = value; }
		}

		[DataMember()]
		public CLIENEnt Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public VENDEDOREnt Cod_ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public double? Cantidad
		{
			get { return this.cantidad; }
			set { this.cantidad = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public string TRIAL622
		{
			get { return this.trial622; }
			set { this.trial622 = value; }
		}
		#endregion

		public FCarteraEnt() { }

		public FCarteraEnt(string enc_id, DateTime? fecha, string cliente, double? ctasaldo, DateTime? fvencimiento, double? total, double? igv, double? importe, string vendedor, int id_cartera, CLIENEnt cli_id, VENDEDOREnt cod_ven, double? cantidad, string observa, string trial622)
		{
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.CLIENTE = cliente;
			this.CtaSaldo = ctasaldo;
			this.FVencimiento = fvencimiento;
			this.Total = total;
			this.Igv = igv;
			this.Importe = importe;
			this.Vendedor = vendedor;
			this.Id_Cartera = id_cartera;
			this.Cli_id = cli_id;
			this.Cod_ven = cod_ven;
			this.Cantidad = cantidad;
			this.Observa = observa;
			this.TRIAL622 = trial622;
		}
	}
}
