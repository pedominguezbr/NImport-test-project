using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NImport.Dom.Ent
{
	[DataContract()]
	public partial class DeGuiaEnt
	{
		#region Private Properties
		private TIENDAEnt art_id;
		private GuiaEnt enc_id;
		private string tem_nomb = string.Empty;
		private double? cantidad = 0;
		private double? precio = 0;
		private double? predescto = 0;
		private double? descuento = 0;
		private double? tem_subt = 0;
		private string trial556 = string.Empty;
		#endregion

		#region Public Properties

		[DataMember()]
		public TIENDAEnt ART_ID
		{
			get { return this.art_id; }
			set { this.art_id = value; }
		}

		[DataMember()]
		public GuiaEnt ENC_ID
		{
			get { return this.enc_id; }
			set { this.enc_id = value; }
		}

		[DataMember()]
		public string TEM_NOMB
		{
			get { return this.tem_nomb; }
			set { this.tem_nomb = value; }
		}

		[DataMember()]
		public double? CANTIDAD
		{
			get { return this.cantidad; }
			set { this.cantidad = value; }
		}

		[DataMember()]
		public double? PRECIO
		{
			get { return this.precio; }
			set { this.precio = value; }
		}

		[DataMember()]
		public double? Predescto
		{
			get { return this.predescto; }
			set { this.predescto = value; }
		}

		[DataMember()]
		public double? Descuento
		{
			get { return this.descuento; }
			set { this.descuento = value; }
		}

		[DataMember()]
		public double? TEM_SUBT
		{
			get { return this.tem_subt; }
			set { this.tem_subt = value; }
		}

		[DataMember()]
		public string TRIAL556
		{
			get { return this.trial556; }
			set { this.trial556 = value; }
		}
		#endregion

		public DeGuiaEnt() { }

		public DeGuiaEnt(TIENDAEnt art_id, GuiaEnt enc_id, string tem_nomb, double? cantidad, double? precio, double? predescto, double? descuento, double? tem_subt, string trial556)
		{
			this.ART_ID = art_id;
			this.ENC_ID = enc_id;
			this.TEM_NOMB = tem_nomb;
			this.CANTIDAD = cantidad;
			this.PRECIO = precio;
			this.Predescto = predescto;
			this.Descuento = descuento;
			this.TEM_SUBT = tem_subt;
			this.TRIAL556 = trial556;
		}
	}
}
