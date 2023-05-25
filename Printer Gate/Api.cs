using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace PrinterGateXP
{
	internal static class Api
	{

		//[Obsolete("Do not use this in Production code!!!", true)]
		static void NEVER_EAT_POISON_Disable_CertificateValidation()
		{
			// Disabling certificate validation can expose you to a man-in-the-middle attack
			// which may allow your encrypted message to be read by an attacker
			// https://stackoverflow.com/a/14907718/740639
			ServicePointManager.ServerCertificateValidationCallback =
				delegate (
					object s,
					X509Certificate certificate,
					X509Chain chain,
					SslPolicyErrors sslPolicyErrors
				) {
					return true;
				};
		}

		public static T Request<T>(string url, string method = "GET", Dictionary<string, string> payload = null)
		{
			//System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3;

			/* 
			 * Ssl3		48		0x30
			 * SystemDefault	0
			 * Tls		192		0xC0
			 * Tls11	768		0x300
			 * Tls12	3072	0xC00
			 * Tls13	12288	0x3000
			 */
			SslProtocols _Tls12 = (SslProtocols)0x00000C00;

			if(AppConfig.appConfig.tlsVersion == 0) {
				_Tls12 = (SslProtocols)0x300;
			} else if (AppConfig.appConfig.tlsVersion == 1) {
				_Tls12 = (SslProtocols)0xC00;
			} else if (AppConfig.appConfig.tlsVersion == 2) {
				_Tls12 = (SslProtocols)0x3000;
			}

			SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
			ServicePointManager.SecurityProtocol = Tls12;

		T result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Timeout = 5000;
				httpWebRequest.Method = method.ToLower();
				httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
				if (payload != null)
				{
					httpWebRequest.ContentType = "application/json";
					string value = JsonConvert.SerializeObject(payload);
					using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
					{
						streamWriter.Write(value);
					}
				}
				if (MainFormAdvanced.localServerTest)
					NEVER_EAT_POISON_Disable_CertificateValidation();

				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							result = JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
						}
					}
				}
			}
			catch (Exception)
			{
				result = default(T);
			}
			return result;
		}
	}
}
