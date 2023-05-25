using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PrinterGateXP
{
	public class OrdersTable : UserControl
	{
		public OrdersTable()
		{
			this.InitializeComponent();
			this.tableLayoutOrders.HorizontalScroll.Enabled = false;
			this.tableLayoutOrders.HorizontalScroll.Visible = false;
		}

		public void AddOrder(Order order)
		{
			this.tableLayoutOrders.RowStyles.Insert(this.orderCount + 2, new RowStyle(SizeType.Absolute, 40f));
			TableLayoutPanel tableLayoutPanel = this.tableLayoutOrders;
			int rowCount = tableLayoutPanel.RowCount;
			tableLayoutPanel.RowCount = rowCount + 1;
			OrderItem orderItem = new OrderItem();
			orderItem.SetOrder(this.orderCount, order);
			this.tableLayoutOrders.Controls.Add(orderItem, 0, this.orderCount + 2);
			this.tableLayoutOrders.SetColumnSpan(orderItem, 9);
			orderItem.Dock = DockStyle.Fill;
			this.orderCount++;
			this.orderItemList.Add(orderItem);
			this.orderList.Add(order);
		}

		public void UpdateOrderStatus(string orderId, OrderStatus status)
		{
			int num = this.orderList.FindIndex((Order order) => order.id == orderId);
			if (num == -1)
			{
				return;
			}
			this.orderItemList[num].UpdateOrderStatus(status);
		}

		public void UpdateOrderPrintStatus(string orderId, PrintStatus status)
		{
			int num = this.orderList.FindIndex((Order order) => order.id == orderId);
			if (num == -1)
			{
				return;
			}
			this.orderItemList[num].UpdateOrderPrintStatus(status);
		}

		public void Localize()
		{
			this.labelOrderNumber.Text = Localization.Translation("order_id");
			this.labelDate.Text = Localization.Translation("date_time");
			this.labelNamePhone.Text = Localization.Translation("name_phone");
			this.labelEmail.Text = Localization.Translation("email");
			this.labelStatus.Text = Localization.Translation("status");
			this.labelPrint.Text = Localization.Translation("print");
			foreach (OrderItem orderItem in this.orderItemList)
			{
				orderItem.Localize();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.tableLayoutOrders = new System.Windows.Forms.TableLayoutPanel();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNamePhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPrint = new System.Windows.Forms.Label();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.tableLayoutOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutOrders
            // 
            this.tableLayoutOrders.AutoScroll = true;
            this.tableLayoutOrders.AutoSize = true;
            this.tableLayoutOrders.ColumnCount = 11;
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutOrders.Controls.Add(this.labelOrderNumber, 0, 0);
            this.tableLayoutOrders.Controls.Add(this.labelDate, 1, 0);
            this.tableLayoutOrders.Controls.Add(this.labelNamePhone, 2, 0);
            this.tableLayoutOrders.Controls.Add(this.labelEmail, 3, 0);
            this.tableLayoutOrders.Controls.Add(this.labelStatus, 4, 0);
            this.tableLayoutOrders.Controls.Add(this.labelPrint, 5, 0);
            this.tableLayoutOrders.Controls.Add(this.labelSeparator, 0, 1);
            this.tableLayoutOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutOrders.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutOrders.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.tableLayoutOrders.Name = "tableLayoutOrders";
            this.tableLayoutOrders.RowCount = 3;
            this.tableLayoutOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOrders.Size = new System.Drawing.Size(1020, 655);
            this.tableLayoutOrders.TabIndex = 5;
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNumber.Location = new System.Drawing.Point(6, 5);
            this.labelOrderNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(26, 20);
            this.labelOrderNumber.TabIndex = 0;
            this.labelOrderNumber.Text = "ID";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(66, 5);
            this.labelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(82, 20);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date/Time";
            // 
            // labelNamePhone
            // 
            this.labelNamePhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNamePhone.AutoSize = true;
            this.labelNamePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamePhone.Location = new System.Drawing.Point(216, 5);
            this.labelNamePhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNamePhone.Name = "labelNamePhone";
            this.labelNamePhone.Size = new System.Drawing.Size(101, 20);
            this.labelNamePhone.TabIndex = 0;
            this.labelNamePhone.Text = "Name/Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(435, 5);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(654, 5);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status";
            // 
            // labelPrint
            // 
            this.labelPrint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrint.AutoSize = true;
            this.labelPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrint.Location = new System.Drawing.Point(764, 5);
            this.labelPrint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrint.Name = "labelPrint";
            this.labelPrint.Size = new System.Drawing.Size(41, 20);
            this.labelPrint.TabIndex = 0;
            this.labelPrint.Text = "Print";
            // 
            // labelSeparator
            // 
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutOrders.SetColumnSpan(this.labelSeparator, 11);
            this.labelSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSeparator.Location = new System.Drawing.Point(3, 30);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(1014, 2);
            this.labelSeparator.TabIndex = 1;
            // 
            // OrdersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OrdersTable";
            this.Size = new System.Drawing.Size(1020, 655);
            this.tableLayoutOrders.ResumeLayout(false);
            this.tableLayoutOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private List<OrderItem> orderItemList = new List<OrderItem>();

		private List<Order> orderList = new List<Order>();

		private int orderCount;

		private IContainer components;

		private TableLayoutPanel tableLayoutOrders;

		private Label labelOrderNumber;

		private Label labelDate;

		private Label labelNamePhone;

		private Label labelEmail;

		private Label labelStatus;

		private Label labelPrint;

		private Label labelSeparator;
	}
}
