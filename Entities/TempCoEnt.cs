using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TempCoEnt
	{
		#region Private Properties
		private string letras = string.Empty;
		private string trial713 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string LETRAS
		{
			get { return this.letras; }
			set { this.letras = value; }
		}

		[DataMember()]
		public string TRIAL713
		{
			get { return this.trial713; }
			set { this.trial713 = value; }
		}
		#endregion

		public TempCoEnt() { }

		public TempCoEnt(string letras, string trial713)
		{
			this.LETRAS = letras;
			this.TRIAL713 = trial713;
		}
	}
}
