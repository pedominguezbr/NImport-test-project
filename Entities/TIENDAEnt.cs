using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TIENDAEnt
	{
		#region Private Properties
		private int art_id;
		private string producto = string.Empty;
		private double? prevent = 0;
		private double? stock = 0;
		private double? precio2 = 0;
		private double? smin = 0;
		private double? descuento = 0;
		private string linea = string.Empty;
		private double? prepublico = 0;
		private double? p_compra = 0;
		private string ubic = string.Empty;
		private string marca = string.Empty;
		private string trial716 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public int ART_ID
		{
			get { return this.art_id; }
			set { this.art_id = value; }
		}

		[DataMember()]
		public string PRODUCTO
		{
			get { return this.producto; }
			set { this.producto = value; }
		}

		[DataMember()]
		public double? PREVENT
		{
			get { return this.prevent; }
			set { this.prevent = value; }
		}

		[DataMember()]
		public double? STOCK
		{
			get { return this.stock; }
			set { this.stock = value; }
		}

		[DataMember()]
		public double? PRECIO2
		{
			get { return this.precio2; }
			set { this.precio2 = value; }
		}

		[DataMember()]
		public double? SMIN
		{
			get { return this.smin; }
			set { this.smin = value; }
		}

		[DataMember()]
		public double? DESCUENTO
		{
			get { return this.descuento; }
			set { this.descuento = value; }
		}

		[DataMember()]
		public string LINEA
		{
			get { return this.linea; }
			set { this.linea = value; }
		}

		[DataMember()]
		public double? PREPUBLICO
		{
			get { return this.prepublico; }
			set { this.prepublico = value; }
		}

		[DataMember()]
		public double? P_Compra
		{
			get { return this.p_compra; }
			set { this.p_compra = value; }
		}

		[DataMember()]
		public string Ubic
		{
			get { return this.ubic; }
			set { this.ubic = value; }
		}

		[DataMember()]
		public string MARCA
		{
			get { return this.marca; }
			set { this.marca = value; }
		}

		[DataMember()]
		public string TRIAL716
		{
			get { return this.trial716; }
			set { this.trial716 = value; }
		}
		#endregion

		public TIENDAEnt() { }

		public TIENDAEnt(int art_id, string producto, double? prevent, double? stock, double? precio2, double? smin, double? descuento, string linea, double? prepublico, double? p_compra, string ubic, string marca, string trial716)
		{
			this.ART_ID = art_id;
			this.PRODUCTO = producto;
			this.PREVENT = prevent;
			this.STOCK = stock;
			this.PRECIO2 = precio2;
			this.SMIN = smin;
			this.DESCUENTO = descuento;
			this.LINEA = linea;
			this.PREPUBLICO = prepublico;
			this.P_Compra = p_compra;
			this.Ubic = ubic;
			this.MARCA = marca;
			this.TRIAL716 = trial716;
		}
	}
}
