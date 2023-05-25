using System;
using System.IO;

namespace PrinterGateXP
{
	internal static class Logger
	{
		public static void Log(string message)
		{
			using (StreamWriter streamWriter = File.AppendText("log.txt"))
			{
				string str = DateTime.Now.ToLongTimeString();
				streamWriter.WriteLine(str + ": " + message + "\n");
			}
		}
	}
}
