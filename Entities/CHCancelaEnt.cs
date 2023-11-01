using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class CHCancelaEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private string cliente = string.Empty;
		private double? ctasaldo = 0;
		private DateTime? fvencimiento = null;
		private double? importe = 0;
		private int? cli_id = 0;
		private string cod_ven = string.Empty;
		private double? cantidad = 0;
		private string observa = string.Empty;
		private int ide_canch;
		private string banco = string.Empty;
		private string cheque = string.Empty;
		private DateTime? fpago = null;
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
		public double? Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public int? Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string COD_VEN
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
		public int Ide_Canch
		{
			get { return this.ide_canch; }
			set { this.ide_canch = value; }
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
		public DateTime? Fpago
		{
			get { return this.fpago; }
			set { this.fpago = value; }
		}

		[DataMember()]
		public string TRIAL543
		{
			get { return this.trial543; }
			set { this.trial543 = value; }
		}
		#endregion

		public CHCancelaEnt() { }

		public CHCancelaEnt(string enc_id, DateTime? fecha, string cliente, double? ctasaldo, DateTime? fvencimiento, double? importe, int? cli_id, string cod_ven, double? cantidad, string observa, int ide_canch, string banco, string cheque, DateTime? fpago, string trial543)
		{
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.CLIENTE = cliente;
			this.CtaSaldo = ctasaldo;
			this.FVencimiento = fvencimiento;
			this.Importe = importe;
			this.Cli_id = cli_id;
			this.COD_VEN = cod_ven;
			this.Cantidad = cantidad;
			this.Observa = observa;
			this.Ide_Canch = ide_canch;
			this.Banco = banco;
			this.Cheque = cheque;
			this.Fpago = fpago;
			this.TRIAL543 = trial543;
		}
	}
}
