using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TempFactEnt
	{
		#region Private Properties
		private string cliente = string.Empty;
		private string cod_ven = string.Empty;
		private string enc_id = string.Empty;
		private DateTime fecha;
		private double importe;
		private string observa = string.Empty;
		private double? igv = 0;
		private double? total = 0;
		private DateTime? fecha_1 = null;
		private string fecha_2 = string.Empty;
		private string trial716 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Cliente
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public string Cod_Ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public string ENC_ID
		{
			get { return this.enc_id; }
			set { this.enc_id = value; }
		}

		[DataMember()]
		public DateTime Fecha
		{
			get { return this.fecha; }
			set { this.fecha = value; }
		}

		[DataMember()]
		public double Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public double? IGV
		{
			get { return this.igv; }
			set { this.igv = value; }
		}

		[DataMember()]
		public double? Total
		{
			get { return this.total; }
			set { this.total = value; }
		}

		[DataMember()]
		public DateTime? Fecha_1
		{
			get { return this.fecha_1; }
			set { this.fecha_1 = value; }
		}

		[DataMember()]
		public string Fecha_2
		{
			get { return this.fecha_2; }
			set { this.fecha_2 = value; }
		}

		[DataMember()]
		public string TRIAL716
		{
			get { return this.trial716; }
			set { this.trial716 = value; }
		}
		#endregion

		public TempFactEnt() { }

		public TempFactEnt(string cliente, string cod_ven, string enc_id, DateTime fecha, double importe, string observa, double? igv, double? total, DateTime? fecha_1, string fecha_2, string trial716)
		{
			this.Cliente = cliente;
			this.Cod_Ven = cod_ven;
			this.ENC_ID = enc_id;
			this.Fecha = fecha;
			this.Importe = importe;
			this.Observa = observa;
			this.IGV = igv;
			this.Total = total;
			this.Fecha_1 = fecha_1;
			this.Fecha_2 = fecha_2;
			this.TRIAL716 = trial716;
		}
	}
}
