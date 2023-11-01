using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class AnuVlibEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private string cliente = string.Empty;
		private double? total = 0;
		private DateTime? fecha = null;
		private string cod_ven = string.Empty;
		private DateTime? f_anulación = null;
		private int? cli_id = 0;
		private string trial543 = string.Empty;
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
		public double? Total
		{
			get { return this.total; }
			set { this.total = value; }
		}

		[DataMember()]
		public DateTime? Fecha
		{
			get { return this.fecha; }
			set { this.fecha = value; }
		}

		[DataMember()]
		public string Cod_Ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public DateTime? F_Anulación
		{
			get { return this.f_anulación; }
			set { this.f_anulación = value; }
		}

		[DataMember()]
		public int? Cli_Id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string TRIAL543
		{
			get { return this.trial543; }
			set { this.trial543 = value; }
		}
		#endregion

		public AnuVlibEnt() { }

		public AnuVlibEnt(string enc_id, string cliente, double? total, DateTime? fecha, string cod_ven, DateTime? f_anulación, int? cli_id, string trial543)
		{
			this.Enc_Id = enc_id;
			this.Cliente = cliente;
			this.Total = total;
			this.Fecha = fecha;
			this.Cod_Ven = cod_ven;
			this.F_Anulación = f_anulación;
			this.Cli_Id = cli_id;
			this.TRIAL543 = trial543;
		}
	}
}
