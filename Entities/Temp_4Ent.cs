using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class Temp_4Ent
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private string cliente = string.Empty;
		private double? cantidad = 0;
		private int? cli_id = 0;
		private DateTime? fechal = null;
		private DateTime? fvencimiento = null;
		private string trial713 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Enc_id
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
		public double? Cantidad
		{
			get { return this.cantidad; }
			set { this.cantidad = value; }
		}

		[DataMember()]
		public int? Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public DateTime? Fechal
		{
			get { return this.fechal; }
			set { this.fechal = value; }
		}

		[DataMember()]
		public DateTime? Fvencimiento
		{
			get { return this.fvencimiento; }
			set { this.fvencimiento = value; }
		}

		[DataMember()]
		public string TRIAL713
		{
			get { return this.trial713; }
			set { this.trial713 = value; }
		}
		#endregion

		public Temp_4Ent() { }

		public Temp_4Ent(string enc_id, string cliente, double? cantidad, int? cli_id, DateTime? fechal, DateTime? fvencimiento, string trial713)
		{
			this.Enc_id = enc_id;
			this.Cliente = cliente;
			this.Cantidad = cantidad;
			this.cli_id = cli_id;
			this.Fechal = fechal;
			this.Fvencimiento = fvencimiento;
			this.TRIAL713 = trial713;
		}
	}
}
