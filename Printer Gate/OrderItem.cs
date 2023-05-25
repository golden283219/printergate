using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PrinterGateXP.Properties;

namespace PrinterGateXP
{
	public class OrderItem : UserControl
	{
		public OrderItem()
		{
			this.InitializeComponent();
			base.Margin = new Padding(0, 0, 0, 0);
		}

		public void SetOrder(int index, Order order)
		{
			this.labelOrderNumber.Text = order.id;
			this.labelNamePhone.Text = order.name + "\n" + order.phone;
			this.labelEmail.Text = order.email;
			this.labelStatus.Text = Utils.OrderStatusName(order.status);
			this.labelPrint.Text = Utils.PrintStatusName(order.printStatus);
			this.labelDate.Text = Utils.UnixTimeStampToDateTime(order.date).ToString("dd.MM H:mm:ss");
			this.buttonConfirm.Enabled = (order.status == OrderStatus.Pending);
			this.buttonReject.Enabled = (order.status == OrderStatus.Pending);
			this.buttonSend.Enabled = !order.welcomeMessageSent;
			this.buttonSendSorry.Enabled = !order.sorryMessageSent;
			this.order = order;
			this.UpdateBackground();
		}

		public void UpdateBackground()
		{
			if (this.order.status == OrderStatus.Pending)
			{
				this.tableLayoutReservations.BackColor = AppColor.HIGHLIGHT;
				return;
			}
			this.tableLayoutReservations.BackColor = Color.White;
		}

		public void Localize()
		{
			this.labelStatus.Text = Utils.OrderStatusName(this.order.status);
			this.labelPrint.Text = Utils.PrintStatusName(this.order.printStatus);
		}

		public void UpdateOrderStatus(OrderStatus status)
		{
			this.order.status = status;
			this.buttonConfirm.Enabled = (this.order.status == OrderStatus.Pending);
			this.buttonReject.Enabled = (this.order.status == OrderStatus.Pending);
			this.labelStatus.Text = Utils.OrderStatusName(this.order.status);
			this.UpdateBackground();
		}

		public void UpdateOrderPrintStatus(PrintStatus status)
		{
			this.labelPrint.Text = Utils.PrintStatusName(status);
		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			if (this.gate.ChangeOrderState(this.order.id, this.order.orderType, Gate.ACTION_CONFIRM))
			{
				this.order.status = OrderStatus.Confirmed;
				this.UpdateOrderStatus(this.order.status);
			}
		}

		private void buttonReject_Click(object sender, EventArgs e)
		{
			string text = "";
			switch (this.order.orderType)
			{
			case OrderType.Table:
				text = this.appConfig.declineRestaurantMessage;
				break;
			case OrderType.Food:
				text = this.appConfig.declineTakeAwayMessage;
				break;
			case OrderType.Room:
				text = this.appConfig.declineHotelMessage;
				break;
			}
			text = text.Replace("{name}", this.order.name).Replace("{greetings}", StringUtils.Greetings());
			string userInput = Prompt.GetUserInput(Localization.Translation("decline_reservation_prompt"), Localization.Translation("input"), text);
			if (userInput == null)
			{
				return;
			}
			this.gate.ChangeOrderState(this.order.id, this.order.orderType, "remove");
			if (this.gate.SendMessage(this.order.id, this.order.orderType, userInput))
			{
				this.order.status = OrderStatus.Removed;
				this.UpdateOrderStatus(this.order.status);
			}
		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			string text = "";
			switch (this.order.orderType)
			{
			case OrderType.Table:
				text = this.appConfig.welcomeRestaurantMessage;
				break;
			case OrderType.Food:
				text = this.appConfig.haveNiceMealMessage;
				break;
			case OrderType.Room:
				text = this.appConfig.welcomeHotelMessage;
				break;
			}
			text = text.Replace("{name}", this.order.name).Replace("{greetings}", StringUtils.Greetings());
			string userInput = Prompt.GetUserInput(Localization.Translation("input"), Localization.Translation("input"), text);
			if (userInput == null)
			{
				return;
			}
			this.gate.SendMessage(this.order.id, this.order.orderType, userInput);
			MessageBox.Show(Localization.Translation("welcome_message_sent"));
			this.order.welcomeMessageSent = true;
			this.buttonSend.Enabled = false;
		}

