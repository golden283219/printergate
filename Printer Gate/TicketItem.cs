using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrinterGateXP
{
    public partial class TicketItem : UserControl
    {
        private Gate gate = Gate.Instance;
        private AppConfig appConfig = AppConfig.appConfig;
        private Order order;
        private Size orgSize;
        private bool isImageButton = true;
        
        public TicketItem()
        {
            InitializeComponent();
            this.summaryPanel.Visible = false;   
            this.detailPanel.Visible = true;
            this.buttonPrintAsBeauty.Visible = false;
            orgSize = this.Size;
            //Console.WriteLine("size:" + orgSize);
        }

        public void Localize()
        {
            //detail
            labelNoTitle.Text = Localization.Translation(this.order.orderType == OrderType.Table?"reservations": "take_away")+":";
            labelDateTimeTitle.Text = Localization.Translation("date_time") + ":";
            labelNameTitle.Text = Localization.Translation("name") + ":";
            labelPhoneTitle.Text = Localization.Translation("phone") + ":"; 
            labelEmailTitle.Text = Localization.Translation("email") + ":";
            if (this.order.orderType == OrderType.Table)
            {
                labelPeopleTitle.Text = Localization.Translation("persons") + ":";
            }

            else
            {
                labelPeopleTitle.Text = "";
            }
                

            labelStatusTitle.Text = Localization.Translation("status") + ":"; 
            labelPrintedTitle.Text = Localization.Translation("printed") + ":";
            if (!isImageButton)
            {
                buttonSend.Text = Localization.Translation("send");
                buttonConfirm.Text = Localization.Translation("confirm");
                buttonReject.Text = Localization.Translation("denie");
                buttonStress.Text = Localization.Translation("stress");
                buttonPrintAsBeauty.Text = Localization.Translation("print_again");
                //buttonSmall.Text = Localization.Translation("small");
            }
            
            this.labelStatus.Text = Utils.OrderStatusName(this.order.status);
            this.labelPrinted.Text = Utils.PrinttedResultName(order.printStatus);

            IEnumerable<Label> labels = this.flowLayoutPart2.Controls.OfType<Label>();
            if (labels != null)
            {
                foreach (Label label in labels)
                {
                    string str = label.Text;
                    if (str.Contains("Amount") || str.Contains("Gesamtbetrag"))
                    {
                        if (str.Contains("Amount"))
                            str = str.Replace("Amount", Localization.Translation("amount"));
                        else if (str.Contains("Gesamtbetrag"))
                            str = str.Replace("Gesamtbetrag", Localization.Translation("amount"));
                        label.Text = str;
                    }
                    if (str.Contains("for free") || str.Contains("kostenlos"))
                    {
                        if (str.Contains("for free"))
                            str = str.Replace("for free", Localization.Translation("for_free"));
                        else if (str.StartsWith("kostenlos"))
                            str = str.Replace("kostenlos", Localization.Translation("for_free"));
                        label.Text = str;
                    }
                }
               
            }
            
            //summary
            labelDateTimeTitle1.Text = Localization.Translation("date_time") + ":";

        }

        public void SetOrder(int index, Order order)
		{
            this.Tag = order.id;
            //---- detail
			this.labelNo.Text = order.id;
			this.labelName.Text = order.name;
            this.labelPhone.Text = order.phone;
            this.labelEmail.Text = order.email;
            this.labelPeople.Text = order.people;
            
            this.labelStatus.Text = Utils.OrderStatusName(order.status);
            this.labelPrinted.Text = Utils.PrinttedResultName(order.printStatus);
            //this.labelDateTime.Text = Utils.UnixTimeStampToDateTime(order.date).ToString("dd.MM.yyyy\nH:mm");
            //this.labelDateTime.Text = order.order_date.Replace(' ', '\n');
            this.labelDateTime.Text = Utils.UnixTimeStampToDateTime(order.date_checkin).ToString("dd.MM.yyyy H:mm");
            this.buttonConfirm.Enabled = (order.status == OrderStatus.Pending);
            this.buttonReject.Enabled = (order.status == OrderStatus.Pending);
            this.buttonSend.Enabled = !order.welcomeMessageSent;
            this.buttonStress.Enabled = !order.sorryMessageSent;
            if(order.orderType == OrderType.Table)
                this.buttonPrintAsBeauty.Visible = true;
            //order info
            /*
            if (order.orderInfo != null && order.orderInfo.Length > 0)
            {
                string[] order_info_arr = order.orderInfo.Split('|');
                if (order_info_arr != null && order_info_arr.Length > 0)
                {
                    Font SmallFont = new Font("Segoe UI", 8);
                    for (int i = 0; i < order_info_arr.Length; i++)
                    {
                        Label order_label = new Label();
                        order_label.Text = order_info_arr[i];
                        order_label.AutoSize = true;
                        order_label.Font = SmallFont;
                        order_label.Margin = new Padding(2, 2, 0, 2);
                        if (i == order_info_arr.Length - 1) //amount info
                        {
                            order_label.Name = "labelAmount";
                            order_label.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        }
                        this.flowLayoutPart2.Controls.Add(order_label);
                    }

                    if (order_info_arr.Length > 0)
                        this.flowLayoutPart2.BorderStyle = BorderStyle.FixedSingle;//BorderStyle.Fixed3D;
                }
            }
            */
            if (order.orderItemDetails != null && order.orderItemDetails.items.Count > 0)
            {
                float amount = 0;
                var takeAwayItems = order.orderItemDetails.items.ToArray();
                Font SmallNormalFont = new Font("Segoe UI", 8);
                Font SmallBoldFont = new Font("Segoe UI", 8, FontStyle.Bold);
                Font MediumBoldFont = new Font("Segoe UI", 9, FontStyle.Bold);
                foreach (TakeAwayItem takeAwayItem in takeAwayItems)
                {
                    Label item_label = new Label();
                    item_label.Text = takeAwayItem.getDetails();
                    item_label.AutoSize = true;
                    item_label.Font = SmallBoldFont;
                    item_label.Margin = new Padding(1, 1, 0, 1);
                    this.flowLayoutPart2.Controls.Add(item_label);
                    item_label.Click += new System.EventHandler(this.detailPanel_Click);

                    Label notes_label = new Label();
                    notes_label.Text = order.notes;
                    notes_label.AutoSize = true;
                    notes_label.Font = SmallBoldFont;
                    notes_label.Margin = new Padding(1, 1, 0, 1);
                    this.flowLayoutPart2.Controls.Add(notes_label);
                    notes_label.Click += new System.EventHandler(this.detailPanel_Click);

                    for (int i = 0; i < takeAwayItem.tk_toppings_cont.Count; i++)
                    {
                        Label extra_label = new Label();
                        extra_label.Text = takeAwayItem.getExtra(i);
                        extra_label.AutoSize = true;
                        extra_label.Font = SmallNormalFont;
                        extra_label.Margin = new Padding(3, 1, 0, 1);
                        this.flowLayoutPart2.Controls.Add(extra_label);
                        extra_label.Click += new System.EventHandler(this.detailPanel_Click);
                    }
                    amount += takeAwayItem.getCost();
                }
                Label amount_label = new Label();
                amount_label.Text = order.orderItemDetails.getTotal();//"Amount: "+amount.ToString("0.00");
                amount_label.AutoSize = true;
                amount_label.Font = MediumBoldFont;
                amount_label.Margin = new Padding(1, 2, 0, 1);
                amount_label.ForeColor = Color.Brown;
                this.flowLayoutPart2.Controls.Add(amount_label);
                amount_label.Click += new System.EventHandler(this.detailPanel_Click);
                this.flowLayoutPart2.BorderStyle = BorderStyle.FixedSingle;//BorderStyle.Fixed3D;

            }
            //---- summary
            this.labelName1.Text = order.name;
            if(order.orderType == OrderType.Table)
            {
                this.labelPeople1.Text = order.people + " " + Localization.Translation("persons");
            }
            else
            {
                this.labelPeople1.Text = "";
            }
            
            //this.labelDateTime1.Text = Utils.UnixTimeStampToDateTime(order.date).ToString("dd.MM.yyyy\nH:mm");
            //this.labelDateTime1.Text = order.order_date.Replace(' ', '\n');
            this.labelDateTime1.Text = Utils.UnixTimeStampToDateTime(order.date_checkin).ToString("dd.MM.yyyy H:mm");
            this.order = order;
            Localize();
            this.UpdateBackground();
            //small window when status is confirmed
            if(this.order.status == OrderStatus.Confirmed)
            {
                this.summaryPanel.Visible = true;
                this.detailPanel.Visible = false;
            }
		}

        public void UpdateBackground()
        {
            if (this.order.status == OrderStatus.Pending)
            {
                this.BackColor = AppColor.HIGHLIGHT;//this.tableLayoutReservations.BackColor = AppColor.HIGHLIGHT;
                return;
            }
            this.BackColor = Color.White;//this.tableLayoutReservations.BackColor = Color.White;
        }

        public void UpdateOrderStatus(OrderStatus status)
        {
            this.order.status = status;
            this.buttonConfirm.Enabled = (this.order.status == OrderStatus.Pending);
            this.buttonReject.Enabled = (this.order.status == OrderStatus.Pending);//this.buttonReject.Enabled = (this.order.status == OrderStatus.Pending);
            this.labelStatus.Text = Utils.OrderStatusName(this.order.status);
            this.UpdateBackground();
        }

        
        public void UpdateOrderPrintStatus(PrintStatus status)
        {
            this.labelPrinted.Text = Utils.PrinttedResultName(status);
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


        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (this.gate.ChangeOrderState(this.order.id, this.order.orderType, Gate.ACTION_CONFIRM))
            {
                this.order.status = OrderStatus.Confirmed;
                this.UpdateOrderStatus(this.order.status);
                //if (this.order.orderType == OrderType.Table && this.appConfig.printBeautyWhenConfirmed)
                if (this.appConfig.printReservationWithBeautyWhenConfirmed)
                {
                    MainFormAdvanced.gMainForm.printOrder(this.order, true);
                }
                //small window
                if (this.order.status == OrderStatus.Confirmed)
                {
                    this.summaryPanel.Visible = true;
                    this.detailPanel.Visible = false;
                }
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

        private void buttonStress_Click(object sender, EventArgs e)
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
            this.buttonStress.Enabled = false;
        }

        private void buttonPrintAsBeauty_click(object sender, EventArgs e)
        {
            MainFormAdvanced.gMainForm.printOrder(this.order, true);
        }

        private void buttonPrintAsTicket_click(object sender, EventArgs e)
        {
            MainFormAdvanced.gMainForm.printOrder(this.order, false);
        }


        private void summaryPanel_Click(object sender, EventArgs e)
        {
            if (this.summaryPanel.Visible == true)
            {
                this.summaryPanel.Visible = false;
                this.detailPanel.Visible = true;
            }
        }

        private void detailPanel_Click(object sender, EventArgs e)
        {
            if (this.detailPanel.Visible == true)
            {
                this.detailPanel.Visible = false;
                this.summaryPanel.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
