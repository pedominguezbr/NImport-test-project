using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class BocliproEnt
	{
		#region Private Properties
		private string nombre = string.Empty;
		private int? cantidad = 0;
		private string cliente = string.Empty;
		private string trial543 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}

		[DataMember()]
		public int? Cantidad
		{
			get { return this.cantidad; }
			set { this.cantidad = value; }
		}

		[DataMember()]
		public string Cliente
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public string TRIAL543
		{
			get { return this.trial543; }
			set { this.trial543 = value; }
		}
		#endregion

		public BocliproEnt() { }

		public BocliproEnt(string nombre, int? cantidad, string cliente, string trial543)
		{
			this.Nombre = nombre;
			this.Cantidad = cantidad;
			this.Cliente = cliente;
			this.TRIAL543 = trial543;
		}
	}
}
