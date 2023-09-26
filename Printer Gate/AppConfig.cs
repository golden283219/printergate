using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace PrinterGateXP
{
	
	internal class AppConfig
	{
	
		public static void LoadSettings()
		{
			AppConfig.appConfig = new AppConfig();
			AppConfig.CONFIG_PATH = AppConfig.appDir + "/Printer Gate/config.json";
			string strDefaultXmlPath = AppConfig.appDir + "\\Printer Gate " + "\\orders.xml";
			if (!File.Exists(AppConfig.CONFIG_PATH))
			{
				AppConfig.appConfig.host = AppConfig.DEFAULT_SERVER;
				AppConfig.appConfig.hostUpdate = AppConfig.DEFAULT_SERVER;
                AppConfig.appConfig.welcomeRestaurantMessage = "{greetings} {name}.{br}Wir möchten Ihren Besuch verdanken und wünschen Ihnen einen schönen Aufenthalt in unserem Restaurant.";
				AppConfig.appConfig.haveNiceMealMessage = "{greetings} {name}.{br}Wir möchten Ihnen für die Bestellung danken und wünschen Ihnen guten Appetit.";
				AppConfig.appConfig.welcomeHotelMessage = "{greetings} {name}.{br}Willkommen in unserem Hotel. Wir wünschen Ihnen einen angenehmen Aufenthalt.";
				AppConfig.appConfig.declineRestaurantMessage = "{greetings} {name}.{br}Leider können wir Îhnen keinen Tisch zu dieser Uhrzeit anbieten. Bitte wählen Sie eine andere Uhrzeit oder rufen uns an.";
				AppConfig.appConfig.declineTakeAwayMessage = "{greetings} {name}.{br}Leider können wir Ihre Bestellung nicht annehmen. Wenn Sie mehr erfahren möchten, bitten wir Sie uns anzurufen.";
				AppConfig.appConfig.declineHotelMessage = "{greetings} {name}.{br}Leider können wir Ihre Buchung nicht annehmen. Wenn Sie mehr erfahren möchten, bitten wir Sie uns anzurufen.";
				AppConfig.appConfig.sorryTakeAwayMessage = AppConfig.DEFAULT_SORRY_TAKE_AWAY;
				AppConfig.appConfig.sorryTableReservationMessage = AppConfig.DEFAULT_SORRY_TABLE_RESERVATION;
				AppConfig.appConfig.exportToXMLEnabled = false;
				AppConfig.appConfig.exportToXMLPath = strDefaultXmlPath;
				AppConfig.appConfig.showBalloon = true;
				AppConfig.appConfig.alarmLostConnectionEnabled = true;
				AppConfig.appConfig.lostConnectionAlarmIndex = 0;
				AppConfig.appConfig.lostConnectionAlarmVolume = 100;
				AppConfig.appConfig.lostConnectionAlarmPath = "";
				AppConfig.appConfig.welcomeMessageEnabled = true;
				AppConfig.appConfig.addAddressEnabled = false;
				AppConfig.appConfig.tableReservationPopupEnabled = true;
				AppConfig.appConfig.tableReservationAlarmEnabled = true;
				AppConfig.appConfig.tableReservationAlarmIndex = 1;
				AppConfig.appConfig.tableReservationAlarmVolume = 100;
				AppConfig.appConfig.tableReservationAlarmPath = "";
				AppConfig.appConfig.foodReservationPopupEnabled = true;
				AppConfig.appConfig.foodReservationAlarmEnabled = true;
				AppConfig.appConfig.foodReservationAlarmIndex = 2;
				AppConfig.appConfig.foodReservationAlarmVolume = 100;
				AppConfig.appConfig.foodReservationAlarmPath = "";
				AppConfig.appConfig.hotelReservationPopupEnabled = true;
				AppConfig.appConfig.hotelReservationAlarmEnabled = true;
				AppConfig.appConfig.hotelReservationAlarmIndex = 3;
				AppConfig.appConfig.hotelReservationAlarmVolume = 100;
				AppConfig.appConfig.hotelReservationAlarmPath = "";
				AppConfig.appConfig.autoConfimTakeAway = true;
				AppConfig.appConfig.printTKAnyway = true;
				AppConfig.appConfig.autoConfirmReservation = true;
				AppConfig.appConfig.printReservationAnyway = true;
				AppConfig.appConfig.printReservationWithBeautyWhenConfirmed = true;
				AppConfig.appConfig.showPrinterDialog = false;
				AppConfig.appConfig.closePopupAfter = 2;
				AppConfig.appConfig.reOpenPopupAfter = 30;
				AppConfig.appConfig.connectionTimeout = 20;
				AppConfig.appConfig.startupDelay = 60;
				AppConfig.appConfig.tlsVersion = 1;
				AppConfig.appConfig.lang = "en";
				AppConfig.SaveSettings();
			}
			using (StreamReader streamReader = new StreamReader(AppConfig.CONFIG_PATH))
			{
				AppConfig.appConfig = JsonConvert.DeserializeObject<AppConfig>(streamReader.ReadToEnd());
				if (AppConfig.appConfig.startupDelay == 0)
				{
					AppConfig.appConfig.startupDelay = 60;
				}
				if (AppConfig.appConfig.lang == null)
				{
					AppConfig.appConfig.lang = "en";
				}
				if (AppConfig.appConfig.sorryTakeAwayMessage == null)
				{
					AppConfig.appConfig.sorryTakeAwayMessage = AppConfig.DEFAULT_SORRY_TAKE_AWAY;
				}
				if (AppConfig.appConfig.sorryTableReservationMessage == null)
				{
					AppConfig.appConfig.sorryTableReservationMessage = AppConfig.DEFAULT_SORRY_TABLE_RESERVATION;
				}
				if (AppConfig.appConfig.exportToXMLPath == null)
				{
					AppConfig.appConfig.exportToXMLPath = strDefaultXmlPath;
				}
			}
			string path = AppConfig.PrinterConfigPath();
			if (!File.Exists(path))
			{
				AppConfig.appConfig.gatePrinters = new List<GatePrinter>();
				AppConfig.appConfig.gatePrinters.Add(new GatePrinter(AppConfig.TABLE_RESERVATION_PRINTER, "", null, false));
				AppConfig.appConfig.gatePrinters.Add(new GatePrinter(AppConfig.BEAUTIFUL_PRINTER, "", null, false));
				AppConfig.SavePrinterConfig();
			}
			using (StreamReader streamReader2 = new StreamReader(path))
			{
				string value = streamReader2.ReadToEnd();
				AppConfig.appConfig.gatePrinters = JsonConvert.DeserializeObject<List<GatePrinter>>(value);
			}
		}

		
		public GatePrinter FindPrinter(string categoryName)
		{
			int count = AppConfig.appConfig.gatePrinters.Count;
			for (int i = 0; i < count; i++)
			{
				if (AppConfig.appConfig.gatePrinters[i].categoryName == categoryName)
				{
					return AppConfig.appConfig.gatePrinters[i];
				}
			}
			return null;
		}

		
		public List<TKMenu> FindRemainingMenus()
		{
			Gate instance = Gate.Instance;
			List<string> list = new List<string>();
			foreach (GatePrinter gatePrinter in AppConfig.appConfig.gatePrinters)
			{
				foreach (string item in gatePrinter.tkMenuIds)
				{
					list.Add(item);
				}
			}
			List<TKMenu> list2 = new List<TKMenu>();
			using (List<TKMenu>.Enumerator enumerator3 = instance.tkMenus.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					TKMenu tkMenu = enumerator3.Current;
					if (list.FindIndex((string id) => id == tkMenu.id) == -1)
					{
						list2.Add(tkMenu);
					}
				}
			}
			return list2;
		}

		
		public static void SaveSettings()
		{
			string value = JsonConvert.SerializeObject(AppConfig.appConfig, Formatting.Indented);
			if (!File.Exists(AppConfig.CONFIG_PATH))
			{
				Directory.CreateDirectory(AppConfig.appDir + "/Printer Gate");
			}
			using (StreamWriter streamWriter = new StreamWriter(AppConfig.CONFIG_PATH))
			{
				streamWriter.Write(value);
			}
		}

		
		public static void SavePrinterConfig()
		{
			string path = AppConfig.PrinterConfigPath();
			if (!File.Exists(path))
			{
				Directory.CreateDirectory(AppConfig.appDir + "/Printer Gate");
			}
			string value = JsonConvert.SerializeObject(AppConfig.appConfig.gatePrinters, Formatting.Indented);
			using (StreamWriter streamWriter = new StreamWriter(path))
			{
				streamWriter.Write(value);
			}
		}

		private static string PrinterConfigPath()
		{
			//string str = AppConfig.appConfig.host.Substring("https://".Length, AppConfig.appConfig.host.Length - 8);
			string str = AppConfig.appConfig.host;
			str = str.Replace("https://", "");
			str = str.Replace("/", "");
			return AppConfig.appDir + "/Printer Gate/" + str + "-printer.json";
		}

		public static AppConfig appConfig;

		public static int DEFAULT_ALARM_COUNT = 13;
		//https://tls.weratv.ch/
		private static string DEFAULT_SERVER = "https://test.waage-flamatt.ch";

		private static string CONFIG_PATH = "config.json";

		public static string TABLE_RESERVATION_PRINTER = "Table";

		public static string ROOM_RESERVATION_PRINTER = "Room";

		public static string BEAUTIFUL_PRINTER = "Beautiful";

		public static string DEFAULT_SORRY_TABLE_RESERVATION = "{greetings} {name}.{br}Im Moment haben wir viele Gäste und Reservierungen. Es kann deshalb zu Wartezeiten kommen. Bitte entschuldigen Sie dies.";

		public static string DEFAULT_SORRY_TAKE_AWAY = "{greetings} {name}.{br}Im Moment haben wir viele Gäste und viele Bestellungen. Deshalb kann es zu Wartezeiten kommen. Bitte entschuldigen Sie dies.";

		private static string appDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		public string host;

        public string hostUpdate;

        public string welcomeRestaurantMessage;

		public string haveNiceMealMessage;

		public string welcomeHotelMessage;

		public string declineRestaurantMessage;

		public string declineTakeAwayMessage;

		public string declineHotelMessage;

		public string sorryTakeAwayMessage;

		public string sorryTableReservationMessage;

		public bool exportToXMLEnabled;
		public string exportToXMLPath;

		public bool showBalloon;

		
		public bool alarmLostConnectionEnabled;

		public int lostConnectionAlarmVolume;

		public int lostConnectionAlarmIndex;

		public string lostConnectionAlarmPath;

		public bool welcomeMessageEnabled;

		public bool addAddressEnabled;

		public bool tableReservationPopupEnabled;

		public bool tableReservationAlarmEnabled;

		public int tableReservationAlarmVolume;

		public int tableReservationAlarmIndex;

		public string tableReservationAlarmPath;

		public bool foodReservationPopupEnabled;

		public bool foodReservationAlarmEnabled;

		public int foodReservationAlarmVolume;

		public int foodReservationAlarmIndex;

		public string foodReservationAlarmPath;

		public bool hotelReservationPopupEnabled;

		public bool hotelReservationAlarmEnabled;

		public int hotelReservationAlarmVolume;

		public int hotelReservationAlarmIndex;

		public string hotelReservationAlarmPath;

		public bool autoConfimTakeAway;

		public bool printTKAnyway;

		public bool autoConfirmReservation;

		public bool printReservationAnyway;

		public bool printReservationWithBeautyWhenConfirmed;

		public bool showPrinterDialog;

		public int closePopupAfter;

		public int reOpenPopupAfter;

		public int connectionTimeout;

		public int startupDelay;

		public int tlsVersion = 1;

		public string lang;

		public List<GatePrinter> gatePrinters;
	}
}
