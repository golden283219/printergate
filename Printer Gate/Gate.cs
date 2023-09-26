using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrinterGateXP
{
	
	internal class Gate
	{
		public event EventHandler GateInitialized;
		public static Gate Instance
		{
			get
			{
				return Gate._instance;
			}
		}

		public string Host
		{
			set
			{
				this.host = value;
			}
		}

		public bool IsOnline
		{
			get
			{
				return (DateTime.Now - Gate.lastConnectionTime).TotalSeconds < (double)AppConfig.appConfig.connectionTimeout;
			}
		}

		public bool IsApiInstalled
		{
			get
			{
				return this.tkMenus.Count != 0;
			}
		}


		private void resetLastConnectionTime()
		{
			Gate.lastConnectionTime = DateTime.Now;
		}

		
		public void Init()
		{
			long num = this.tmFrom;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("app", APP_VIKRESTAURANT);
			dictionary.Add("resource", RESOURCE_RESERVATION);
			dictionary.Add("format", FORMAT_RAW);
			dictionary.Add("type", TYPE_RESTAURANT);
			ApiResponse<RestaurantOrder> apiResponse = Api.Request<ApiResponse<RestaurantOrder>>(UrlUtil.MakeUrl(this.host, dictionary), "GET", null);
			num = ((apiResponse.api != null) ? apiResponse.data.cur_ts : 0L);
			if (this.tmFrom == 0L)
			{
				this.LoadTkMenus();
			}
			this.tmFrom = num;
			EventHandler gateInitialized = this.GateInitialized;
			if (gateInitialized == null)
			{
				return;
			}
			gateInitialized(null, null);
		}

		
		public void LoadTkMenus()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("app", APP_VIKRESTAURANT);
			dictionary.Add("type", TYPE_RESTAURANT);
			dictionary.Add("resource", RESOURCE_TKMENUS);
			ApiResponse<TKMenu> apiResponse = Api.Request<ApiResponse<TKMenu>>(UrlUtil.MakeUrl(this.host, dictionary), "GET", null);
			if (apiResponse.api != null && apiResponse.err_code != "404")
			{
				this.tkMenus = apiResponse.data.data;
			}
		}

		
		public bool SendMessage(string id, OrderType type, string message)
		{
			string value;
			if (type != OrderType.Table)
			{
				if (type != OrderType.Food)
				{
					return false;
				}
				value = TYPE_TAKEAWAY;
			}
			else
			{
				value = TYPE_RESTAURANT;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("app", APP_VIKRESTAURANT);
			dictionary.Add("resource", RESOURCE_EMAIL);
			dictionary.Add("type", value);
			dictionary.Add("id", id);
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2.Add("message", message);
			return Api.Request<ApiResponse<string>>(UrlUtil.MakeUrl(this.host, dictionary), "post", dictionary2).api != null;
		}

		
		public bool ChangeOrderState(string id, OrderType type, string state)
		{
			string value;
			if (type != OrderType.Table)
			{
				if (type != OrderType.Food)
				{
					return false;
				}
				value = TYPE_TAKEAWAY;
			}
			else
			{
				value = TYPE_RESTAURANT;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("app", APP_VIKRESTAURANT);
			dictionary.Add("resource", RESOURCE_RESERVATION);
			dictionary.Add("format", FORMAT_RAW);
			dictionary.Add("type", value);
			dictionary.Add("action", state);
			dictionary.Add("id", id);
			ApiResponse<string> apiResponse = Api.Request<ApiResponse<string>>(UrlUtil.MakeUrl(this.host, dictionary), "put", null);
			return apiResponse.api != null && apiResponse.data.success == 1;
		}

		
		public List<string> ListTakeAwayOrderFoodCategories(string id)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("app", APP_VIKRESTAURANT);
			dictionary.Add("resource", RESOURCE_TKMENUS);
			dictionary.Add("id", id);
			ApiResponse<string> apiResponse = Api.Request<ApiResponse<string>>(UrlUtil.MakeUrl(this.host, dictionary), "GET", null);
			if (apiResponse.api == null)
			{
				return new List<string>();
			}
			return apiResponse.data.data;
		}

		
		public string ReservationHtml(OrderType orderType, string orderId, List<string> tkMenuIds = null)
		{
			string value = "";
			if (orderType != OrderType.Table)
			{
				if (orderType == OrderType.Food)
				{
					value = TYPE_TAKEAWAY;
				}
			}
			else
			{
				value = TYPE_RESTAURANT;
			}
			GateUrl gateUrl = new GateUrl(this.host);
			gateUrl.AddParam("app", APP_VIKRESTAURANT);
			gateUrl.AddParam("resource", RESOURCE_PRINTORDERS);
			gateUrl.AddParam("format", FORMAT_RAW);
			gateUrl.AddParam("type", value);
			gateUrl.AddParam("cid[]", orderId);
			if (orderType == OrderType.Food && tkMenuIds != null)
			{
				foreach (string value2 in tkMenuIds)
				{
					gateUrl.AddParam("tkmenuids[]", value2);
				}
			}
			PrintApiResponse printApiResponse = Api.Request<PrintApiResponse>(gateUrl.Url, "GET", null);
			if (printApiResponse.api == null)
			{
				return "";
			}
			return printApiResponse.data.output;
		}

		
		public List<Order> QueryOrders()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("app", APP_VIKRESTAURANT);
			dictionary.Add("resource", RESOURCE_RESERVATION);
			dictionary.Add("format", FORMAT_RAW);
			dictionary.Add("type", TYPE_RESTAURANT);
			//dictionary.Add("status", STATUS_PENDING);
			ApiResponse<RestaurantOrder> apiResponse = Api.Request<ApiResponse<RestaurantOrder>>(UrlUtil.MakeUrl(this.host, dictionary), "GET", null);
			if (apiResponse.api == null)
			{
				return new List<Order>();
			}
			dictionary.Remove("type");
			dictionary.Add("type", TYPE_TAKEAWAY);
			ApiResponse<TakeAwayOrder> apiResponse2 = Api.Request<ApiResponse<TakeAwayOrder>>(UrlUtil.MakeUrl(this.host, dictionary), "GET", null);
			if (this.tmFrom == 0L)
			{
				this.tmFrom = ((apiResponse2.api != null) ? apiResponse2.data.cur_ts : 0L);
			}
			if (apiResponse2.api == null)
			{
				return new List<Order>();
			}
			List<RestaurantOrder> data = apiResponse.data.data;
			List<TakeAwayOrder> data2 = apiResponse2.data.data;
			List<Order> list = new List<Order>();
			foreach (RestaurantOrder rawOrder in data)
			{
				Order order = this.orderFromRawRestaurantOrderObject(rawOrder);
				if (order.status != OrderStatus.Removed && !Utils.isOrderPast30Min(order))
				{
					list.Add(order);
				}
			}
			foreach (TakeAwayOrder rawOrder2 in data2)
			{
				Order order = this.orderFromRawTakeAwayOrderObject(rawOrder2);
				if (order.status != OrderStatus.Removed && !Utils.isOrderPast30Min(order))
				{
					list.Add(order);
					string text = this.ReservationHtml(order.orderType, order.id, null);
					if (text.Length > 0)
					{
						Utils.getTakeAwayItemDetails(text, order);
					}
				}
			}
			this.resetLastConnectionTime();
			
			return list;
		}

		
		private Order orderFromRawRestaurantOrderObject(RestaurantOrder rawOrder)
		{
			RestaurantOrderCustomF restaurantOrderCustomF = JsonConvert.DeserializeObject<RestaurantOrderCustomF>(rawOrder.custom_f);
			return new Order
			{
				id = rawOrder.id,
				orderType = OrderType.Table,
				status = this.orderStatus(rawOrder.status),
				printStatus = PrintStatus.Pending,
				name = restaurantOrderCustomF.CUSTOMF_NAME + " " + restaurantOrderCustomF.CUSTOMF_LNAME,
				email = restaurantOrderCustomF.CUSTOMF_EMAIL,
				phone = restaurantOrderCustomF.CUSTOMF_PHONE,
				people = rawOrder.people,
				date = rawOrder.created_on,
				date_checkin = rawOrder.checkin_ts,
			};
		}

		
		private Order orderFromRawTakeAwayOrderObject(TakeAwayOrder rawOrder)
		{
			TakeAwayOrderCustomF takeAwayOrderCustomF = JsonConvert.DeserializeObject<TakeAwayOrderCustomF>(rawOrder.custom_f);
			return new Order
			{
				id = rawOrder.id,
				orderType = OrderType.Food,
				status = this.orderStatus(rawOrder.status),
				printStatus = PrintStatus.Pending,
				name = takeAwayOrderCustomF.CUSTOMF_TKNAME,
				email = takeAwayOrderCustomF.CUSTOMF_TKEMAIL,
				phone = takeAwayOrderCustomF.CUSTOMF_TKPHONE,
				zipCode = takeAwayOrderCustomF.CUSTOMF_TKZIP,
				address = takeAwayOrderCustomF.CUSTOMF_TKADDRESS,
                notes = rawOrder.notes,
                date = rawOrder.created_on,
				date_checkin = rawOrder.checkin_ts,

			};
		}

		
		private OrderStatus orderStatus(string status)
		{
			if (status == "CONFIRMED")
			{
				return OrderStatus.Confirmed;
			}
			if (status == "PENDING")
			{
				return OrderStatus.Pending;
			}
			if (!(status == "REMOVED"))
			{
				return OrderStatus.Pending;
			}
			return OrderStatus.Removed;
		}

		
		private const string APP_VIKRESTAURANT = "vikrestaurants";

		
		private const string RESOURCE_RESERVATION = "reservation";

		
		private const string RESOURCE_TKMENUS = "tkmenus";

		private const string RESOURCE_PRINTORDERS = "printorders";

		private const string RESOURCE_EMAIL = "email";

		private const string TYPE_RESTAURANT = "restaurant";

		private const string TYPE_TAKEAWAY = "takeaway";

		private const string FORMAT_RAW = "raw";

		public const string ACTION_CONFIRM = "confirm";

		public const string ACTION_PRINTED = "printed";

		private const string STATUS_PENDING = "pending";

		private const string STATUS_CONFIRMED = "confirmed";

		private const string STATUS_REMOVED = "removed";

		public List<TKMenu> tkMenus = new List<TKMenu>();

		private string host;

		private long tmFrom;

		public static DateTime lastConnectionTime = DateTime.Now;

		private static Gate _instance = new Gate();
	}
}
