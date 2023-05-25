using System;
using System.Collections.Generic;

namespace PrinterGateXP
{
	internal struct ApiData<T>
	{
		public string count;
		public long cur_ts;
		public List<T> data;
		public int success;
	}
}
