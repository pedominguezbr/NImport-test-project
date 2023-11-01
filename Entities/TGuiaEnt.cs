using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TGuiaEnt
	{
		#region Private Properties
		private string cliente = string.Empty;
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private double? igv = 0;
		private double? total = 0;
		private double? importe = 0;
		private string cod_ven = string.Empty;
		private string observa = string.Empty;
		private DateTime? fech1 = null;
		private DateTime? fech2 = null;
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
		public double? Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public string Cod_Ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public DateTime? Fech1
		{
			get { return this.fech1; }
			set { this.fech1 = value; }
		}

		[DataMember()]
		public DateTime? Fech2
		{
			get { return this.fech2; }
			set { this.fech2 = value; }
		}

		[DataMember()]
		public string TRIAL716
		{
			get { return this.trial716; }
			set { this.trial716 = value; }
		}
		#endregion

		public TGuiaEnt() { }

		public TGuiaEnt(string cliente, string enc_id, DateTime? fecha, double? igv, double? total, double? importe, string cod_ven, string observa, DateTime? fech1, DateTime? fech2, string trial716)
		{
			this.Cliente = cliente;
			this.Enc_Id = enc_id;
			this.Fecha = fecha;
			this.IGV = igv;
			this.Total = total;
			this.Importe = importe;
			this.Cod_Ven = cod_ven;
			this.Observa = observa;
			this.Fech1 = fech1;
			this.Fech2 = fech2;
			this.TRIAL716 = trial716;
		}
	}
}
