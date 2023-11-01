using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TMarcaEnt
	{
		#region Private Properties
		private string codigo = string.Empty;
		private DateTime? fecha = null;
		private string marca = string.Empty;
		private double? importe = 0;
		private DateTime? fecha1 = null;
		private DateTime? fecha2 = null;
		private string trial726 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Codigo
		{
			get { return this.codigo; }
			set { this.codigo = value; }
		}

		[DataMember()]
		public DateTime? Fecha
		{
			get { return this.fecha; }
			set { this.fecha = value; }
		}

		[DataMember()]
		public string Marca
		{
			get { return this.marca; }
			set { this.marca = value; }
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
		public string TRIAL726
		{
			get { return this.trial726; }
			set { this.trial726 = value; }
		}
		#endregion

		public TMarcaEnt() { }

		public TMarcaEnt(string codigo, DateTime? fecha, string marca, double? importe, DateTime? fecha1, DateTime? fecha2, string trial726)
		{
			this.Codigo = codigo;
			this.Fecha = fecha;
			this.Marca = marca;
			this.Importe = importe;
			this.Fecha1 = fecha1;
			this.Fecha2 = fecha2;
			this.TRIAL726 = trial726;
		}
	}
}
