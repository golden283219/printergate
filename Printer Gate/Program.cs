using System;
using System.Threading;
using System.Windows.Forms;

namespace PrinterGateXP
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			using (Mutex mutex = new Mutex(false, "Printer Gate"))
			{
				if (!mutex.WaitOne(TimeSpan.Zero))
				{
					MessageBox.Show("Another Print Gate instance is running.");
				}
				else
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					//Application.Run(new MainForm());
					Application.Run(new MainFormAdvanced());
					mutex.ReleaseMutex();
				}
			}
		}
	}
}
