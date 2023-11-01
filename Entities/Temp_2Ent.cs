using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class Temp_2Ent
	{
		#region Private Properties
		private int? art_id = 0;
		private string enc_id = string.Empty;
		private string tem_nomb = string.Empty;
		private double? cantidad = 0;
		private double? precio = 0;
		private double? predescto = 0;
		private double? descuento = 0;
		private double? tem_subt = 0;
		private DateTime? fecha = null;
		private int? cli_id = 0;
		private int? cod_ven = 0;
		private string trial713 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public int? ART_ID
		{
			get { return this.art_id; }
			set { this.art_id = value; }
		}

		[DataMember()]
		public string ENC_ID
		{
			get { return this.enc_id; }
			set { this.enc_id = value; }
		}

		[DataMember()]
		public string TEM_NOMB
		{
			get { return this.tem_nomb; }
			set { this.tem_nomb = value; }
		}

		[DataMember()]
		public double? CANTIDAD
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
		public double? Predescto
		{
			get { return this.predescto; }
			set { this.predescto = value; }
		}

		[DataMember()]
		public double? Descuento
		{
			get { return this.descuento; }
			set { this.descuento = value; }
		}

		[DataMember()]
		public double? TEM_SUBT
		{
			get { return this.tem_subt; }
			set { this.tem_subt = value; }
		}

		[DataMember()]
		public DateTime? Fecha
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

		public Temp_2Ent() { }

		public Temp_2Ent(int? art_id, string enc_id, string tem_nomb, double? cantidad, double? precio, double? predescto, double? descuento, double? tem_subt, DateTime? fecha, int? cli_id, int? cod_ven, string trial713)
		{
			this.ART_ID = art_id;
			this.ENC_ID = enc_id;
			this.TEM_NOMB = tem_nomb;
			this.CANTIDAD = cantidad;
			this.PRECIO = precio;
			this.Predescto = predescto;
			this.Descuento = descuento;
			this.TEM_SUBT = tem_subt;
			this.Fecha = fecha;
			this.Cli_Id = cli_id;
			this.Cod_Ven = cod_ven;
			this.TRIAL713 = trial713;
		}
	}
}
