using System;
using System.Windows.Forms;

namespace PrinterGateXP
{
	public static class Prompt
	{
		public static string GetUserInput(string prompt, string caption, string defaultValue = "")
		{
			PromptForm promptForm = new PromptForm(prompt, caption, defaultValue);
			if (promptForm.ShowDialog() != DialogResult.OK)
			{
				return null;
			}
			return promptForm.result;
		}
	}
}
