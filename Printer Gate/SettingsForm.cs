using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PrinterGateXP
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			this.InitializeComponent();
			AppConfig appConfig = AppConfig.appConfig;
			this.checkBoxXMLExport.Checked = appConfig.exportToXMLEnabled;
			this.textBoxXmlPath.Text = appConfig.exportToXMLPath;
			this.textBoxXmlPath.Enabled = appConfig.exportToXMLEnabled;
			this.buttonExportBrowse.Enabled = appConfig.exportToXMLEnabled;
			this.checkBoxShowBalloon.Checked = appConfig.showBalloon;
			//this.checkBoxBeautyPrintWhenConfirmed.Checked = appConfig.printReservationWithBeautyWhenConfirmed;
			this.checkBoxBeautyPrintWhenConfirmed1.Checked = appConfig.printReservationWithBeautyWhenConfirmed;
			this.checkBoxAlarmConnectionLost.Checked = appConfig.alarmLostConnectionEnabled;
			this.checkBoxWelcomeMessage.Checked = appConfig.welcomeMessageEnabled;
			this.checkBoxFullAddressDelivery.Checked = appConfig.addAddressEnabled;
			this.checkBoxTableReservationPopup.Checked = appConfig.tableReservationPopupEnabled;
			this.checkBoxFoodReservationPopup.Checked = appConfig.foodReservationPopupEnabled;
			this.checkBoxHotelReservationPopup.Checked = appConfig.hotelReservationPopupEnabled;
			//this.checkBoxTakeAwayAutoConfirm.Checked = appConfig.autoConfimTakeAway;
			this.checkBoxTakeAwayAutoConfirm1.Checked = appConfig.autoConfimTakeAway;
			//this.checkBoxPrintTKAnyway.Checked = appConfig.printTKAnyway;
			this.checkBoxPrintTKAnyway1.Checked = appConfig.printTKAnyway;
			//this.checkBoxReservationAutoConfirm.Checked = appConfig.autoConfirmReservation;
			this.checkBoxReservationAutoConfirm1.Checked = appConfig.autoConfirmReservation;
			//this.checkBoxPrintReservationAnyWay.Checked = appConfig.printReservationAnyway;
			this.checkBoxPrintReservationAnyWay1.Checked = appConfig.printReservationAnyway;
			this.checkBoxShowPrinterDialog.Checked = appConfig.showPrinterDialog;
			this.textBoxWelcomeRestaurant.Text = appConfig.welcomeRestaurantMessage;
			this.textBoxHaveNiceMeal.Text = appConfig.haveNiceMealMessage;
			this.textBoxWelcomeHotel.Text = appConfig.welcomeHotelMessage;
			this.textBoxDeclineRestaurant.Text = appConfig.declineRestaurantMessage;
			this.textBoxDeclineTakeAway.Text = appConfig.declineTakeAwayMessage;
			this.textBoxDeclineHotel.Text = appConfig.declineHotelMessage;
			this.textBoxSorryRestaurant.Text = appConfig.sorryTableReservationMessage;
			this.textBoxSorryTakeAway.Text = appConfig.sorryTakeAwayMessage;
			this.alarmSelectionConnectionLost.SetData(true, appConfig.lostConnectionAlarmVolume, appConfig.lostConnectionAlarmIndex, appConfig.lostConnectionAlarmPath);
			this.alarmSelectionConnectionLost.DisableEnableOption();
			this.alarmSelectionTableReservation.SetData(appConfig.tableReservationAlarmEnabled, appConfig.tableReservationAlarmVolume, appConfig.tableReservationAlarmIndex, appConfig.tableReservationAlarmPath);
			this.alarmSelectionFoodReservation.SetData(appConfig.foodReservationAlarmEnabled, appConfig.foodReservationAlarmVolume, appConfig.foodReservationAlarmIndex, appConfig.foodReservationAlarmPath);
			this.alarmSelectionHotelReservation.SetData(appConfig.hotelReservationAlarmEnabled, appConfig.hotelReservationAlarmVolume, appConfig.hotelReservationAlarmIndex, appConfig.hotelReservationAlarmPath);
			int count = this.appConfig.gatePrinters.Count;
			for (int i = 0; i < count; i++)
			{
				GatePrinter gatePrinter = this.appConfig.gatePrinters[i];
				string categoryName = gatePrinter.categoryName;
				/*
				if (i == 0)
				{
					categoryName = Localization.Translation("table");
				}
				if (i == 1)
				{
					categoryName = Localization.Translation("beautiful");
				}
				*/
				this.AddPrinter(categoryName, gatePrinter.printerName, i);
			}
			this.labelServer.Text = this.appConfig.host;
			this.comboBoxLanguage.Items.Add("English");
			this.comboBoxLanguage.Items.Add("Deutsch");
			this.comboBoxLanguage.SelectedIndex = ((this.appConfig.lang == Localization.EN) ? 0 : 1);
			this.textBoxClosePopupAfter.Text = string.Format("{0}", this.appConfig.closePopupAfter);
			this.textBoxReopenPopupAfter.Text = string.Format("{0}", this.appConfig.reOpenPopupAfter);
			this.textBoxConnectionTimeout.Text = string.Format("{0}", this.appConfig.connectionTimeout);
			this.textBoxStartupDelay.Text = string.Format("{0}", appConfig.startupDelay);
			this.comboBoxTLSVersion.SelectedIndex = this.appConfig.tlsVersion;
			//this.checkBoxPrintTKAnyway.Enabled = this.appConfig.autoConfimTakeAway;
			//this.checkBoxPrintReservationAnyWay.Enabled = this.appConfig.autoConfirmReservation;
			this.UpdatePrinterSelectedStatus();
			this.Localize();
		}

		private void Localize()
		{
			this.Text = Localization.Translation("settings");
			this.tabPagePrinters.Text = Localization.Translation("server_and_printers");
			this.tabPageConfigs.Text = Localization.Translation("settings");
			this.tabPageAlarm.Text = Localization.Translation("alarm");
			this.tabPageMessages.Text = Localization.Translation("messages");
			this.labelServerHeader.Text = Localization.Translation("server");
			this.labelPrinters.Text = Localization.Translation("printers");
			this.buttonAddPrinter.Text = Localization.Translation("add_printer");
			this.buttonSaveOptions.Text = Localization.Translation("apply");
			this.checkBoxXMLExport.Text = Localization.Translation("export_to_xml");
			this.checkBoxShowBalloon.Text = Localization.Translation("show_balloon");
			//this.checkBoxBeautyPrintWhenConfirmed.Text = Localization.Translation("print_reservation_table_card");
			this.checkBoxBeautyPrintWhenConfirmed1.Text = Localization.Translation("print_reservation_table_card");
			this.checkBoxWelcomeMessage.Text = Localization.Translation("welcome_message_for_guests");
			this.checkBoxFullAddressDelivery.Text = Localization.Translation("full_address_and_map_for_delivery");
			//this.checkBoxTakeAwayAutoConfirm.Text = Localization.Translation("auto_confirm_take_away");
			this.checkBoxTakeAwayAutoConfirm1.Text = Localization.Translation("auto_confirm_take_away");
			//this.checkBoxReservationAutoConfirm.Text = Localization.Translation("auto_confirm_reservation");
			this.checkBoxReservationAutoConfirm1.Text = Localization.Translation("auto_confirm_reservation");
			this.checkBoxShowPrinterDialog.Text = Localization.Translation("show_printer_dialog");
			this.checkBoxAlarmConnectionLost.Text = Localization.Translation("alarm_no_internet_connection");
			this.checkBoxTableReservationPopup.Text = Localization.Translation("pop_up_table_reservation");
			this.checkBoxFoodReservationPopup.Text = Localization.Translation("pop_up_food_reservation");
			this.checkBoxHotelReservationPopup.Text = Localization.Translation("pop_up_hotel_reservation");
			this.labelWelcomeMessages.Text = Localization.Translation("welcome_messages");
			this.labelWelcomeRestaurant.Text = Localization.Translation("restaurant");
			this.labelWelcomeTakeAway.Text = Localization.Translation("take_away");
			this.labelWelcomeHotel.Text = Localization.Translation("hotel");
			this.labelWelcomeMessages.Text = Localization.Translation("decline_messages");
			this.labelDeclineRestaurant.Text = Localization.Translation("restaurant");
			this.labelDeclineTakeAway.Text = Localization.Translation("take_away");
			this.labelDeclineHotel.Text = Localization.Translation("hotel");
			this.labelLanguage.Text = Localization.Translation("language");
			this.alarmSelectionTableReservation.Localize();
			this.alarmSelectionFoodReservation.Localize();
			this.alarmSelectionHotelReservation.Localize();
			this.labelClosePopup.Text = Localization.Translation("close_popup_after");
			this.labelReopenPopup.Text = Localization.Translation("reopen_popup_after");
			this.labelConnectionTimeout.Text = Localization.Translation("connection_timeout");
			this.labelSeconds1.Text = Localization.Translation("seconds");
			this.labelSeconds2.Text = Localization.Translation("seconds");
			this.labelSeconds3.Text = Localization.Translation("seconds");
			this.buttonQuit.Text = Localization.Translation("quit");
			this.labelStartupDelay.Text = Localization.Translation("startup_delay");
			this.labelSeconds4.Text = Localization.Translation("seconds");
			//this.checkBoxPrintTKAnyway.Text = Localization.Translation("print_anyway");
			//this.checkBoxPrintReservationAnyWay.Text = Localization.Translation("print_anyway");
			//this.checkBoxPrintTKAnyway.Text = Localization.Translation("print_incoming_orders_takeaway");
			this.checkBoxPrintTKAnyway1.Text = Localization.Translation("print_incoming_orders_takeaway");
			//this.checkBoxPrintReservationAnyWay.Text = Localization.Translation("print_incoming_orders_reservation");
			this.checkBoxPrintReservationAnyWay1.Text = Localization.Translation("print_incoming_orders_reservation");
			this.labelSorryRestaurant.Text = Localization.Translation("restaurant");
			this.labelSorryTakeAway.Text = Localization.Translation("take_away");
			foreach (CustomPrinter customPrinter in this.customPrinterList)
			{
				customPrinter.Localize();
			}
		}

		private void buttonSaveOptions_Click(object sender, EventArgs e)
		{
			AppConfig appConfig = AppConfig.appConfig;
			appConfig.exportToXMLEnabled = this.checkBoxXMLExport.Checked;
			appConfig.exportToXMLPath = this.textBoxXmlPath.Text;
			appConfig.alarmLostConnectionEnabled = this.checkBoxAlarmConnectionLost.Checked;
			appConfig.lostConnectionAlarmVolume = this.alarmSelectionConnectionLost.alarmVolume;
			appConfig.lostConnectionAlarmIndex = this.alarmSelectionConnectionLost.alarmIndex;
			appConfig.lostConnectionAlarmPath = this.alarmSelectionConnectionLost.alarmPath;
			appConfig.welcomeMessageEnabled = this.checkBoxWelcomeMessage.Checked;
			appConfig.addAddressEnabled = this.checkBoxFullAddressDelivery.Checked;
			appConfig.tableReservationPopupEnabled = this.checkBoxTableReservationPopup.Checked;
			appConfig.tableReservationAlarmEnabled = this.alarmSelectionTableReservation.alarmEnabled;
			appConfig.tableReservationAlarmVolume = this.alarmSelectionTableReservation.alarmVolume;
			appConfig.tableReservationAlarmIndex = this.alarmSelectionTableReservation.alarmIndex;
			appConfig.tableReservationAlarmPath = this.alarmSelectionTableReservation.alarmPath;
			appConfig.foodReservationPopupEnabled = this.checkBoxFoodReservationPopup.Checked;
			appConfig.foodReservationAlarmEnabled = this.alarmSelectionFoodReservation.alarmEnabled;
			appConfig.foodReservationAlarmVolume = this.alarmSelectionFoodReservation.alarmVolume;
			appConfig.foodReservationAlarmIndex = this.alarmSelectionFoodReservation.alarmIndex;
			appConfig.foodReservationAlarmPath = this.alarmSelectionFoodReservation.alarmPath;
			appConfig.hotelReservationPopupEnabled = this.checkBoxHotelReservationPopup.Checked;
			appConfig.hotelReservationAlarmEnabled = this.alarmSelectionHotelReservation.alarmEnabled;
			appConfig.hotelReservationAlarmVolume = this.alarmSelectionHotelReservation.alarmVolume;
			appConfig.hotelReservationAlarmIndex = this.alarmSelectionHotelReservation.alarmIndex;
			appConfig.hotelReservationAlarmPath = this.alarmSelectionHotelReservation.alarmPath;
			//appConfig.autoConfimTakeAway = this.checkBoxTakeAwayAutoConfirm.Checked;
			appConfig.autoConfimTakeAway = this.checkBoxTakeAwayAutoConfirm1.Checked;
			//appConfig.printTKAnyway = this.checkBoxPrintTKAnyway.Checked;
			appConfig.printTKAnyway = this.checkBoxPrintTKAnyway1.Checked;
			//appConfig.autoConfirmReservation = this.checkBoxReservationAutoConfirm.Checked;
			appConfig.autoConfirmReservation = this.checkBoxReservationAutoConfirm1.Checked;
			//appConfig.printReservationAnyway = this.checkBoxPrintReservationAnyWay.Checked;
			appConfig.printReservationAnyway = this.checkBoxPrintReservationAnyWay1.Checked;
			appConfig.showPrinterDialog = this.checkBoxShowPrinterDialog.Checked;
			appConfig.welcomeRestaurantMessage = this.textBoxWelcomeRestaurant.Text;
			appConfig.haveNiceMealMessage = this.textBoxHaveNiceMeal.Text;
			appConfig.welcomeHotelMessage = this.textBoxWelcomeHotel.Text;
			appConfig.declineRestaurantMessage = this.textBoxDeclineRestaurant.Text;
			appConfig.declineTakeAwayMessage = this.textBoxDeclineTakeAway.Text;
			appConfig.declineHotelMessage = this.textBoxDeclineHotel.Text;
			appConfig.sorryTableReservationMessage = this.textBoxSorryRestaurant.Text;
			appConfig.sorryTakeAwayMessage = this.textBoxSorryTakeAway.Text;
			appConfig.showBalloon = this.checkBoxShowBalloon.Checked;
			//appConfig.printReservationWithBeautyWhenConfirmed = this.checkBoxBeautyPrintWhenConfirmed.Checked;
			appConfig.printReservationWithBeautyWhenConfirmed = this.checkBoxBeautyPrintWhenConfirmed1.Checked;
			appConfig.closePopupAfter = int.Parse(this.textBoxClosePopupAfter.Text);
			appConfig.reOpenPopupAfter = int.Parse(this.textBoxReopenPopupAfter.Text);
			appConfig.connectionTimeout = int.Parse(this.textBoxConnectionTimeout.Text);
			appConfig.startupDelay = int.Parse(this.textBoxStartupDelay.Text);
			appConfig.tlsVersion = this.comboBoxTLSVersion.SelectedIndex;
			appConfig.lang = ((this.comboBoxLanguage.SelectedIndex == 0) ? "en" : "de");
			AppConfig.SaveSettings();
		}

		private void AddPrinter(string categoryName, string printerName, int printerIndex = 999)
		{
			CustomPrinter customPrinter = new CustomPrinter(categoryName, printerName, printerIndex);
			customPrinter.PrinterChanged += this.PrinterChanged;
			this.tableLayoutPrintersList.Controls.Add(customPrinter, 0, this.mPrinterCount);
			this.tableLayoutPrintersList.RowStyles.Insert(this.mPrinterCount + 1, new RowStyle(SizeType.Absolute, 40f));
			TableLayoutPanel tableLayoutPanel = this.tableLayoutPrintersList;
			int rowCount = tableLayoutPanel.RowCount;
			tableLayoutPanel.RowCount = rowCount + 1;
			this.mPrinterCount++;
			this.customPrinterList.Add(customPrinter);
		}

		private void PrinterChanged(object sender, EventArgs e)
		{
			this.UpdatePrinterSelectedStatus();
		}

		private void buttonChangeServer_Click(object sender, EventArgs e)
		{
			string userInput = Prompt.GetUserInput("What is your server address?", "Server Address", this.appConfig.host);
			if (userInput != null)
			{
				this.labelServer.Text = userInput;
				this.appConfig.host = userInput;
				AppConfig.SaveSettings();
				if (MessageBox.Show(Localization.Translation("restart_confirmation"), Localization.Translation("restart"), MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Application.Restart();
				}
			}
		}

		private void buttonAddPrinter_Click(object sender, EventArgs e)
		{
			if (this.appConfig.FindRemainingMenus().Count == 0)
			{
				MessageBox.Show(Localization.Translation("no_more_products"));
				return;
			}
			if (Gate.Instance.tkMenus.Count == 0)
			{
				MessageBox.Show(Localization.Translation("api_not_installed"));
				return;
			}
			AddPrinterForm addPrinterForm = new AddPrinterForm("", null);
			if (addPrinterForm.ShowDialog() == DialogResult.OK)
			{
				string categoryName = addPrinterForm.categoryName;
				List<string> categories = addPrinterForm.categories;
				this.AddPrinter(addPrinterForm.categoryName, "", 999);
				this.AddPrinterToConfig(categoryName, "", categories);
				this.UpdatePrinterSelectedStatus();
			}
		}

		private void AddPrinterToConfig(string categoryName, string printerName, List<string> categories)
		{
			GatePrinter item = new GatePrinter(categoryName, printerName, categories, true);
			this.appConfig.gatePrinters.Add(item);
			AppConfig.SavePrinterConfig();
		}

		private void UpdatePrinterSelectedStatus()
		{
			List<TKMenu> list = this.appConfig.FindRemainingMenus();
			this.labelPrintersWarning.Text = ((list.Count != 0) ? "Warning: All Menus should be assigned." : "");
		}

		private void checkBoxTableReservationPopup_CheckedChanged(object sender, EventArgs e)
		{
			this.alarmSelectionTableReservation.Enabled = this.checkBoxTableReservationPopup.Checked;
		}

		private void checkBoxFoodReservationPopup_CheckedChanged(object sender, EventArgs e)
		{
			this.alarmSelectionFoodReservation.Enabled = this.checkBoxFoodReservationPopup.Checked;
		}

		private void checkBoxHotelReservationPopup_CheckedChanged(object sender, EventArgs e)
		{
			this.alarmSelectionHotelReservation.Enabled = this.checkBoxHotelReservationPopup.Checked;
		}

		private void checkBoxAlarmConnectionLost_CheckedChanged(object sender, EventArgs e)
		{
			this.alarmSelectionConnectionLost.Enabled = this.checkBoxAlarmConnectionLost.Checked;
		}

		private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			Localization.Lang = ((this.comboBoxLanguage.SelectedIndex == 0) ? Localization.EN : Localization.DE);
			this.Localize();
		}

		private void textBoxClosePopupAfter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void buttonQuit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Localization.Translation("quit_text"), Localization.Translation("confirmation"), MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void checkBoxTakeAwayAutoConfirm_CheckedChanged(object sender, EventArgs e)
		{
			//this.checkBoxPrintTKAnyway.Enabled = this.checkBoxTakeAwayAutoConfirm.Checked;
		}

		private void checkBoxReservationAutoConfirm_CheckedChanged(object sender, EventArgs e)
		{
			//this.checkBoxPrintReservationAnyWay.Enabled = this.checkBoxReservationAutoConfirm.Checked;
		}

		private int mPrinterCount;

		private AppConfig appConfig = AppConfig.appConfig;

		private List<CustomPrinter> customPrinterList = new List<CustomPrinter>();

        private void buttonExportBrowse_Click(object sender, EventArgs e)
        {
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.InitialDirectory = System.IO.Path.GetDirectoryName(this.appConfig.exportToXMLPath);
			dlg.DefaultExt = "xml";
			dlg.FileName = System.IO.Path.GetFileNameWithoutExtension(this.appConfig.exportToXMLPath);
			dlg.Title = "Select a XML file path to export";
			dlg.Filter = "xml files (*.xml)|*.xml";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				textBoxXmlPath.Text = dlg.FileName;
				this.appConfig.exportToXMLPath = dlg.FileName;
			}
		}

        private void checkBoxXMLExport_CheckedChanged(object sender, EventArgs e)
        {
			this.buttonExportBrowse.Enabled = this.checkBoxXMLExport.Checked;
			this.textBoxXmlPath.Enabled = this.checkBoxXMLExport.Checked;
		}

        private void checkBoxReservationAutoConfirm1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPrintReservationAnyWay1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBeautyPrintWhenConfirmed1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTakeAwayAutoConfirm1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPrintTKAnyway1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutSettingsMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
