using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class FACTENTREFECHAEnt
	{
		#region Private Properties
		private string enc_id = string.Empty;
		private DateTime? fecha = null;
		private string trial609 = string.Empty;
		#endregion

		#region Public Properties

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
		public string TRIAL609
		{
			get { return this.trial609; }
			set { this.trial609 = value; }
		}
		#endregion

		public FACTENTREFECHAEnt() { }

		public FACTENTREFECHAEnt(string enc_id, DateTime? fecha, string trial609)
		{
			this.Enc_id = enc_id;
			this.Fecha = fecha;
			this.TRIAL609 = trial609;
		}
	}
}
