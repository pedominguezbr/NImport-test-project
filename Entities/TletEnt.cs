using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class TletEnt
	{
		#region Private Properties
		private string letras = string.Empty;
		private string trial723 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public string Letras
		{
			get { return this.letras; }
			set { this.letras = value; }
		}

		[DataMember()]
		public string TRIAL723
		{
			get { return this.trial723; }
			set { this.trial723 = value; }
		}
		#endregion

		public TletEnt() { }

		public TletEnt(string letras, string trial723)
		{
			this.Letras = letras;
			this.TRIAL723 = trial723;
		}
	}
}
