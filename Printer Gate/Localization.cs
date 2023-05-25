using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace PrinterGateXP
{
	internal static class Localization
	{
		public static string Lang { get; set; } = AppConfig.appConfig.lang;

		static Localization()
		{
			using (StreamReader streamReader = new StreamReader("localization.json"))
			{
				Localization._data = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(streamReader.ReadToEnd());
			}
		}

		public static void ToggleLanguage()
		{
			Localization.Lang = ((Localization.Lang == Localization.EN) ? Localization.DE : Localization.EN);
		}

		public static string Translation(string key)
		{
			if (!Localization._data.ContainsKey(Localization.Lang) || (Localization._data.ContainsKey(Localization.Lang) && !Localization._data[Localization.Lang].ContainsKey(key)))
			{
				return key;
			}
			return Localization._data[Localization.Lang][key];
		}

		public static string EN = "en";

		public static string DE = "de";

		private static Dictionary<string, Dictionary<string, string>> _data = new Dictionary<string, Dictionary<string, string>>();
	}
}
