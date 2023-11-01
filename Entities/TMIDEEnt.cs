using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TMIDEEnt
	{
		#region Private Properties
		private string codigo = string.Empty;
		private string tipo = string.Empty;
		private string marca = string.Empty;
		private string intt = string.Empty;
		private double? ext = 0;
		private double? ext_2_ = 0;
		private double? alt = 0;
		private double? alt_2_ = 0;
		private string descripcion = string.Empty;
		private double? precio = 0;
		private string trial726 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string CODIGO
		{
			get { return this.codigo; }
			set { this.codigo = value; }
		}

		[DataMember()]
		public string TIPO
		{
			get { return this.tipo; }
			set { this.tipo = value; }
		}

		[DataMember()]
		public string MARCA
		{
			get { return this.marca; }
			set { this.marca = value; }
		}

		[DataMember()]
		public string Intt
		{
			get { return this.intt; }
			set { this.intt = value; }
		}

		[DataMember()]
		public double? EXT
		{
			get { return this.ext; }
			set { this.ext = value; }
		}

		[DataMember()]
		public double? EXT_2_
		{
			get { return this.ext_2_; }
			set { this.ext_2_ = value; }
		}

		[DataMember()]
		public double? ALT
		{
			get { return this.alt; }
			set { this.alt = value; }
		}

		[DataMember()]
		public double? ALT_2_
		{
			get { return this.alt_2_; }
			set { this.alt_2_ = value; }
		}

		[DataMember()]
		public string DESCRIPCION
		{
			get { return this.descripcion; }
			set { this.descripcion = value; }
		}

		[DataMember()]
		public double? PRECIO
		{
			get { return this.precio; }
			set { this.precio = value; }
		}

		[DataMember()]
		public string TRIAL726
		{
			get { return this.trial726; }
			set { this.trial726 = value; }
		}
		#endregion

		public TMIDEEnt() { }

		public TMIDEEnt(string codigo, string tipo, string marca, string intt, double? ext, double? ext_2_, double? alt, double? alt_2_, string descripcion, double? precio, string trial726)
		{
			this.CODIGO = codigo;
			this.TIPO = tipo;
			this.MARCA = marca;
			this.intt = intt;
			this.EXT = ext;
			this.EXT_2_ = ext_2_;
			this.ALT = alt;
			this.ALT_2_ = alt_2_;
			this.DESCRIPCION = descripcion;
			this.PRECIO = precio;
			this.TRIAL726 = trial726;
		}
	}
}
