using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TempAnulaEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private int? art_id = 0;
		private string tem_nomb = string.Empty;
		private int? cantidad = 0;
		private double? precio = 0;
		private double? precio2 = 0;
		private double? descuento = 0;
		private double? predescto = 0;
		private double? igv = 0;
		private double? tem_subt = 0;
		private DateTime? fecha = null;
		private int? cli_id = 0;
		private int? cod_ven = 0;
		private string trial713 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string ENC_ID
		{
			get { return this.enc_id; }
			set { this.enc_id = value; }
		}

		[DataMember()]
		public int? ART_ID
		{
			get { return this.art_id; }
			set { this.art_id = value; }
		}

		[DataMember()]
		public string TEM_NOMB
		{
			get { return this.tem_nomb; }
			set { this.tem_nomb = value; }
		}

		[DataMember()]
		public int? CANTIDAD
		{
			get { return this.cantidad; }
			set { this.cantidad = value; }
		}

		[DataMember()]
		public double? PRECIO
		{
			get { return this.precio; }
			set { this.precio = value; }
		}

		[DataMember()]
		public double? PRECIO2
		{
			get { return this.precio2; }
			set { this.precio2 = value; }
		}

		[DataMember()]
		public double? DESCUENTO
		{
			get { return this.descuento; }
			set { this.descuento = value; }
		}

		[DataMember()]
		public double? Predescto
		{
			get { return this.predescto; }
			set { this.predescto = value; }
		}

		[DataMember()]
		public double? IGV
		{
			get { return this.igv; }
			set { this.igv = value; }
		}

		[DataMember()]
		public double? TEM_SUBT
		{
			get { return this.tem_subt; }
			set { this.tem_subt = value; }
		}

		[DataMember()]
		public DateTime? FECHA
		{
			get { return this.fecha; }
			set { this.fecha = value; }
		}

		[DataMember()]
		public int? Cli_Id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public int? Cod_Ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public string TRIAL713
		{
			get { return this.trial713; }
			set { this.trial713 = value; }
		}
		#endregion

		public TempAnulaEnt() { }

		public TempAnulaEnt(string enc_id, int? art_id, string tem_nomb, int? cantidad, double? precio, double? precio2, double? descuento, double? predescto, double? igv, double? tem_subt, DateTime? fecha, int? cli_id, int? cod_ven, string trial713)
		{
			this.ENC_ID = enc_id;
			this.ART_ID = art_id;
			this.TEM_NOMB = tem_nomb;
			this.CANTIDAD = cantidad;
			this.PRECIO = precio;
			this.PRECIO2 = precio2;
			this.DESCUENTO = descuento;
			this.Predescto = predescto;
			this.IGV = igv;
			this.TEM_SUBT = tem_subt;
			this.FECHA = fecha;
			this.Cli_Id = cli_id;
			this.Cod_Ven = cod_ven;
			this.TRIAL713 = trial713;
		}
	}
}
