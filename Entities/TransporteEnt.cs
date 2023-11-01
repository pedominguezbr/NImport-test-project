using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TransporteEnt
	{
		#region Private Properties
		private int? cod_tr = 0;
		private string nombre = string.Empty;
		private string nomb2 = string.Empty;
		private string telefono = string.Empty;
		private string telef2 = string.Empty;
		private string ruc = string.Empty;
		private string direccion = string.Empty;
		private string distrito = string.Empty;
		private string nomb3 = string.Empty;
		private string observa = string.Empty;
		private string trial726 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public int? Cod_Tr
		{
			get { return this.cod_tr; }
			set { this.cod_tr = value; }
		}

		[DataMember()]
		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}

		[DataMember()]
		public string Nomb2
		{
			get { return this.nomb2; }
			set { this.nomb2 = value; }
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
		public string Nomb3
		{
			get { return this.nomb3; }
			set { this.nomb3 = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public string TRIAL726
		{
			get { return this.trial726; }
			set { this.trial726 = value; }
		}
		#endregion

		public TransporteEnt() { }

		public TransporteEnt(int? cod_tr, string nombre, string nomb2, string telefono, string telef2, string ruc, string direccion, string distrito, string nomb3, string observa, string trial726)
		{
			this.Cod_Tr = cod_tr;
			this.Nombre = nombre;
			this.Nomb2 = nomb2;
			this.TELEFONO = telefono;
			this.TELEF2 = telef2;
			this.RUC = ruc;
			this.DIRECCION = direccion;
			this.DISTRITO = distrito;
			this.Nomb3 = nomb3;
			this.Observa = observa;
			this.TRIAL726 = trial726;
		}
	}
}
