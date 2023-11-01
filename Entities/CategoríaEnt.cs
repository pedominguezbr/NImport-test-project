using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class CategoríaEnt
	{
		#region Private Properties
		private int cat_id;
		private string lin = string.Empty;
		private string trial543 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public int Cat_Id
		{
			get { return this.cat_id; }
			set { this.cat_id = value; }
		}

		[DataMember()]
		public string Lin
		{
			get { return this.lin; }
			set { this.lin = value; }
		}

		[DataMember()]
		public string TRIAL543
		{
			get { return this.trial543; }
			set { this.trial543 = value; }
		}
		#endregion

		public CategoríaEnt() { }

		public CategoríaEnt(int cat_id, string lin, string trial543)
		{
			this.Cat_Id = cat_id;
			this.Lin = lin;
			this.TRIAL543 = trial543;
		}
	}
}
