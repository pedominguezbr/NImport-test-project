using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class Temp3Ent
	{
		#region Private Properties
		private string numletra = string.Empty;
		private double? importe = 0;
		private DateTime? fecha = null;
		private DateTime? fvencimiento = null;
		private string observa = string.Empty;
		private string trial713 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Numletra
		{
			get { return this.numletra; }
			set { this.numletra = value; }
		}

		[DataMember()]
		public double? Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public DateTime? Fecha
		{
			get { return this.fecha; }
			set { this.fecha = value; }
		}

		[DataMember()]
		public DateTime? Fvencimiento
		{
			get { return this.fvencimiento; }
			set { this.fvencimiento = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public string TRIAL713
		{
			get { return this.trial713; }
			set { this.trial713 = value; }
		}
		#endregion

		public Temp3Ent() { }

		public Temp3Ent(string numletra, double? importe, DateTime? fecha, DateTime? fvencimiento, string observa, string trial713)
		{
			this.Numletra = numletra;
			this.Importe = importe;
			this.Fecha = fecha;
			this.Fvencimiento = fvencimiento;
			this.Observa = observa;
			this.TRIAL713 = trial713;
		}
	}
}
