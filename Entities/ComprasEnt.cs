using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class ComprasEnt
	{
		#region Private Properties
		private int? prov_id = 0;
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private double? total = 0;
		private string observa = string.Empty;
		private string trial547 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public int? Prov_id
		{
			get { return this.prov_id; }
			set { this.prov_id = value; }
		}

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
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public string TRIAL547
		{
			get { return this.trial547; }
			set { this.trial547 = value; }
		}
		#endregion

		public ComprasEnt() { }

		public ComprasEnt(int? prov_id, string enc_id, DateTime? fecha, double? total, string observa, string trial547)
		{
			this.Prov_id = prov_id;
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.Total = total;
			this.Observa = observa;
			this.TRIAL547 = trial547;
		}
	}
}
