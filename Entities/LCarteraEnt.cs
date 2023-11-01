using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class LCarteraEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private string cliente = string.Empty;
		private DateTime? fvencimiento = null;
		private double? cantidad = 0;
		private DateTime? fechal = null;
		private DateTime? fecha = null;
		private double? ctasaldo = 0;
		private double? importe = 0;
		private int id_letras;
		private string numfactura = string.Empty;
		private CLIENEnt cli_id;
		private string observa = string.Empty;
		private VENDEDOREnt cod_ven;
		private string n_unico = string.Empty;
		private string trial628 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Enc_id
		{
			get { return this.enc_id; }
			set { this.enc_id = value; }
		}

		[DataMember()]
		public string CLIENTE
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public DateTime? FVencimiento
		{
			get { return this.fvencimiento; }
			set { this.fvencimiento = value; }
		}

		[DataMember()]
		public double? Cantidad
		{
			get { return this.cantidad; }
			set { this.cantidad = value; }
		}

		[DataMember()]
		public DateTime? Fechal
		{
			get { return this.fechal; }
			set { this.fechal = value; }
		}

		[DataMember()]
		public DateTime? Fecha
		{
			get { return this.fecha; }
			set { this.fecha = value; }
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
		public int Id_Letras
		{
			get { return this.id_letras; }
			set { this.id_letras = value; }
		}

		[DataMember()]
		public string Numfactura
		{
			get { return this.numfactura; }
			set { this.numfactura = value; }
		}

		[DataMember()]
		public CLIENEnt CLI_ID
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public VENDEDOREnt Cod_ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public string N_Unico
		{
			get { return this.n_unico; }
			set { this.n_unico = value; }
		}

		[DataMember()]
		public string TRIAL628
		{
			get { return this.trial628; }
			set { this.trial628 = value; }
		}
		#endregion

		public LCarteraEnt() { }

		public LCarteraEnt(string enc_id, string cliente, DateTime? fvencimiento, double? cantidad, DateTime? fechal, DateTime? fecha, double? ctasaldo, double? importe, int id_letras, string numfactura, CLIENEnt cli_id, string observa, VENDEDOREnt cod_ven, string n_unico, string trial628)
		{
			this.Enc_id = enc_id;
			this.CLIENTE = cliente;
			this.FVencimiento = fvencimiento;
			this.Cantidad = cantidad;
			this.Fechal = fechal;
			this.Fecha = fecha;
			this.CtaSaldo = ctasaldo;
			this.Importe = importe;
			this.Id_Letras = id_letras;
			this.Numfactura = numfactura;
			this.CLI_ID = cli_id;
			this.Observa = observa;
			this.Cod_ven = cod_ven;
			this.N_Unico = n_unico;
			this.TRIAL628 = trial628;
		}
	}
}
