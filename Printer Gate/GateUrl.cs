using System;
using System.Collections.Generic;

namespace PrinterGateXP
{
	internal class GateUrl
	{
		public GateUrl(string host)
		{
			this.host = host;
		}

		public void AddParam(string key, string value)
		{
			this.paramList.Add(new KeyValuePair<string, string>(key, value));
		}

		public string Url
		{
			get
			{
				return UrlUtil.MakeUrl(this.host, this.paramList);
			}
		}

		private string host;

		private List<KeyValuePair<string, string>> paramList = new List<KeyValuePair<string, string>>();
	}
}
