using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class CuentaEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private string cliente = string.Empty;
		private DateTime? fecha = null;
		private DateTime? fvencimto = null;
		private double? cargo = 0;
		private double? abono = 0;
		private double? saldo = 0;
		private string observa = string.Empty;
		private int id_cta;
		private int? cli_id = 0;
		private string cod_ven = string.Empty;
		private string vendedor = string.Empty;
		private string trial550 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Enc_Id
		{
			get { return this.enc_id; }
			set { this.enc_id = value; }
		}

		[DataMember()]
		public string Cliente
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public DateTime? Fecha
		{
			get { return this.fecha; }
			set { this.fecha = value; }
		}

		[DataMember()]
		public DateTime? FVencimto
		{
			get { return this.fvencimto; }
			set { this.fvencimto = value; }
		}

		[DataMember()]
		public double? Cargo
		{
			get { return this.cargo; }
			set { this.cargo = value; }
		}

		[DataMember()]
		public double? Abono
		{
			get { return this.abono; }
			set { this.abono = value; }
		}

		[DataMember()]
		public double? Saldo
		{
			get { return this.saldo; }
			set { this.saldo = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public int Id_Cta
		{
			get { return this.id_cta; }
			set { this.id_cta = value; }
		}

		[DataMember()]
		public int? Cli_Id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string Cod_Ven
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
		public string TRIAL550
		{
			get { return this.trial550; }
			set { this.trial550 = value; }
		}
		#endregion

		public CuentaEnt() { }

		public CuentaEnt(string enc_id, string cliente, DateTime? fecha, DateTime? fvencimto, double? cargo, double? abono, double? saldo, string observa, int id_cta, int? cli_id, string cod_ven, string vendedor, string trial550)
		{
			this.Enc_Id = enc_id;
			this.Cliente = cliente;
			this.Fecha = fecha;
			this.FVencimto = fvencimto;
			this.Cargo = cargo;
			this.Abono = abono;
			this.Saldo = saldo;
			this.Observa = observa;
			this.Id_Cta = id_cta;
			this.Cli_Id = cli_id;
			this.Cod_Ven = cod_ven;
			this.Vendedor = vendedor;
			this.TRIAL550 = trial550;
		}
	}
}
