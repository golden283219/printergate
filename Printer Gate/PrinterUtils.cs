using System;
using System.Management;

namespace PrinterGateXP
{
	internal static class PrinterUtils
	{
		public static string GetDefaultPrinterName()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(new ObjectQuery("SELECT * FROM Win32_Printer")).Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (((bool?)managementObject["Default"]).GetValueOrDefault())
				{
					return managementObject["Name"] as string;
				}
			}
			return null;
		}

		public static bool SetDefaultPrinter(string defaultPrinter)
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						if (string.Compare(managementObject["Name"].ToString(), defaultPrinter, true) == 0)
						{
							managementObject.InvokeMethod("SetDefaultPrinter", null, null);
							return true;
						}
					}
				}
			}
			return true;
		}
	}
}
