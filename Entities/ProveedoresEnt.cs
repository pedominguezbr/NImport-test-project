using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class ProveedoresEnt
	{
		#region Private Properties
		private int prov_id;
		private string proveedor = string.Empty;
		private string encargado = string.Empty;
		private string telefono = string.Empty;
		private string telef2 = string.Empty;
		private string fax = string.Empty;
		private string ruc = string.Empty;
		private string direccion = string.Empty;
		private string dir2 = string.Empty;
		private string distrito = string.Empty;
		private string email = string.Empty;
		private string email2 = string.Empty;
		private string trial664 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public int Prov_id
		{
			get { return this.prov_id; }
			set { this.prov_id = value; }
		}

		[DataMember()]
		public string Proveedor
		{
			get { return this.proveedor; }
			set { this.proveedor = value; }
		}

		[DataMember()]
		public string ENCARGADO
		{
			get { return this.encargado; }
			set { this.encargado = value; }
		}

		[DataMember()]
		public string TELEFONO
		{
			get { return this.telefono; }
			set { this.telefono = value; }
		}

		[DataMember()]
		public string Telef2
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
		public string DIR2
		{
			get { return this.dir2; }
			set { this.dir2 = value; }
		}

		[DataMember()]
		public string DISTRITO
		{
			get { return this.distrito; }
			set { this.distrito = value; }
		}

		[DataMember()]
		public string EMAIL
		{
			get { return this.email; }
			set { this.email = value; }
		}

		[DataMember()]
		public string EMAIL2
		{
			get { return this.email2; }
			set { this.email2 = value; }
		}

		[DataMember()]
		public string TRIAL664
		{
			get { return this.trial664; }
			set { this.trial664 = value; }
		}
		#endregion

		public ProveedoresEnt() { }

		public ProveedoresEnt(int prov_id, string proveedor, string encargado, string telefono, string telef2, string fax, string ruc, string direccion, string dir2, string distrito, string email, string email2, string trial664)
		{
			this.Prov_id = prov_id;
			this.Proveedor = proveedor;
			this.ENCARGADO = encargado;
			this.TELEFONO = telefono;
			this.Telef2 = telef2;
			this.FAX = fax;
			this.RUC = ruc;
			this.DIRECCION = direccion;
			this.DIR2 = dir2;
			this.DISTRITO = distrito;
			this.EMAIL = email;
			this.EMAIL2 = email2;
			this.TRIAL664 = trial664;
		}
	}
}
