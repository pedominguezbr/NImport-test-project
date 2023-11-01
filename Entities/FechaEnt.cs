using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class FechaEnt
	{
		#region Private Properties
		private DateTime? fecha1 = null;
		private DateTime? fecha2 = null;
		private string trial625 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public DateTime? Fecha1
		{
			get { return this.fecha1; }
			set { this.fecha1 = value; }
		}

		[DataMember()]
		public DateTime? Fecha2
		{
			get { return this.fecha2; }
			set { this.fecha2 = value; }
		}

		[DataMember()]
		public string TRIAL625
		{
			get { return this.trial625; }
			set { this.trial625 = value; }
		}
		#endregion

		public FechaEnt() { }

		public FechaEnt(DateTime? fecha1, DateTime? fecha2, string trial625)
		{
			this.Fecha1 = fecha1;
			this.Fecha2 = fecha2;
			this.TRIAL625 = trial625;
		}
	}
}
