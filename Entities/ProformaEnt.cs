using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class ProformaEnt
	{
		#region Private Properties
		private CLIENEnt cli_id;
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private double? igv = 0;
		private double? total = 0;
		private double? ctasaldo = 0;
		private double? importe = 0;
		private string vendedor = string.Empty;
		private VENDEDOREnt cod_ven;
		private DateTime? femision = null;
		private string gremision = string.Empty;
		private string condicion = string.Empty;
		private string forma = string.Empty;
		private string forma2 = string.Empty;
		private string forma3 = string.Empty;
		private string cliente = string.Empty;
		private string observa = string.Empty;
		private string trial661 = string.Empty;
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
		public double? Igv
		{
			get { return this.igv; }
			set { this.igv = value; }
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
		public double? Importe
		{
			get { return this.importe; }
			set { this.importe = value; }
		}

		[DataMember()]
		public string Vendedor
		{
			get { return this.vendedor; }
			set { this.vendedor = value; }
		}

		[DataMember()]
		public VENDEDOREnt Cod_ven
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
		public string Condicion
		{
			get { return this.condicion; }
			set { this.condicion = value; }
		}

		[DataMember()]
		public string Forma
		{
			get { return this.forma; }
			set { this.forma = value; }
		}

		[DataMember()]
		public string Forma2
		{
			get { return this.forma2; }
			set { this.forma2 = value; }
		}

		[DataMember()]
		public string Forma3
		{
			get { return this.forma3; }
			set { this.forma3 = value; }
		}

		[DataMember()]
		public string Cliente
		{
			get { return this.cliente; }
			set { this.cliente = value; }
		}

		[DataMember()]
		public string Observa
		{
			get { return this.observa; }
			set { this.observa = value; }
		}

		[DataMember()]
		public string TRIAL661
		{
			get { return this.trial661; }
			set { this.trial661 = value; }
		}
		#endregion

		public ProformaEnt() { }

		public ProformaEnt(CLIENEnt cli_id, string enc_id, DateTime? fecha, double? igv, double? total, double? ctasaldo, double? importe, string vendedor, VENDEDOREnt cod_ven, DateTime? femision, string gremision, string condicion, string forma, string forma2, string forma3, string cliente, string observa, string trial661)
		{
			this.Cli_id = cli_id;
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.Igv = igv;
			this.Total = total;
			this.CtaSaldo = ctasaldo;
			this.Importe = importe;
			this.Vendedor = vendedor;
			this.Cod_ven = cod_ven;
			this.Femision = femision;
			this.Gremision = gremision;
			this.Condicion = condicion;
			this.Forma = forma;
			this.Forma2 = forma2;
			this.Forma3 = forma3;
			this.Cliente = cliente;
			this.Observa = observa;
			this.TRIAL661 = trial661;
		}
	}
}
