using System;

namespace PrinterGateXP
{
	internal struct PrintApiResponse
	{
		public string err_msg;

		public string err_code;

		public string response_id;

		public string api;

		public string version;

		public PrintOutput data;
	}
}
