using System;
using System.Collections.Generic;

namespace PrinterGateXP
{
	
	internal class GatePrinter
	{
		public GatePrinter(string categoryName = "", string printerName = "", List<string> categories = null, bool editEnabled = true)
		{
			this.categoryName = categoryName;
			this.printerName = printerName;
			this.editEnabled = editEnabled;
			this.tkMenuIds = ((categories != null) ? categories : new List<string>());
		}

	
		public string categoryName;
	
		public string printerName;

		public bool editEnabled;

		public List<string> tkMenuIds;
	}
}
