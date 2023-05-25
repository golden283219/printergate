using System;
using HtmlAgilityPack;
using System.Collections.Generic;
namespace PrinterGateXP
{
	internal static class Utils
	{
		public static string OrderStatusName(OrderStatus status)
		{
			switch (status)
			{
			case OrderStatus.Pending:
				return Localization.Translation("pending");
			case OrderStatus.Confirmed:
				return Localization.Translation("confirmed");
			case OrderStatus.Removed:
				return Localization.Translation("removed");
			default:
				return "";
			}
		}

		public static string OrderTypeName(OrderType type)
		{
			return Enum.GetName(typeof(OrderType), type);
		}

		public static string TrimForHtmlValue(string val)
        {
			return val.Trim(new char[] { '\n', '\r', '\t', ' ' }).Replace("&nbsp;", "");
		}
		public static string PrintStatusName(PrintStatus status)
		{
			if (status == PrintStatus.Pending)
			{
				return Localization.Translation("pending");
			}
			if (status - PrintStatus.PrintedBrief > 1)
			{
				return "";
			}
			return Localization.Translation("printed");
		}

		public static string PrinttedResultName(PrintStatus status)
		{
			if (status == PrintStatus.Printed || status == PrintStatus.PrintedBrief)
			{
				return Localization.Translation("yes");
			}
			return Localization.Translation("no");
		}


		public static bool isOrderPast30Min(Order order)
		{
			bool result = false;
			string str_checkin = Utils.UnixTimeStampToDateTime(order.date_checkin).ToString("dd.MM.yyyy H:mm");
			DateTime order_date = DateTime.ParseExact(str_checkin, "dd.MM.yyyy H:mm", System.Globalization.CultureInfo.InvariantCulture);
			DateTime now_date = DateTime.Now;
			long order_ticks = order_date.Ticks;
			long now_ticks = now_date.Ticks;
			if (DateTime.Now.Ticks - order_ticks > 30 * 60 * 1000)
				result = true;
			return result;
		}

        //get details of order items form html for print - refe to HtmlForPrint.html file
        public static void getTakeAwayItemDetails(string html_txt, Order order)
        {
            TakeAwayItemDetails tkAwayItemDetails = new TakeAwayItemDetails();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html_txt);
            //doc.DetectEncodingAndLoad("tkItems.html");

            HtmlNodeCollection divNodes = doc.DocumentNode.SelectNodes("//div");
            List<HtmlNode> divTkItemNodes = new List<HtmlNode>();
            List<HtmlNode> divTkFieldNodes = new List<HtmlNode>();
            HtmlNode tkTotalNode = null;
            if (divNodes != null)
            {
                foreach (HtmlNode node in divNodes)
                {
                    HtmlAttribute att = node.Attributes["class"];
                    if (att != null && att.Value == "tk-item")
                    {
                        divTkItemNodes.Add(node);
                    }
                    else if (att != null && att.Value == "tk-field")
                    {
                        divTkFieldNodes.Add(node);
                    }
                    else if (att != null && att.Value == "tk-total-row")
                    {
                        tkTotalNode = node;
                    }

                }
            }
            if (divTkItemNodes.Count > 0)
            {
                foreach (HtmlNode tkItemNode in divTkItemNodes)
                {
                    TakeAwayItem takeAwayItem = new TakeAwayItem();
                    foreach (HtmlNode childNode in tkItemNode.ChildNodes)
                    {
                        HtmlAttribute att = childNode.Attributes["class"];
                        if (att != null && att.Value == "tk-details")
                        {
                            foreach (HtmlNode value_node in childNode.ChildNodes)
                            {
                                att = value_node.Attributes["class"];
                                if (att != null && att.Value == "name") takeAwayItem.tk_details.name = value_node.InnerText;
                                if (att != null && att.Value == "quantity") takeAwayItem.tk_details.quantity = value_node.InnerText;
                                if (att != null && att.Value == "price") takeAwayItem.tk_details.price = value_node.InnerText;
                            }
                        }
                        else if (att != null && att.Value == "tk-toppings-cont")
                        {
                            foreach (HtmlNode group_node in childNode.ChildNodes)
                            {
                                att = group_node.Attributes["class"];
                                if (att != null && att.Value == "tk-toppings-group")
                                {
                                    TakeAwayToppingsGroup toppingsGroup = new TakeAwayToppingsGroup();
                                    foreach (HtmlNode value_node in group_node.ChildNodes)
                                    {

                                        att = value_node.Attributes["class"];
                                        if (att != null && att.Value == "title") toppingsGroup.title = Utils.TrimForHtmlValue(value_node.InnerText);
                                        if (att != null && att.Value == "toppings") toppingsGroup.toppings = Utils.TrimForHtmlValue(value_node.InnerText);
                                    }
                                    takeAwayItem.tk_toppings_cont.Add(toppingsGroup);
                                }
                            }
                        }
                    }
                    tkAwayItemDetails.items.Add(takeAwayItem);

                }

                if (tkTotalNode != null)
                {
                    foreach (HtmlNode value_node in tkTotalNode.ChildNodes)
                    {
                        HtmlAttribute att = value_node.Attributes["class"];
                        if (att != null && att.Value == "tk-label") tkAwayItemDetails.total.label = Utils.TrimForHtmlValue(value_node.InnerText);
                        if (att != null && att.Value == "tk-amount") tkAwayItemDetails.total.amount = Utils.TrimForHtmlValue(value_node.InnerText);
                    }
                }
            }
            order.orderItemDetails = tkAwayItemDetails;

        }
        public static DateTime UnixTimeStampToDateTime(string unixTimeStamp)
		{
			return Utils.UnixTimeStampToDateTime(double.Parse(unixTimeStamp));
		}

		
		public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
		{
			//DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds(unixTimeStamp).ToLocalTime();
			return result;
		}
	}
}
