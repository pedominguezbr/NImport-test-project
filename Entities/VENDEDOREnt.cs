using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class VENDEDOREnt
	{
		#region Private Properties
		private string cod_ven = string.Empty;
		private string vendedor = string.Empty;
		private string telefono = string.Empty;
		private string telef2 = string.Empty;
		private string fax = string.Empty;
		private string ruc = string.Empty;
		private string direccion = string.Empty;
		private string distrito = string.Empty;
		private string trial726 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Cod_Ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public string VENDEDOR
		{
			get { return this.vendedor; }
			set { this.vendedor = value; }
		}

		[DataMember()]
		public string TELEFONO
		{
			get { return this.telefono; }
			set { this.telefono = value; }
		}

		[DataMember()]
		public string TELEF2
		{
			get { return this.telef2; }
			set { this.telef2 = value; }
		}

		[DataMember()]
		public string FAX
		{
			get { return this.fax; }
			set { this.fax = value; }
		}

		[DataMember()]
		public string RUC
		{
			get { return this.ruc; }
			set { this.ruc = value; }
		}

		[DataMember()]
		public string DIRECCION
		{
			get { return this.direccion; }
			set { this.direccion = value; }
		}

		[DataMember()]
		public string DISTRITO
		{
			get { return this.distrito; }
			set { this.distrito = value; }
		}

		[DataMember()]
		public string TRIAL726
		{
			get { return this.trial726; }
			set { this.trial726 = value; }
		}
		#endregion

		public VENDEDOREnt() { }

		public VENDEDOREnt(string cod_ven, string vendedor, string telefono, string telef2, string fax, string ruc, string direccion, string distrito, string trial726)
		{
			this.Cod_Ven = cod_ven;
			this.VENDEDOR = vendedor;
			this.TELEFONO = telefono;
			this.TELEF2 = telef2;
			this.FAX = fax;
			this.RUC = ruc;
			this.DIRECCION = direccion;
			this.DISTRITO = distrito;
			this.TRIAL726 = trial726;
		}
	}
}
