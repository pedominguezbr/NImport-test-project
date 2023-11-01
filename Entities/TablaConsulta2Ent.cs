using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TablaConsulta2Ent
	{
		#region Private Properties
		private string proveedor = string.Empty;
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private double? total = 0;
		private string trial713 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Proveedor
		{
			get { return this.proveedor; }
			set { this.proveedor = value; }
		}

		[DataMember()]
		public string Enc_Id
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
		public string TRIAL713
		{
			get { return this.trial713; }
			set { this.trial713 = value; }
		}
		#endregion

		public TablaConsulta2Ent() { }

		public TablaConsulta2Ent(string proveedor, string enc_id, DateTime? fecha, double? total, string trial713)
		{
			this.Proveedor = proveedor;
			this.Enc_Id = enc_id;
			this.Fecha = fecha;
			this.Total = total;
			this.TRIAL713 = trial713;
		}
	}
}
