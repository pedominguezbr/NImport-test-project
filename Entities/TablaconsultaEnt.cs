using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TablaconsultaEnt
	{
		#region Private Properties
		private string cliente = string.Empty;
		private string enc_id = string.Empty;
		private string cod_ven = string.Empty;
		private DateTime? fecha = null;
		private double? importe = 0;
		private DateTime? fecha1 = null;
		private DateTime? fecha2 = null;
		private string trial713 = string.Empty;
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
		public string Cod_Ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public DateTime? Fecha
		{
			get { return this.fecha; }
			set { this.fecha = value; }
		}

		[DataMember()]
		public double? Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public DateTime? Fecha1
		{
			get { return this.fecha1; }
			set { this.fecha1 = value; }
		}

		[DataMember()]
		public DateTime? Fecha2
		{
			get { return this.fecha2; }
			set { this.fecha2 = value; }
		}

		[DataMember()]
		public string TRIAL713
		{
			get { return this.trial713; }
			set { this.trial713 = value; }
		}
		#endregion

		public TablaconsultaEnt() { }

		public TablaconsultaEnt(string cliente, string enc_id, string cod_ven, DateTime? fecha, double? importe, DateTime? fecha1, DateTime? fecha2, string trial713)
		{
			this.Cliente = cliente;
			this.Enc_Id = enc_id;
			this.Cod_Ven = cod_ven;
			this.Fecha = fecha;
			this.Importe = importe;
			this.fecha1 = fecha1;
			this.fecha2 = fecha2;
			this.TRIAL713 = trial713;
		}
	}
}
