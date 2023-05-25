using System;

namespace PrinterGateXP
{
	internal static class StringUtils
	{
		public static string Greetings()
		{
			int hour = DateTime.Now.Hour;
			if (hour >= 8 && hour < 12)
			{
				return Localization.Translation("good_morning");
			}
			if (hour >= 12 && hour < 18)
			{
				return Localization.Translation("good_afternoon");
			}
			if (hour >= 18 && hour < 24)
			{
				return Localization.Translation("good_evening");
			}
			return "";
		}
	}
}
