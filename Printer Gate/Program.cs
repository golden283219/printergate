using System;
using System.Diagnostics;
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
                    string exePath = @"update.exe";
                    try
                    {
                        Process process = new Process();
                        // Set the process start information
                        process.StartInfo.FileName = exePath;

                        // Start the process
                        process.Start();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    finally
                    {

                    }
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
