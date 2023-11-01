using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class ECanletraEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private string cliente = string.Empty;
		private double? ctasaldo = 0;
		private DateTime? fvencimiento = null;
		private double? importe = 0;
		private int? cli_id = 0;
		private VENDEDOREnt cod_ven;
		private double? cantidad = 0;
		private string observa = string.Empty;
		private int ide_canl;
		private DateTime? fpago = null;
		private FacturasEnt numfactura;
		private string procedencia = string.Empty;
		private string n_unico = string.Empty;
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
		public VENDEDOREnt COD_VEN
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
		public int Ide_CanL
		{
			get { return this.ide_canl; }
			set { this.ide_canl = value; }
		}

		[DataMember()]
		public DateTime? Fpago
		{
			get { return this.fpago; }
			set { this.fpago = value; }
		}

		[DataMember()]
		public FacturasEnt Numfactura
		{
			get { return this.numfactura; }
			set { this.numfactura = value; }
		}

		[DataMember()]
		public string Procedencia
		{
			get { return this.procedencia; }
			set { this.procedencia = value; }
		}

		[DataMember()]
		public string N_Unico
		{
			get { return this.n_unico; }
			set { this.n_unico = value; }
		}

		[DataMember()]
		public string TRIAL609
		{
			get { return this.trial609; }
			set { this.trial609 = value; }
		}
		#endregion

		public ECanletraEnt() { }

		public ECanletraEnt(string enc_id, DateTime? fecha, string cliente, double? ctasaldo, DateTime? fvencimiento, double? importe, int? cli_id, VENDEDOREnt cod_ven, double? cantidad, string observa, int ide_canl, DateTime? fpago, FacturasEnt numfactura, string procedencia, string n_unico, string trial609)
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
			this.Ide_CanL = ide_canl;
			this.Fpago = fpago;
			this.Numfactura = numfactura;
			this.Procedencia = procedencia;
			this.N_Unico = n_unico;
			this.TRIAL609 = trial609;
		}
	}
}
