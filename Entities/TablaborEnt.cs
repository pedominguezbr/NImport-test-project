using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TablaborEnt
	{
		#region Private Properties
		private DateTime? fecha = null;
		private double? total = 0;
		private double? igv = 0;
		private double? importe = 0;
		private int? cli_id = 0;
		private string enc_id = string.Empty;
		private string n_factur = string.Empty;
		private DateTime? f_factur = null;
		private string trial713 = string.Empty;
		#endregion

		#region Public Properties

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
		public int? Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string Enc_id
		{
			get { return this.enc_id; }
			set { this.enc_id = value; }
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
		public string TRIAL713
		{
			get { return this.trial713; }
			set { this.trial713 = value; }
		}
		#endregion

		public TablaborEnt() { }

		public TablaborEnt(DateTime? fecha, double? total, double? igv, double? importe, int? cli_id, string enc_id, string n_factur, DateTime? f_factur, string trial713)
		{
			this.Fecha = fecha;
			this.Total = total;
			this.Igv = igv;
			this.Importe = importe;
			this.Cli_id = cli_id;
			this.Enc_id = enc_id;
			this.N_Factur = n_factur;
			this.F_Factur = f_factur;
			this.TRIAL713 = trial713;
		}
	}
}
