using System;
using System.Collections.Generic;
namespace PrinterGateXP
{
	public class Order
	{
		//public string date
		public string date;  //create time - this is timestamp string

		public string id;

		public string name;

		public OrderType orderType;

		public string phone;

		public string email;

		public OrderStatus status;

		public PrintStatus printStatus;

		public string zipCode;

		public string address;

		public TakeAwayItemDetails orderItemDetails;//public string orderInfo;
		public string date_checkin;  //order reservation time - this is timestamp string

		public bool welcomeMessageSent;

		public bool sorryMessageSent;

		
	}
}
