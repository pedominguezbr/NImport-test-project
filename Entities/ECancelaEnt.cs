using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class ECancelaEnt
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
		private int ide_canf;
		private DateTime? fpago = null;
		private string trial609 = string.Empty;
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
		public int Ide_Canf
		{
			get { return this.ide_canf; }
			set { this.ide_canf = value; }
		}

		[DataMember()]
		public DateTime? Fpago
		{
			get { return this.fpago; }
			set { this.fpago = value; }
		}

		[DataMember()]
		public string TRIAL609
		{
			get { return this.trial609; }
			set { this.trial609 = value; }
		}
		#endregion

		public ECancelaEnt() { }

		public ECancelaEnt(string enc_id, DateTime? fecha, string cliente, double? ctasaldo, DateTime? fvencimiento, double? importe, int? cli_id, string cod_ven, double? cantidad, string observa, int ide_canf, DateTime? fpago, string trial609)
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
			this.Ide_Canf = ide_canf;
			this.Fpago = fpago;
			this.TRIAL609 = trial609;
		}
	}
}
