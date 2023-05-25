using System;
using System.Collections.Generic;

namespace PrinterGateXP
{
	internal static class UrlUtil
	{
		[Obsolete("MakeUrl from dictParams is deprecated. using MakeUrl with listParams")]
		public static string MakeUrl(string host, Dictionary<string, string> dictParams)
		{
			string text = host + "/index.php";
			text = UrlUtil.addUrlParam(text, "option", "com_api");
			foreach (KeyValuePair<string, string> keyValuePair in dictParams)
			{
				text = UrlUtil.addUrlParam(text, keyValuePair.Key, keyValuePair.Value);
			}
			return text;
		}

		public static string MakeUrl(string host, List<KeyValuePair<string, string>> listParams)
		{
			string text = host + "/index.php";
			text = UrlUtil.addUrlParam(text, "option", "com_api");
			foreach (KeyValuePair<string, string> keyValuePair in listParams)
			{
				text = UrlUtil.addUrlParam(text, keyValuePair.Key, keyValuePair.Value);
			}
			return text;
		}

		private static string addUrlParam(string url, string paramName, string paramValue)
		{
			if (paramValue == null)
			{
				return url;
			}
			if (url.EndsWith("index.php"))
			{
				return string.Concat(new string[]
				{
					url,
					"?",
					paramName,
					"=",
					paramValue
				});
			}
			return string.Concat(new string[]
			{
				url,
				"&",
				paramName,
				"=",
				paramValue
			});
		}
	}
}