		private void buttonSendSorry_Click(object sender, EventArgs e)
		{
			if (this.gate.ChangeOrderState(this.order.id, this.order.orderType, Gate.ACTION_CONFIRM))
			{
				this.order.status = OrderStatus.Confirmed;
				this.UpdateOrderStatus(this.order.status);
			}
			string text = "";
			switch (this.order.orderType)
			{
			case OrderType.Table:
				text = this.appConfig.sorryTableReservationMessage;
				break;
			case OrderType.Food:
				text = this.appConfig.sorryTakeAwayMessage;
				break;
			case OrderType.Room:
				return;
			}
			text = text.Replace("{name}", this.order.name).Replace("{greetings}", StringUtils.Greetings());
			string userInput = Prompt.GetUserInput(Localization.Translation("input"), Localization.Translation("input"), text);
			if (userInput == null)
			{
				return;
			}
			this.gate.SendMessage(this.order.id, this.order.orderType, userInput);
			MessageBox.Show(Localization.Translation("welcome_message_sent"));
			this.order.sorryMessageSent = true;
			this.buttonSendSorry.Enabled = false;
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
            this.tableLayoutReservations = new System.Windows.Forms.TableLayoutPanel();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelNamePhone = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPrint = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonSendSorry = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tableLayoutReservations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutReservations
            // 
            this.tableLayoutReservations.AutoScroll = true;
            this.tableLayoutReservations.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutReservations.ColumnCount = 11;
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutReservations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutReservations.Controls.Add(this.labelOrderNumber, 0, 0);
            this.tableLayoutReservations.Controls.Add(this.labelNamePhone, 2, 0);
            this.tableLayoutReservations.Controls.Add(this.labelDate, 1, 0);
            this.tableLayoutReservations.Controls.Add(this.labelPrint, 5, 0);
            this.tableLayoutReservations.Controls.Add(this.labelEmail, 3, 0);
            this.tableLayoutReservations.Controls.Add(this.labelStatus, 4, 0);
            this.tableLayoutReservations.Controls.Add(this.buttonConfirm, 6, 0);
            this.tableLayoutReservations.Controls.Add(this.buttonSendSorry, 7, 0);
            this.tableLayoutReservations.Controls.Add(this.buttonReject, 8, 0);
            this.tableLayoutReservations.Controls.Add(this.buttonSend, 9, 0);
            this.tableLayoutReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutReservations.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutReservations.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutReservations.Name = "tableLayoutReservations";
            this.tableLayoutReservations.RowCount = 1;
            this.tableLayoutReservations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutReservations.Size = new System.Drawing.Size(1094, 40);
            this.tableLayoutReservations.TabIndex = 6;
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrderNumber.Location = new System.Drawing.Point(5, 0);
            this.labelOrderNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(50, 40);
            this.labelOrderNumber.TabIndex = 0;
            this.labelOrderNumber.Text = "No";
            this.labelOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNamePhone
            // 
            this.labelNamePhone.AutoSize = true;
            this.labelNamePhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNamePhone.Location = new System.Drawing.Point(215, 0);
            this.labelNamePhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNamePhone.Name = "labelNamePhone";
            this.labelNamePhone.Size = new System.Drawing.Size(246, 40);
            this.labelNamePhone.TabIndex = 0;
            this.labelNamePhone.Text = "Name(Phone)";
            this.labelNamePhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDate.Location = new System.Drawing.Point(65, 0);
            this.labelDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(140, 40);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date/Time";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrint
            // 
            this.labelPrint.AutoSize = true;
            this.labelPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrint.Location = new System.Drawing.Point(837, 0);
            this.labelPrint.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrint.Name = "labelPrint";
            this.labelPrint.Size = new System.Drawing.Size(100, 40);
            this.labelPrint.TabIndex = 0;
            this.labelPrint.Text = "Print";
            this.labelPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmail.Location = new System.Drawing.Point(469, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(250, 40);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "labelEmail";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Location = new System.Drawing.Point(727, 0);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(100, 40);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Image = global::PrinterGateXP.Properties.Resources.confirm;
            this.buttonConfirm.Location = new System.Drawing.Point(942, 0);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(35, 40);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonSendSorry
            // 
            this.buttonSendSorry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendSorry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSendSorry.FlatAppearance.BorderSize = 0;
            this.buttonSendSorry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSendSorry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendSorry.Image = global::PrinterGateXP.Properties.Resources.exclaim;
            this.buttonSendSorry.Location = new System.Drawing.Point(977, 0);
            this.buttonSendSorry.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSendSorry.Name = "buttonSendSorry";
            this.buttonSendSorry.Size = new System.Drawing.Size(35, 40);
            this.buttonSendSorry.TabIndex = 1;
            this.buttonSendSorry.UseVisualStyleBackColor = true;
            // 
            // buttonReject
            // 
            this.buttonReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReject.FlatAppearance.BorderSize = 0;
            this.buttonReject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReject.Image = global::PrinterGateXP.Properties.Resources.reject;
            this.buttonReject.Location = new System.Drawing.Point(1012, 0);
            this.buttonReject.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(35, 40);
            this.buttonReject.TabIndex = 1;
            this.buttonReject.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Image = global::PrinterGateXP.Properties.Resources.send;
            this.buttonSend.Location = new System.Drawing.Point(1047, 0);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(35, 40);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutReservations);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(1094, 40);
            this.tableLayoutReservations.ResumeLayout(false);
            this.tableLayoutReservations.PerformLayout();
            this.ResumeLayout(false);

		}

		private Gate gate = Gate.Instance;

		private AppConfig appConfig = AppConfig.appConfig;

		private Order order;

		private IContainer components;

		private TableLayoutPanel tableLayoutReservations;

		private Label labelOrderNumber;

		private Label labelDate;

		private Label labelNamePhone;

		private Label labelStatus;

		private Label labelPrint;

		private Button buttonConfirm;

		private Button buttonReject;

		private Button buttonSend;

		private Button buttonSendSorry;

		private Label labelEmail;
	}
}
