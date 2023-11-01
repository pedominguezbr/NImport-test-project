using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class MovimientoEnt
	{
		#region Private Properties
		private TIENDAEnt art_id;
		private string enc_id = string.Empty;
		private double? cantidad = 0;
		private DateTime? fecha = null;
		private CLIENEnt cli_id;
		private VENDEDOREnt cod_ven;
		private string trial628 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public TIENDAEnt ART_ID
		{
			get { return this.art_id; }
			set { this.art_id = value; }
		}

		[DataMember()]
		public string ENC_ID
		{
			get { return this.enc_id; }
			set { this.enc_id = value; }
		}

		[DataMember()]
		public double? CANTIDAD
		{
			get { return this.cantidad; }
			set { this.cantidad = value; }
		}

		[DataMember()]
		public DateTime? FECHA
		{
			get { return this.fecha; }
			set { this.fecha = value; }
		}

		[DataMember()]
		public CLIENEnt Cli_Id
		{
			get { return this.cli_id; }
			set { this.cli_id = value; }
		}

		[DataMember()]
		public VENDEDOREnt Cod_ven
		{
			get { return this.cod_ven; }
			set { this.cod_ven = value; }
		}

		[DataMember()]
		public string TRIAL628
		{
			get { return this.trial628; }
			set { this.trial628 = value; }
		}
		#endregion

		public MovimientoEnt() { }

		public MovimientoEnt(TIENDAEnt art_id, string enc_id, double? cantidad, DateTime? fecha, CLIENEnt cli_id, VENDEDOREnt cod_ven, string trial628)
		{
			this.ART_ID = art_id;
			this.ENC_ID = enc_id;
			this.CANTIDAD = cantidad;
			this.FECHA = fecha;
			this.Cli_Id = cli_id;
			this.Cod_ven = cod_ven;
			this.TRIAL628 = trial628;
		}
	}
}
