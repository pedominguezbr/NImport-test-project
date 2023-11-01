using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class CHPagosEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private string cliente = string.Empty;
		private double? ctasaldo = 0;
		private DateTime? fvencimiento = null;
		private DateTime? fpago = null;
		private string banco = string.Empty;
		private string cheque = string.Empty;
		private int id_chpagos;
		private int? cli_id = 0;
		private double? cantidad = 0;
		private double? importe = 0;
		private string cod_ven = string.Empty;
		private string observa = string.Empty;
		private string trial543 = string.Empty;
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
		public DateTime? Fpago
		{
			get { return this.fpago; }
			set { this.fpago = value; }
		}

		[DataMember()]
		public string Banco
		{
			get { return this.banco; }
			set { this.banco = value; }
		}

		[DataMember()]
		public string Cheque
		{
			get { return this.cheque; }
			set { this.cheque = value; }
		}

		[DataMember()]
		public int Id_CHpagos
		{
			get { return this.id_chpagos; }
			set { this.id_chpagos = value; }
		}

		[DataMember()]
		public int? Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public double? Cantidad
		{
			get { return this.cantidad; }
			set { this.cantidad = value; }
		}

		[DataMember()]
		public double? Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public string COD_VEN
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public string TRIAL543
		{
			get { return this.trial543; }
			set { this.trial543 = value; }
		}
		#endregion

		public CHPagosEnt() { }

		public CHPagosEnt(string enc_id, DateTime? fecha, string cliente, double? ctasaldo, DateTime? fvencimiento, DateTime? fpago, string banco, string cheque, int id_chpagos, int? cli_id, double? cantidad, double? importe, string cod_ven, string observa, string trial543)
		{
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.CLIENTE = cliente;
			this.CtaSaldo = ctasaldo;
			this.FVencimiento = fvencimiento;
			this.Fpago = fpago;
			this.Banco = banco;
			this.Cheque = cheque;
			this.Id_CHpagos = id_chpagos;
			this.Cli_id = cli_id;
			this.Cantidad = cantidad;
			this.Importe = importe;
			this.COD_VEN = cod_ven;
			this.Observa = observa;
			this.TRIAL543 = trial543;
		}
	}
}
