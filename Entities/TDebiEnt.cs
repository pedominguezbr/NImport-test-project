using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TDebiEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private int? cli_id = 0;
		private string ruc = string.Empty;
		private string doc = string.Empty;
		private DateTime? fech = null;
		private string observa = string.Empty;
		private double? cant = 0;
		private double? precio = 0;
		private double? importe = 0;
		private double? igv = 0;
		private double? total = 0;
		private DateTime? fech1 = null;
		private DateTime? fech2 = null;
		private string trial713 = string.Empty;
		#endregion

		#region Public Properties

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
		public int? Cli_ID
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string Ruc
		{
			get { return this.ruc; }
			set { this.ruc = value; }
		}

		[DataMember()]
		public string Doc
		{
			get { return this.doc; }
			set { this.doc = value; }
		}

		[DataMember()]
		public DateTime? Fech
		{
			get { return this.fech; }
			set { this.fech = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public double? Cant
		{
			get { return this.cant; }
			set { this.cant = value; }
		}

		[DataMember()]
		public double? Precio
		{
			get { return this.precio; }
			set { this.precio = value; }
		}

		[DataMember()]
		public double? Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public double? Igv
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
		public string TRIAL713
		{
			get { return this.trial713; }
			set { this.trial713 = value; }
		}
		#endregion

		public TDebiEnt() { }

		public TDebiEnt(string enc_id, DateTime? fecha, int? cli_id, string ruc, string doc, DateTime? fech, string observa, double? cant, double? precio, double? importe, double? igv, double? total, DateTime? fech1, DateTime? fech2, string trial713)
		{
			this.Enc_Id = enc_id;
			this.Fecha = fecha;
			this.Cli_ID = cli_id;
			this.Ruc = ruc;
			this.Doc = doc;
			this.Fech = fech;
			this.Observa = observa;
			this.Cant = cant;
			this.Precio = precio;
			this.Importe = importe;
			this.Igv = igv;
			this.Total = total;
			this.Fech1 = fech1;
			this.Fech2 = fech2;
			this.TRIAL713 = trial713;
		}
	}
}
