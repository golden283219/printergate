using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrinterGateXP
{
    class TicketTable
    {
        private FlowLayoutPanel container;
		private List<TicketItem> ticketItemList = new List<TicketItem>();
		private List<Order> orderList = new List<Order>();
		
		private int orderCount = 0;
		public TicketTable(FlowLayoutPanel container)
        {
            this.container = container;
			container.Controls.Clear();

		}

		public void Localize()
		{
			foreach (TicketItem ticketItem in this.ticketItemList)
			{
				ticketItem.Localize();
			}
		}

		public void SetOrderList(List<Order> orderList)
		{
			container.Controls.Clear();
			this.ticketItemList.Clear();
			this.orderList.Clear();
			this.orderCount = 0;
			foreach (Order order in orderList)
			{
				DateTime current = DateTime.Now;
				DateTime date = Utils.UnixTimeStampToDateTime(order.date_checkin);
				
                if (DateTime.Compare(date, current) <= 0)
				{
                    AddOrder(order);
                }
				//AddOrder(order);
			}

		}
		public void AddOrder(Order order)
		{
			TicketItem ticketItem = new TicketItem();
			ticketItem.SetOrder(this.orderCount, order);
			this.container.Controls.Add(ticketItem);//this.tableLayoutOrders.Controls.Add(orderItem, 0, this.orderCount + 2);
			//ticketItem.Dock = DockStyle.Fill;
			this.orderCount++;
			this.ticketItemList.Add(ticketItem);
			this.orderList.Add(order);
		}

		public bool RemoveOrder(Order order)
		{
			bool result = false;
			//find
			TicketItem itemToRemove = null;
			foreach(TicketItem item in this.ticketItemList)
            {
				if (order.id.Equals((string)item.Tag))
				{
					itemToRemove = item;
					break;
				}

            }
			if (itemToRemove != null)
			{
				this.container.Controls.Remove(itemToRemove);
				this.orderCount--;
				this.orderList.Remove(order);
				this.ticketItemList.Remove(itemToRemove);
				result = true;
			}
			return result;
		}

		public void UpdateOrderStatus(string orderId, OrderStatus status)
		{
			int num = this.orderList.FindIndex((Order order) => order.id == orderId);
			if (num < 0 || num >= this.ticketItemList.Count)
			{
				return;
			}
			this.ticketItemList[num].UpdateOrderStatus(status);
		}

		public void UpdateOrderPrintStatus(string orderId, PrintStatus status)
		{
			int num = this.orderList.FindIndex((Order order) => order.id == orderId);
			if (num < 0 || num >= this.ticketItemList.Count)
			{
				return;
			}
			this.ticketItemList[num].UpdateOrderPrintStatus(status);
		}
	}
}
