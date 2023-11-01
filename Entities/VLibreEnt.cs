using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class VLibreEnt
	{
		#region Private Properties
		private CLIENEnt cli_id;
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private double? total = 0;
		private double? ctasaldo = 0;
		private string vendedor = string.Empty;
		private VENDEDOREnt cod_ven;
		private DateTime? femision = null;
		private string gremision = string.Empty;
		private string cliente = string.Empty;
		private string refact = string.Empty;
		private string observa = string.Empty;
		private string condicion = string.Empty;
		private DateTime? fvencim = null;
		private string trial726 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public CLIENEnt Cli_id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public string Enc_id
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
		public double? Total
		{
			get { return this.total; }
			set { this.total = value; }
		}

		[DataMember()]
		public double? CtaSaldo
		{
			get { return this.ctasaldo; }
			set { this.ctasaldo = value; }
		}

		[DataMember()]
		public string Vendedor
		{
			get { return this.vendedor; }
			set { this.vendedor = value; }
		}

		[DataMember()]
		public VENDEDOREnt Cod_Ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public DateTime? Femision
		{
			get { return this.femision; }
			set { this.femision = value; }
		}

		[DataMember()]
		public string Gremision
		{
			get { return this.gremision; }
			set { this.gremision = value; }
		}

		[DataMember()]
		public string Cliente
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public string Refact
		{
			get { return this.refact; }
			set { this.refact = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public string Condicion
		{
			get { return this.condicion; }
			set { this.condicion = value; }
		}

		[DataMember()]
		public DateTime? Fvencim
		{
			get { return this.fvencim; }
			set { this.fvencim = value; }
		}

		[DataMember()]
		public string TRIAL726
		{
			get { return this.trial726; }
			set { this.trial726 = value; }
		}
		#endregion

		public VLibreEnt() { }

		public VLibreEnt(CLIENEnt cli_id, string enc_id, DateTime? fecha, double? total, double? ctasaldo, string vendedor, VENDEDOREnt cod_ven, DateTime? femision, string gremision, string cliente, string refact, string observa, string condicion, DateTime? fvencim, string trial726)
		{
			this.Cli_id = cli_id;
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.Total = total;
			this.CtaSaldo = ctasaldo;
			this.Vendedor = vendedor;
			this.Cod_Ven = cod_ven;
			this.Femision = femision;
			this.Gremision = gremision;
			this.Cliente = cliente;
			this.Refact = refact;
			this.Observa = observa;
			this.Condicion = condicion;
			this.Fvencim = fvencim;
			this.TRIAL726 = trial726;
		}
	}
}
