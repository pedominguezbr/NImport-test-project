using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class CLIENEnt
	{
		#region Private Properties
		private int cli_id;
		private string cliente = string.Empty;
		private string descuento = string.Empty;
		private string encargado = string.Empty;
		private string telefono = string.Empty;
		private string telef2 = string.Empty;
		private string fax = string.Empty;
		private string ruc = string.Empty;
		private string direccion = string.Empty;
		private string dir2 = string.Empty;
		private string distrito = string.Empty;
		private string empieza = string.Empty;
		private string lugar = string.Empty;
		private DateTime? femision = null;
		private string gremision = string.Empty;
		private string le = string.Empty;
		private string refact = string.Empty;
		private string e_mail = string.Empty;
		private string rpm = string.Empty;
		private string adicional = string.Empty;
		private string trial547 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public int Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string CLIENTE
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public string DESCUENTO
		{
			get { return this.descuento; }
			set { this.descuento = value; }
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
		public string EMPIEZA
		{
			get { return this.empieza; }
			set { this.empieza = value; }
		}

		[DataMember()]
		public string LUGAR
		{
			get { return this.lugar; }
			set { this.lugar = value; }
		}

		[DataMember()]
		public DateTime? FEMISION
		{
			get { return this.femision; }
			set { this.femision = value; }
		}

		[DataMember()]
		public string GREMISION
		{
			get { return this.gremision; }
			set { this.gremision = value; }
		}

		[DataMember()]
		public string LE
		{
			get { return this.le; }
			set { this.le = value; }
		}

		[DataMember()]
		public string REFACT
		{
			get { return this.refact; }
			set { this.refact = value; }
		}

		[DataMember()]
		public string E_MAIL
		{
			get { return this.e_mail; }
			set { this.e_mail = value; }
		}

		[DataMember()]
		public string RPM
		{
			get { return this.rpm; }
			set { this.rpm = value; }
		}

		[DataMember()]
		public string Adicional
		{
			get { return this.adicional; }
			set { this.adicional = value; }
		}

		[DataMember()]
		public string TRIAL547
		{
			get { return this.trial547; }
			set { this.trial547 = value; }
		}
		#endregion

		public CLIENEnt() { }

		public CLIENEnt(int cli_id, string cliente, string descuento, string encargado, string telefono, string telef2, string fax, string ruc, string direccion, string dir2, string distrito, string empieza, string lugar, DateTime? femision, string gremision, string le, string refact, string e_mail, string rpm, string adicional, string trial547)
		{
			this.Cli_id = cli_id;
			this.CLIENTE = cliente;
			this.DESCUENTO = descuento;
			this.ENCARGADO = encargado;
			this.TELEFONO = telefono;
			this.TELEF2 = telef2;
			this.FAX = fax;
			this.RUC = ruc;
			this.DIRECCION = direccion;
			this.DIR2 = dir2;
			this.DISTRITO = distrito;
			this.EMPIEZA = empieza;
			this.LUGAR = lugar;
			this.FEMISION = femision;
			this.GREMISION = gremision;
			this.LE = le;
			this.REFACT = refact;
			this.E_MAIL = e_mail;
			this.RPM = rpm;
			this.Adicional = adicional;
			this.TRIAL547 = trial547;
		}
	}
}
