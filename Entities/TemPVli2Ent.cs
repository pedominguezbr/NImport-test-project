using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TemPVli2Ent
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private string producto = string.Empty;
		private int? cantidad = 0;
		private string cliente = string.Empty;
		private DateTime? fech1 = null;
		private DateTime? fech2 = null;
		private string trial716 = string.Empty;
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
		public string Producto
		{
			get { return this.producto; }
			set { this.producto = value; }
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

		public TemPVli2Ent() { }

		public TemPVli2Ent(string enc_id, DateTime? fecha, string producto, int? cantidad, string cliente, DateTime? fech1, DateTime? fech2, string trial716)
		{
			this.Enc_Id = enc_id;
			this.Fecha = fecha;
			this.Producto = producto;
			this.Cantidad = cantidad;
			this.Cliente = cliente;
			this.Fech1 = fech1;
			this.Fech2 = fech2;
			this.TRIAL716 = trial716;
		}
	}
}
