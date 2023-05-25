using System;

namespace PrinterGateXP
{
	internal struct TKMenu
	{
		public override string ToString()
		{
			return this.title;
		}

		public string id;

		public string title;

		public string alias;

		public string description;

		public string published;

		public string publish_up;

		public string pubhlish_down;

		public string taxes_type;

		public string taxes_amount;

		public string ordering;
	}
}
