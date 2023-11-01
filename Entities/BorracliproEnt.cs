using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class BorracliproEnt
	{
		#region Private Properties
		private string nombre = string.Empty;
		private int? cantidad = 0;
		private string cliente = string.Empty;
		private DateTime? fi = null;
		private DateTime? ff = null;
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
		public DateTime? Fi
		{
			get { return this.fi; }
			set { this.fi = value; }
		}

		[DataMember()]
		public DateTime? FF
		{
			get { return this.ff; }
			set { this.ff = value; }
		}

		[DataMember()]
		public string TRIAL543
		{
			get { return this.trial543; }
			set { this.trial543 = value; }
		}
		#endregion

		public BorracliproEnt() { }

		public BorracliproEnt(string nombre, int? cantidad, string cliente, DateTime? fi, DateTime? ff, string trial543)
		{
			this.Nombre = nombre;
			this.Cantidad = cantidad;
			this.Cliente = cliente;
			this.Fi = fi;
			this.FF = ff;
			this.TRIAL543 = trial543;
		}
	}
}
