using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class NAbonoEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private double? total = 0;
		private double? igv = 0;
		private double? importe = 0;
		private CLIENEnt cli_id;
		private string n_factur = string.Empty;
		private DateTime? f_factur = null;
		private string trial661 = string.Empty;
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
		public CLIENEnt Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string N_Factur
		{
			get { return this.n_factur; }
			set { this.n_factur = value; }
		}

		[DataMember()]
		public DateTime? F_Factur
		{
			get { return this.f_factur; }
			set { this.f_factur = value; }
		}

		[DataMember()]
		public string TRIAL661
		{
			get { return this.trial661; }
			set { this.trial661 = value; }
		}
		#endregion

		public NAbonoEnt() { }

		public NAbonoEnt(string enc_id, DateTime? fecha, double? total, double? igv, double? importe, CLIENEnt cli_id, string n_factur, DateTime? f_factur, string trial661)
		{
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.Total = total;
			this.Igv = igv;
			this.Importe = importe;
			this.Cli_id = cli_id;
			this.N_Factur = n_factur;
			this.F_Factur = f_factur;
			this.TRIAL661 = trial661;
		}
	}
}
