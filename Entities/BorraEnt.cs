using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class BorraEnt
	{
		#region Private Properties
		private string cod_ven = string.Empty;
		private string cliente = string.Empty;
		private string lugar = string.Empty;
		private string direccion = string.Empty;
		private string trial543 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Cod_ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public string Cliente
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public string Lugar
		{
			get { return this.lugar; }
			set { this.lugar = value; }
		}

		[DataMember()]
		public string Direccion
		{
			get { return this.direccion; }
			set { this.direccion = value; }
		}

		[DataMember()]
		public string TRIAL543
		{
			get { return this.trial543; }
			set { this.trial543 = value; }
		}
		#endregion

		public BorraEnt() { }

		public BorraEnt(string cod_ven, string cliente, string lugar, string direccion, string trial543)
		{
			this.Cod_ven = cod_ven;
			this.Cliente = cliente;
			this.Lugar = lugar;
			this.Direccion = direccion;
			this.TRIAL543 = trial543;
		}
	}
}
