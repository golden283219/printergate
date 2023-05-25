namespace PrinterGateXP
{
	public partial class SettingsForm : global::System.Windows.Forms.Form
	{
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
            this.tableLayoutSettingsMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxXMLExport = new System.Windows.Forms.CheckBox();
            this.buttonExportBrowse = new System.Windows.Forms.Button();
            this.textBoxXmlPath = new System.Windows.Forms.TextBox();
            this.checkBoxWelcomeMessage = new System.Windows.Forms.CheckBox();
            this.checkBoxFullAddressDelivery = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPrinterDialog = new System.Windows.Forms.CheckBox();
            this.checkBoxShowBalloon = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelStartupDelay = new System.Windows.Forms.Label();
            this.textBoxStartupDelay = new System.Windows.Forms.TextBox();
            this.labelSeconds4 = new System.Windows.Forms.Label();
            this.buttonSaveOptions = new System.Windows.Forms.Button();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPagePrinters = new System.Windows.Forms.TabPage();
            this.tableLayoutServerAndPrinters = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutServerHeader = new System.Windows.Forms.TableLayoutPanel();
            this.labelServerHeader = new System.Windows.Forms.Label();
            this.tableLayoutPrintersHeader = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddPrinter = new System.Windows.Forms.Button();
            this.labelPrinters = new System.Windows.Forms.Label();
            this.labelPrintersWarning = new System.Windows.Forms.Label();
            this.tableLayoutHostSettings = new System.Windows.Forms.TableLayoutPanel();
            this.labelServer = new System.Windows.Forms.Label();
            this.buttonChangeServer = new System.Windows.Forms.Button();
            this.tableLayoutPrintersList = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBeautyPrintWhenConfirmed1 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrintReservationAnyWay1 = new System.Windows.Forms.CheckBox();
            this.checkBoxReservationAutoConfirm1 = new System.Windows.Forms.CheckBox();
            this.checkBoxTakeAwayAutoConfirm1 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrintTKAnyway1 = new System.Windows.Forms.CheckBox();
            this.tabPageConfigs = new System.Windows.Forms.TabPage();
            this.tabPageAlarm = new System.Windows.Forms.TabPage();
            this.tableLayoutAlarmSettings = new System.Windows.Forms.TableLayoutPanel();
            this.labelClosePopup = new System.Windows.Forms.Label();
            this.labelReopenPopup = new System.Windows.Forms.Label();
            this.textBoxClosePopupAfter = new System.Windows.Forms.TextBox();
            this.textBoxReopenPopupAfter = new System.Windows.Forms.TextBox();
            this.labelSeconds1 = new System.Windows.Forms.Label();
            this.labelSeconds2 = new System.Windows.Forms.Label();
            this.labelConnectionTimeout = new System.Windows.Forms.Label();
            this.textBoxConnectionTimeout = new System.Windows.Forms.TextBox();
            this.labelSeconds3 = new System.Windows.Forms.Label();
            this.panelConnectionLost = new System.Windows.Forms.Panel();
            this.tableLayoutAlarmConnection = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxAlarmConnectionLost = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPopup = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxTableReservationPopup = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutTakeAwayAlarm = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxFoodReservationPopup = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxHotelReservationPopup = new System.Windows.Forms.CheckBox();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.tableLayoutWelcomeMessages = new System.Windows.Forms.TableLayoutPanel();
            this.labelWelcomeRestaurant = new System.Windows.Forms.Label();
            this.labelWelcomeTakeAway = new System.Windows.Forms.Label();
            this.labelWelcomeHotel = new System.Windows.Forms.Label();
            this.textBoxWelcomeRestaurant = new System.Windows.Forms.TextBox();
            this.textBoxHaveNiceMeal = new System.Windows.Forms.TextBox();
            this.textBoxWelcomeHotel = new System.Windows.Forms.TextBox();
            this.labelWelcomeMessages = new System.Windows.Forms.Label();
            this.labelDeclineMessages = new System.Windows.Forms.Label();
            this.labelDeclineRestaurant = new System.Windows.Forms.Label();
            this.labelDeclineTakeAway = new System.Windows.Forms.Label();
            this.labelDeclineHotel = new System.Windows.Forms.Label();
            this.textBoxDeclineRestaurant = new System.Windows.Forms.TextBox();
            this.textBoxDeclineTakeAway = new System.Windows.Forms.TextBox();
            this.textBoxDeclineHotel = new System.Windows.Forms.TextBox();
            this.tabPageSorryMessage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSorryRestaurant = new System.Windows.Forms.Label();
            this.labelSorryTakeAway = new System.Windows.Forms.Label();
            this.textBoxSorryRestaurant = new System.Windows.Forms.TextBox();
            this.textBoxSorryTakeAway = new System.Windows.Forms.TextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTLSVersion = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.alarmSelectionConnectionLost = new PrinterGateXP.AlarmSelection();
            this.alarmSelectionTableReservation = new PrinterGateXP.AlarmSelection();
            this.alarmSelectionFoodReservation = new PrinterGateXP.AlarmSelection();
            this.alarmSelectionHotelReservation = new PrinterGateXP.AlarmSelection();
            this.tableLayoutSettingsMain.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPagePrinters.SuspendLayout();
            this.tableLayoutServerAndPrinters.SuspendLayout();
            this.tableLayoutServerHeader.SuspendLayout();
            this.tableLayoutPrintersHeader.SuspendLayout();
            this.tableLayoutHostSettings.SuspendLayout();
            this.tableLayoutPrintersList.SuspendLayout();
            this.tabPageConfigs.SuspendLayout();
            this.tabPageAlarm.SuspendLayout();
            this.tableLayoutAlarmSettings.SuspendLayout();
            this.panelConnectionLost.SuspendLayout();
            this.tableLayoutAlarmConnection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPopup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutTakeAwayAlarm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            this.tableLayoutWelcomeMessages.SuspendLayout();
            this.tabPageSorryMessage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutSettingsMain
            // 
            this.tableLayoutSettingsMain.ColumnCount = 2;
            this.tableLayoutSettingsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.10963F));
            this.tableLayoutSettingsMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.89037F));
            this.tableLayoutSettingsMain.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutSettingsMain.Controls.Add(this.checkBoxWelcomeMessage, 0, 1);
            this.tableLayoutSettingsMain.Controls.Add(this.checkBoxFullAddressDelivery, 0, 2);
            this.tableLayoutSettingsMain.Controls.Add(this.checkBoxShowPrinterDialog, 0, 3);
            this.tableLayoutSettingsMain.Controls.Add(this.checkBoxShowBalloon, 0, 4);
            this.tableLayoutSettingsMain.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutSettingsMain.Controls.Add(this.panel4, 0, 6);
            this.tableLayoutSettingsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutSettingsMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutSettingsMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutSettingsMain.Name = "tableLayoutSettingsMain";
            this.tableLayoutSettingsMain.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutSettingsMain.RowCount = 11;
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutSettingsMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutSettingsMain.Size = new System.Drawing.Size(622, 563);
            this.tableLayoutSettingsMain.TabIndex = 0;
            this.tableLayoutSettingsMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutSettingsMain_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutSettingsMain.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel4.Controls.Add(this.checkBoxXMLExport, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonExportBrowse, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxXmlPath, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(602, 30);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // checkBoxXMLExport
            // 
            this.checkBoxXMLExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxXMLExport.AutoSize = true;
            this.checkBoxXMLExport.Location = new System.Drawing.Point(3, 3);
            this.checkBoxXMLExport.Name = "checkBoxXMLExport";
            this.checkBoxXMLExport.Size = new System.Drawing.Size(125, 24);
            this.checkBoxXMLExport.TabIndex = 0;
            this.checkBoxXMLExport.Text = "Export to XML";
            this.checkBoxXMLExport.UseVisualStyleBackColor = true;
            this.checkBoxXMLExport.CheckedChanged += new System.EventHandler(this.checkBoxXMLExport_CheckedChanged);
            // 
            // buttonExportBrowse
            // 
            this.buttonExportBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExportBrowse.Location = new System.Drawing.Point(572, 0);
            this.buttonExportBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExportBrowse.Name = "buttonExportBrowse";
            this.buttonExportBrowse.Size = new System.Drawing.Size(30, 30);
            this.buttonExportBrowse.TabIndex = 2;
            this.buttonExportBrowse.Text = "...";
            this.buttonExportBrowse.UseVisualStyleBackColor = true;
            this.buttonExportBrowse.Click += new System.EventHandler(this.buttonExportBrowse_Click);
            // 
            // textBoxXmlPath
            // 
            this.textBoxXmlPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxXmlPath.Location = new System.Drawing.Point(141, 3);
            this.textBoxXmlPath.Name = "textBoxXmlPath";
            this.textBoxXmlPath.ReadOnly = true;
            this.textBoxXmlPath.Size = new System.Drawing.Size(415, 27);
            this.textBoxXmlPath.TabIndex = 3;
            // 
            // checkBoxWelcomeMessage
            // 
            this.checkBoxWelcomeMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWelcomeMessage.AutoSize = true;
            this.checkBoxWelcomeMessage.Location = new System.Drawing.Point(13, 43);
            this.checkBoxWelcomeMessage.Name = "checkBoxWelcomeMessage";
            this.checkBoxWelcomeMessage.Size = new System.Drawing.Size(224, 24);
            this.checkBoxWelcomeMessage.TabIndex = 2;
            this.checkBoxWelcomeMessage.Text = "Welcome message for guests";
            this.checkBoxWelcomeMessage.UseVisualStyleBackColor = true;
            // 
            // checkBoxFullAddressDelivery
            // 
            this.checkBoxFullAddressDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxFullAddressDelivery.AutoSize = true;
            this.checkBoxFullAddressDelivery.Location = new System.Drawing.Point(13, 73);
            this.checkBoxFullAddressDelivery.Name = "checkBoxFullAddressDelivery";
            this.checkBoxFullAddressDelivery.Size = new System.Drawing.Size(257, 24);
            this.checkBoxFullAddressDelivery.TabIndex = 3;
            this.checkBoxFullAddressDelivery.Text = "Full address and map for delivery";
            this.checkBoxFullAddressDelivery.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowPrinterDialog
            // 
            this.checkBoxShowPrinterDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowPrinterDialog.AutoSize = true;
            this.checkBoxShowPrinterDialog.Location = new System.Drawing.Point(13, 103);
            this.checkBoxShowPrinterDialog.Name = "checkBoxShowPrinterDialog";
            this.checkBoxShowPrinterDialog.Size = new System.Drawing.Size(165, 24);
            this.checkBoxShowPrinterDialog.TabIndex = 9;
            this.checkBoxShowPrinterDialog.Text = "Show Printer Dialog";
            this.checkBoxShowPrinterDialog.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowBalloon
            // 
            this.checkBoxShowBalloon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowBalloon.AutoSize = true;
            this.checkBoxShowBalloon.Location = new System.Drawing.Point(13, 133);
            this.checkBoxShowBalloon.Name = "checkBoxShowBalloon";
            this.checkBoxShowBalloon.Size = new System.Drawing.Size(270, 24);
            this.checkBoxShowBalloon.TabIndex = 9;
            this.checkBoxShowBalloon.Text = "Show Balloon Icon when minimized";
            this.checkBoxShowBalloon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutSettingsMain.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelStartupDelay, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxStartupDelay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSeconds4, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 160);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 30);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // labelStartupDelay
            // 
            this.labelStartupDelay.AutoSize = true;
            this.labelStartupDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStartupDelay.Location = new System.Drawing.Point(3, 0);
            this.labelStartupDelay.Name = "labelStartupDelay";
            this.labelStartupDelay.Size = new System.Drawing.Size(194, 30);
            this.labelStartupDelay.TabIndex = 0;
            this.labelStartupDelay.Text = "Startup Delay";
            this.labelStartupDelay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStartupDelay
            // 
            this.textBoxStartupDelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxStartupDelay.Location = new System.Drawing.Point(200, 1);
            this.textBoxStartupDelay.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxStartupDelay.Name = "textBoxStartupDelay";
            this.textBoxStartupDelay.Size = new System.Drawing.Size(100, 27);
            this.textBoxStartupDelay.TabIndex = 1;
            // 
            // labelSeconds4
            // 
            this.labelSeconds4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSeconds4.AutoSize = true;
            this.labelSeconds4.Location = new System.Drawing.Point(303, 5);
            this.labelSeconds4.Name = "labelSeconds4";
            this.labelSeconds4.Size = new System.Drawing.Size(65, 20);
            this.labelSeconds4.TabIndex = 2;
            this.labelSeconds4.Text = "Seconds";
            // 
            // buttonSaveOptions
            // 
            this.buttonSaveOptions.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveOptions.Location = new System.Drawing.Point(547, 662);
            this.buttonSaveOptions.Name = "buttonSaveOptions";
            this.buttonSaveOptions.Size = new System.Drawing.Size(96, 31);
            this.buttonSaveOptions.TabIndex = 1;
            this.buttonSaveOptions.Text = "Apply";
            this.buttonSaveOptions.UseVisualStyleBackColor = true;
            this.buttonSaveOptions.Click += new System.EventHandler(this.buttonSaveOptions_Click);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlSettings.Controls.Add(this.tabPagePrinters);
            this.tabControlSettings.Controls.Add(this.tabPageConfigs);
            this.tabControlSettings.Controls.Add(this.tabPageAlarm);
            this.tabControlSettings.Controls.Add(this.tabPageMessages);
            this.tabControlSettings.Controls.Add(this.tabPageSorryMessage);
            this.tabControlSettings.Location = new System.Drawing.Point(11, 47);
            this.tabControlSettings.Margin = new System.Windows.Forms.Padding(10);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(636, 602);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPagePrinters
            // 
            this.tabPagePrinters.Controls.Add(this.tableLayoutServerAndPrinters);
            this.tabPagePrinters.Location = new System.Drawing.Point(4, 29);
            this.tabPagePrinters.Margin = new System.Windows.Forms.Padding(10);
            this.tabPagePrinters.Name = "tabPagePrinters";
            this.tabPagePrinters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrinters.Size = new System.Drawing.Size(628, 569);
            this.tabPagePrinters.TabIndex = 0;
            this.tabPagePrinters.Text = "Server & Printers";
            this.tabPagePrinters.UseVisualStyleBackColor = true;
            // 
            // tableLayoutServerAndPrinters
            // 
            this.tableLayoutServerAndPrinters.BackColor = System.Drawing.Color.White;
            this.tableLayoutServerAndPrinters.ColumnCount = 1;
            this.tableLayoutServerAndPrinters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutServerAndPrinters.Controls.Add(this.tableLayoutServerHeader, 0, 0);
            this.tableLayoutServerAndPrinters.Controls.Add(this.tableLayoutPrintersHeader, 0, 3);
            this.tableLayoutServerAndPrinters.Controls.Add(this.tableLayoutHostSettings, 0, 1);
            this.tableLayoutServerAndPrinters.Controls.Add(this.tableLayoutPrintersList, 0, 4);
            this.tableLayoutServerAndPrinters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutServerAndPrinters.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutServerAndPrinters.Margin = new System.Windows.Forms.Padding(10, 20, 20, 10);
            this.tableLayoutServerAndPrinters.Name = "tableLayoutServerAndPrinters";
            this.tableLayoutServerAndPrinters.RowCount = 5;
            this.tableLayoutServerAndPrinters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutServerAndPrinters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutServerAndPrinters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutServerAndPrinters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutServerAndPrinters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutServerAndPrinters.Size = new System.Drawing.Size(622, 563);
            this.tableLayoutServerAndPrinters.TabIndex = 3;
            // 
            // tableLayoutServerHeader
            // 
            this.tableLayoutServerHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.tableLayoutServerHeader.ColumnCount = 1;
            this.tableLayoutServerHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutServerHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutServerHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutServerHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutServerHeader.Controls.Add(this.labelServerHeader, 0, 0);
            this.tableLayoutServerHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutServerHeader.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutServerHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutServerHeader.Name = "tableLayoutServerHeader";
            this.tableLayoutServerHeader.RowCount = 1;
            this.tableLayoutServerHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutServerHeader.Size = new System.Drawing.Size(622, 40);
            this.tableLayoutServerHeader.TabIndex = 0;
            // 
            // labelServerHeader
            // 
            this.labelServerHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelServerHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelServerHeader.ForeColor = System.Drawing.Color.White;
            this.labelServerHeader.Location = new System.Drawing.Point(10, 0);
            this.labelServerHeader.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelServerHeader.Name = "labelServerHeader";
            this.labelServerHeader.Size = new System.Drawing.Size(115, 40);
            this.labelServerHeader.TabIndex = 0;
            this.labelServerHeader.Text = "Server";
            this.labelServerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPrintersHeader
            // 
            this.tableLayoutPrintersHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.tableLayoutPrintersHeader.ColumnCount = 3;
            this.tableLayoutPrintersHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPrintersHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPrintersHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPrintersHeader.Controls.Add(this.buttonAddPrinter, 2, 0);
            this.tableLayoutPrintersHeader.Controls.Add(this.labelPrinters, 0, 0);
            this.tableLayoutPrintersHeader.Controls.Add(this.labelPrintersWarning, 1, 0);
            this.tableLayoutPrintersHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPrintersHeader.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPrintersHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPrintersHeader.Name = "tableLayoutPrintersHeader";
            this.tableLayoutPrintersHeader.RowCount = 1;
            this.tableLayoutPrintersHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPrintersHeader.Size = new System.Drawing.Size(622, 40);
            this.tableLayoutPrintersHeader.TabIndex = 3;
            // 
            // buttonAddPrinter
            // 
            this.buttonAddPrinter.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddPrinter.Location = new System.Drawing.Point(439, 3);
            this.buttonAddPrinter.Name = "buttonAddPrinter";
            this.buttonAddPrinter.Size = new System.Drawing.Size(180, 34);
            this.buttonAddPrinter.TabIndex = 0;
            this.buttonAddPrinter.Text = "&Add Printer";
            this.buttonAddPrinter.UseVisualStyleBackColor = true;
            this.buttonAddPrinter.Click += new System.EventHandler(this.buttonAddPrinter_Click);
            // 
            // labelPrinters
            // 
            this.labelPrinters.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrinters.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelPrinters.ForeColor = System.Drawing.Color.White;
            this.labelPrinters.Location = new System.Drawing.Point(10, 0);
            this.labelPrinters.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelPrinters.Name = "labelPrinters";
            this.labelPrinters.Size = new System.Drawing.Size(89, 40);
            this.labelPrinters.TabIndex = 0;
            this.labelPrinters.Text = "Printers";
            this.labelPrinters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrintersWarning
            // 
            this.labelPrintersWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrintersWarning.AutoSize = true;
            this.labelPrintersWarning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPrintersWarning.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelPrintersWarning.Location = new System.Drawing.Point(310, 12);
            this.labelPrintersWarning.Name = "labelPrintersWarning";
            this.labelPrintersWarning.Size = new System.Drawing.Size(0, 15);
            this.labelPrintersWarning.TabIndex = 1;
            // 
            // tableLayoutHostSettings
            // 
            this.tableLayoutHostSettings.ColumnCount = 2;
            this.tableLayoutHostSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutHostSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutHostSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutHostSettings.Controls.Add(this.labelServer, 0, 0);
            this.tableLayoutHostSettings.Controls.Add(this.buttonChangeServer, 1, 0);
            this.tableLayoutHostSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutHostSettings.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutHostSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutHostSettings.Name = "tableLayoutHostSettings";
            this.tableLayoutHostSettings.RowCount = 1;
            this.tableLayoutHostSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutHostSettings.Size = new System.Drawing.Size(622, 40);
            this.tableLayoutHostSettings.TabIndex = 4;
            // 
            // labelServer
            // 
            this.labelServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelServer.ForeColor = System.Drawing.Color.Black;
            this.labelServer.Location = new System.Drawing.Point(0, 10);
            this.labelServer.Margin = new System.Windows.Forms.Padding(0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(582, 20);
            this.labelServer.TabIndex = 2;
            this.labelServer.Text = "<host>";
            // 
            // buttonChangeServer
            // 
            this.buttonChangeServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeServer.Location = new System.Drawing.Point(587, 5);
            this.buttonChangeServer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChangeServer.Name = "buttonChangeServer";
            this.buttonChangeServer.Size = new System.Drawing.Size(30, 30);
            this.buttonChangeServer.TabIndex = 3;
            this.buttonChangeServer.Text = "...";
            this.buttonChangeServer.UseVisualStyleBackColor = true;
            this.buttonChangeServer.Click += new System.EventHandler(this.buttonChangeServer_Click);
            // 
            // tableLayoutPrintersList
            // 
            this.tableLayoutPrintersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPrintersList.AutoScroll = true;
            this.tableLayoutPrintersList.ColumnCount = 1;
            this.tableLayoutPrintersList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPrintersList.Controls.Add(this.checkBoxBeautyPrintWhenConfirmed1, 0, 5);
            this.tableLayoutPrintersList.Controls.Add(this.checkBoxPrintReservationAnyWay1, 0, 4);
            this.tableLayoutPrintersList.Controls.Add(this.checkBoxReservationAutoConfirm1, 0, 3);
            this.tableLayoutPrintersList.Controls.Add(this.checkBoxTakeAwayAutoConfirm1, 0, 7);
            this.tableLayoutPrintersList.Controls.Add(this.checkBoxPrintTKAnyway1, 0, 8);
            this.tableLayoutPrintersList.Location = new System.Drawing.Point(10, 150);
            this.tableLayoutPrintersList.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPrintersList.Name = "tableLayoutPrintersList";
            this.tableLayoutPrintersList.RowCount = 9;
            this.tableLayoutPrintersList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPrintersList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPrintersList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPrintersList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPrintersList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPrintersList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPrintersList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPrintersList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPrintersList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPrintersList.Size = new System.Drawing.Size(602, 403);
            this.tableLayoutPrintersList.TabIndex = 2;
            // 
            // checkBoxBeautyPrintWhenConfirmed1
            // 
            this.checkBoxBeautyPrintWhenConfirmed1.AutoSize = true;
            this.checkBoxBeautyPrintWhenConfirmed1.Location = new System.Drawing.Point(3, 183);
            this.checkBoxBeautyPrintWhenConfirmed1.Name = "checkBoxBeautyPrintWhenConfirmed1";
            this.checkBoxBeautyPrintWhenConfirmed1.Size = new System.Drawing.Size(222, 24);
            this.checkBoxBeautyPrintWhenConfirmed1.TabIndex = 13;
            this.checkBoxBeautyPrintWhenConfirmed1.Text = "Print Reservation Table Card";
            this.checkBoxBeautyPrintWhenConfirmed1.UseVisualStyleBackColor = true;
            this.checkBoxBeautyPrintWhenConfirmed1.CheckedChanged += new System.EventHandler(this.checkBoxBeautyPrintWhenConfirmed1_CheckedChanged);
            // 
            // checkBoxPrintReservationAnyWay1
            // 
            this.checkBoxPrintReservationAnyWay1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxPrintReservationAnyWay1.AutoSize = true;
            this.checkBoxPrintReservationAnyWay1.Location = new System.Drawing.Point(3, 153);
            this.checkBoxPrintReservationAnyWay1.Name = "checkBoxPrintReservationAnyWay1";
            this.checkBoxPrintReservationAnyWay1.Size = new System.Drawing.Size(270, 24);
            this.checkBoxPrintReservationAnyWay1.TabIndex = 8;
            this.checkBoxPrintReservationAnyWay1.Text = "Print Incoming Orders(Reservation)";
            this.checkBoxPrintReservationAnyWay1.UseVisualStyleBackColor = true;
            this.checkBoxPrintReservationAnyWay1.CheckedChanged += new System.EventHandler(this.checkBoxPrintReservationAnyWay1_CheckedChanged);
            // 
            // checkBoxReservationAutoConfirm1
            // 
            this.checkBoxReservationAutoConfirm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxReservationAutoConfirm1.AutoSize = true;
            this.checkBoxReservationAutoConfirm1.Location = new System.Drawing.Point(3, 123);
            this.checkBoxReservationAutoConfirm1.Name = "checkBoxReservationAutoConfirm1";
            this.checkBoxReservationAutoConfirm1.Size = new System.Drawing.Size(211, 24);
            this.checkBoxReservationAutoConfirm1.TabIndex = 9;
            this.checkBoxReservationAutoConfirm1.Text = "Auto Confirm(Reservation)";
            this.checkBoxReservationAutoConfirm1.UseVisualStyleBackColor = true;
            this.checkBoxReservationAutoConfirm1.CheckedChanged += new System.EventHandler(this.checkBoxReservationAutoConfirm1_CheckedChanged);
            // 
            // checkBoxTakeAwayAutoConfirm1
            // 
            this.checkBoxTakeAwayAutoConfirm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxTakeAwayAutoConfirm1.AutoSize = true;
            this.checkBoxTakeAwayAutoConfirm1.Location = new System.Drawing.Point(3, 243);
            this.checkBoxTakeAwayAutoConfirm1.Name = "checkBoxTakeAwayAutoConfirm1";
            this.checkBoxTakeAwayAutoConfirm1.Size = new System.Drawing.Size(202, 24);
            this.checkBoxTakeAwayAutoConfirm1.TabIndex = 14;
            this.checkBoxTakeAwayAutoConfirm1.Text = "Auto Confirm(Take Away)";
            this.checkBoxTakeAwayAutoConfirm1.UseVisualStyleBackColor = true;
            this.checkBoxTakeAwayAutoConfirm1.CheckedChanged += new System.EventHandler(this.checkBoxTakeAwayAutoConfirm1_CheckedChanged);
            // 
            // checkBoxPrintTKAnyway1
            // 
            this.checkBoxPrintTKAnyway1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxPrintTKAnyway1.AutoSize = true;
            this.checkBoxPrintTKAnyway1.Location = new System.Drawing.Point(3, 273);
            this.checkBoxPrintTKAnyway1.Name = "checkBoxPrintTKAnyway1";
            this.checkBoxPrintTKAnyway1.Size = new System.Drawing.Size(261, 127);
            this.checkBoxPrintTKAnyway1.TabIndex = 15;
            this.checkBoxPrintTKAnyway1.Text = "Print Incoming Orders(Take Away)";
            this.checkBoxPrintTKAnyway1.UseVisualStyleBackColor = true;
            this.checkBoxPrintTKAnyway1.CheckedChanged += new System.EventHandler(this.checkBoxPrintTKAnyway1_CheckedChanged);
            // 
            // tabPageConfigs
            // 
            this.tabPageConfigs.Controls.Add(this.tableLayoutSettingsMain);
            this.tabPageConfigs.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfigs.Name = "tabPageConfigs";
            this.tabPageConfigs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigs.Size = new System.Drawing.Size(628, 569);
            this.tabPageConfigs.TabIndex = 1;
            this.tabPageConfigs.Text = "Configurations";
            this.tabPageConfigs.UseVisualStyleBackColor = true;
            // 
            // tabPageAlarm
            // 
            this.tabPageAlarm.Controls.Add(this.tableLayoutAlarmSettings);
            this.tabPageAlarm.Location = new System.Drawing.Point(4, 29);
            this.tabPageAlarm.Name = "tabPageAlarm";
            this.tabPageAlarm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlarm.Size = new System.Drawing.Size(628, 569);
            this.tabPageAlarm.TabIndex = 3;
            this.tabPageAlarm.Text = "Alarm";
            this.tabPageAlarm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutAlarmSettings
            // 
            this.tableLayoutAlarmSettings.ColumnCount = 3;
            this.tableLayoutAlarmSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutAlarmSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutAlarmSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAlarmSettings.Controls.Add(this.labelClosePopup, 0, 4);
            this.tableLayoutAlarmSettings.Controls.Add(this.labelReopenPopup, 0, 5);
            this.tableLayoutAlarmSettings.Controls.Add(this.textBoxClosePopupAfter, 1, 4);
            this.tableLayoutAlarmSettings.Controls.Add(this.textBoxReopenPopupAfter, 1, 5);
            this.tableLayoutAlarmSettings.Controls.Add(this.labelSeconds1, 2, 4);
            this.tableLayoutAlarmSettings.Controls.Add(this.labelSeconds2, 2, 5);
            this.tableLayoutAlarmSettings.Controls.Add(this.labelConnectionTimeout, 0, 6);
            this.tableLayoutAlarmSettings.Controls.Add(this.textBoxConnectionTimeout, 1, 6);
            this.tableLayoutAlarmSettings.Controls.Add(this.labelSeconds3, 2, 6);
            this.tableLayoutAlarmSettings.Controls.Add(this.panelConnectionLost, 0, 0);
            this.tableLayoutAlarmSettings.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutAlarmSettings.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutAlarmSettings.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutAlarmSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAlarmSettings.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutAlarmSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutAlarmSettings.Name = "tableLayoutAlarmSettings";
            this.tableLayoutAlarmSettings.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutAlarmSettings.RowCount = 8;
            this.tableLayoutAlarmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutAlarmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutAlarmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutAlarmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutAlarmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutAlarmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutAlarmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutAlarmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAlarmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutAlarmSettings.Size = new System.Drawing.Size(622, 563);
            this.tableLayoutAlarmSettings.TabIndex = 1;
            // 
            // labelClosePopup
            // 
            this.labelClosePopup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelClosePopup.AutoSize = true;
            this.labelClosePopup.Location = new System.Drawing.Point(122, 440);
            this.labelClosePopup.Name = "labelClosePopup";
            this.labelClosePopup.Size = new System.Drawing.Size(135, 20);
            this.labelClosePopup.TabIndex = 14;
            this.labelClosePopup.Text = "Close Pop-up after";
            // 
            // labelReopenPopup
            // 
            this.labelReopenPopup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelReopenPopup.AutoSize = true;
            this.labelReopenPopup.Location = new System.Drawing.Point(100, 480);
            this.labelReopenPopup.Name = "labelReopenPopup";
            this.labelReopenPopup.Size = new System.Drawing.Size(157, 20);
            this.labelReopenPopup.TabIndex = 14;
            this.labelReopenPopup.Text = "Re-open Pop-up after";
            // 
            // textBoxClosePopupAfter
            // 
            this.textBoxClosePopupAfter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxClosePopupAfter.Location = new System.Drawing.Point(263, 436);
            this.textBoxClosePopupAfter.Name = "textBoxClosePopupAfter";
            this.textBoxClosePopupAfter.Size = new System.Drawing.Size(94, 27);
            this.textBoxClosePopupAfter.TabIndex = 15;
            this.textBoxClosePopupAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClosePopupAfter_KeyPress);
            // 
            // textBoxReopenPopupAfter
            // 
            this.textBoxReopenPopupAfter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxReopenPopupAfter.Location = new System.Drawing.Point(263, 476);
            this.textBoxReopenPopupAfter.Name = "textBoxReopenPopupAfter";
            this.textBoxReopenPopupAfter.Size = new System.Drawing.Size(94, 27);
            this.textBoxReopenPopupAfter.TabIndex = 15;
            this.textBoxReopenPopupAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClosePopupAfter_KeyPress);
            // 
            // labelSeconds1
            // 
            this.labelSeconds1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSeconds1.AutoSize = true;
            this.labelSeconds1.Location = new System.Drawing.Point(363, 440);
            this.labelSeconds1.Name = "labelSeconds1";
            this.labelSeconds1.Size = new System.Drawing.Size(63, 20);
            this.labelSeconds1.TabIndex = 14;
            this.labelSeconds1.Text = "seconds";
            // 
            // labelSeconds2
            // 
            this.labelSeconds2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSeconds2.AutoSize = true;
            this.labelSeconds2.Location = new System.Drawing.Point(363, 480);
            this.labelSeconds2.Name = "labelSeconds2";
            this.labelSeconds2.Size = new System.Drawing.Size(63, 20);
            this.labelSeconds2.TabIndex = 14;
            this.labelSeconds2.Text = "seconds";
            // 
            // labelConnectionTimeout
            // 
            this.labelConnectionTimeout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelConnectionTimeout.AutoSize = true;
            this.labelConnectionTimeout.Location = new System.Drawing.Point(113, 520);
            this.labelConnectionTimeout.Name = "labelConnectionTimeout";
            this.labelConnectionTimeout.Size = new System.Drawing.Size(144, 20);
            this.labelConnectionTimeout.TabIndex = 14;
            this.labelConnectionTimeout.Text = "Connection timeout";
            // 
            // textBoxConnectionTimeout
            // 
            this.textBoxConnectionTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxConnectionTimeout.Location = new System.Drawing.Point(263, 516);
            this.textBoxConnectionTimeout.Name = "textBoxConnectionTimeout";
            this.textBoxConnectionTimeout.Size = new System.Drawing.Size(94, 27);
            this.textBoxConnectionTimeout.TabIndex = 16;
            // 
            // labelSeconds3
            // 
            this.labelSeconds3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSeconds3.AutoSize = true;
            this.labelSeconds3.Location = new System.Drawing.Point(363, 520);
            this.labelSeconds3.Name = "labelSeconds3";
            this.labelSeconds3.Size = new System.Drawing.Size(63, 20);
            this.labelSeconds3.TabIndex = 14;
            this.labelSeconds3.Text = "seconds";
            // 
            // panelConnectionLost
            // 
            this.panelConnectionLost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutAlarmSettings.SetColumnSpan(this.panelConnectionLost, 3);
            this.panelConnectionLost.Controls.Add(this.tableLayoutAlarmConnection);
            this.panelConnectionLost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConnectionLost.Location = new System.Drawing.Point(13, 13);
            this.panelConnectionLost.Name = "panelConnectionLost";
            this.panelConnectionLost.Size = new System.Drawing.Size(596, 99);
            this.panelConnectionLost.TabIndex = 19;
            // 
            // tableLayoutAlarmConnection
            // 
            this.tableLayoutAlarmConnection.ColumnCount = 1;
            this.tableLayoutAlarmConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAlarmConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutAlarmConnection.Controls.Add(this.checkBoxAlarmConnectionLost, 0, 0);
            this.tableLayoutAlarmConnection.Controls.Add(this.alarmSelectionConnectionLost, 0, 1);
            this.tableLayoutAlarmConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAlarmConnection.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutAlarmConnection.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutAlarmConnection.Name = "tableLayoutAlarmConnection";
            this.tableLayoutAlarmConnection.RowCount = 2;
            this.tableLayoutAlarmConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutAlarmConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutAlarmConnection.Size = new System.Drawing.Size(594, 97);
            this.tableLayoutAlarmConnection.TabIndex = 17;
            // 
            // checkBoxAlarmConnectionLost
            // 
            this.checkBoxAlarmConnectionLost.AutoSize = true;
            this.checkBoxAlarmConnectionLost.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAlarmConnectionLost.Name = "checkBoxAlarmConnectionLost";
            this.checkBoxAlarmConnectionLost.Size = new System.Drawing.Size(244, 23);
            this.checkBoxAlarmConnectionLost.TabIndex = 1;
            this.checkBoxAlarmConnectionLost.Text = "Alarm if no Internet Connection";
            this.checkBoxAlarmConnectionLost.UseVisualStyleBackColor = true;
            this.checkBoxAlarmConnectionLost.CheckedChanged += new System.EventHandler(this.checkBoxAlarmConnectionLost_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutAlarmSettings.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tableLayoutPopup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(13, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 99);
            this.panel1.TabIndex = 20;
            // 
            // tableLayoutPopup
            // 
            this.tableLayoutPopup.ColumnCount = 1;
            this.tableLayoutPopup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPopup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPopup.Controls.Add(this.checkBoxTableReservationPopup, 0, 0);
            this.tableLayoutPopup.Controls.Add(this.alarmSelectionTableReservation, 0, 1);
            this.tableLayoutPopup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPopup.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPopup.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPopup.Name = "tableLayoutPopup";
            this.tableLayoutPopup.RowCount = 2;
            this.tableLayoutPopup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPopup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPopup.Size = new System.Drawing.Size(594, 97);
            this.tableLayoutPopup.TabIndex = 18;
            // 
            // checkBoxTableReservationPopup
            // 
            this.checkBoxTableReservationPopup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxTableReservationPopup.AutoSize = true;
            this.checkBoxTableReservationPopup.Location = new System.Drawing.Point(3, 3);
            this.checkBoxTableReservationPopup.Name = "checkBoxTableReservationPopup";
            this.checkBoxTableReservationPopup.Size = new System.Drawing.Size(224, 23);
            this.checkBoxTableReservationPopup.TabIndex = 4;
            this.checkBoxTableReservationPopup.Text = "Pop-up for Table reservation";
            this.checkBoxTableReservationPopup.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutAlarmSettings.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.tableLayoutTakeAwayAlarm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(13, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 99);
            this.panel2.TabIndex = 22;
            // 
            // tableLayoutTakeAwayAlarm
            // 
            this.tableLayoutTakeAwayAlarm.ColumnCount = 1;
            this.tableLayoutTakeAwayAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTakeAwayAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutTakeAwayAlarm.Controls.Add(this.checkBoxFoodReservationPopup, 0, 0);
            this.tableLayoutTakeAwayAlarm.Controls.Add(this.alarmSelectionFoodReservation, 0, 1);
            this.tableLayoutTakeAwayAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTakeAwayAlarm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutTakeAwayAlarm.Name = "tableLayoutTakeAwayAlarm";
            this.tableLayoutTakeAwayAlarm.RowCount = 2;
            this.tableLayoutTakeAwayAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutTakeAwayAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutTakeAwayAlarm.Size = new System.Drawing.Size(594, 97);
            this.tableLayoutTakeAwayAlarm.TabIndex = 21;
            // 
            // checkBoxFoodReservationPopup
            // 
            this.checkBoxFoodReservationPopup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxFoodReservationPopup.AutoSize = true;
            this.checkBoxFoodReservationPopup.Location = new System.Drawing.Point(3, 3);
            this.checkBoxFoodReservationPopup.Name = "checkBoxFoodReservationPopup";
            this.checkBoxFoodReservationPopup.Size = new System.Drawing.Size(220, 23);
            this.checkBoxFoodReservationPopup.TabIndex = 5;
            this.checkBoxFoodReservationPopup.Text = "Pop-up for food reservation";
            this.checkBoxFoodReservationPopup.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutAlarmSettings.SetColumnSpan(this.panel3, 3);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(13, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 99);
            this.panel3.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.alarmSelectionHotelReservation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxHotelReservationPopup, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 97);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // checkBoxHotelReservationPopup
            // 
            this.checkBoxHotelReservationPopup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxHotelReservationPopup.AutoSize = true;
            this.checkBoxHotelReservationPopup.Location = new System.Drawing.Point(3, 3);
            this.checkBoxHotelReservationPopup.Name = "checkBoxHotelReservationPopup";
            this.checkBoxHotelReservationPopup.Size = new System.Drawing.Size(223, 23);
            this.checkBoxHotelReservationPopup.TabIndex = 6;
            this.checkBoxHotelReservationPopup.Text = "Pop-up for hotel reservation";
            this.checkBoxHotelReservationPopup.UseVisualStyleBackColor = true;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.tableLayoutWelcomeMessages);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 29);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(628, 569);
            this.tabPageMessages.TabIndex = 2;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // tableLayoutWelcomeMessages
            // 
            this.tableLayoutWelcomeMessages.ColumnCount = 2;
            this.tableLayoutWelcomeMessages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutWelcomeMessages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutWelcomeMessages.Controls.Add(this.labelWelcomeRestaurant, 0, 1);
            this.tableLayoutWelcomeMessages.Controls.Add(this.labelWelcomeTakeAway, 0, 2);
            this.tableLayoutWelcomeMessages.Controls.Add(this.labelWelcomeHotel, 0, 3);
            this.tableLayoutWelcomeMessages.Controls.Add(this.textBoxWelcomeRestaurant, 1, 1);
            this.tableLayoutWelcomeMessages.Controls.Add(this.textBoxHaveNiceMeal, 1, 2);
            this.tableLayoutWelcomeMessages.Controls.Add(this.textBoxWelcomeHotel, 1, 3);
            this.tableLayoutWelcomeMessages.Controls.Add(this.labelWelcomeMessages, 0, 0);
            this.tableLayoutWelcomeMessages.Controls.Add(this.labelDeclineMessages, 0, 4);
            this.tableLayoutWelcomeMessages.Controls.Add(this.labelDeclineRestaurant, 0, 5);
            this.tableLayoutWelcomeMessages.Controls.Add(this.labelDeclineTakeAway, 0, 6);
            this.tableLayoutWelcomeMessages.Controls.Add(this.labelDeclineHotel, 0, 7);
            this.tableLayoutWelcomeMessages.Controls.Add(this.textBoxDeclineRestaurant, 1, 5);
            this.tableLayoutWelcomeMessages.Controls.Add(this.textBoxDeclineTakeAway, 1, 6);
            this.tableLayoutWelcomeMessages.Controls.Add(this.textBoxDeclineHotel, 1, 7);
            this.tableLayoutWelcomeMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutWelcomeMessages.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutWelcomeMessages.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutWelcomeMessages.Name = "tableLayoutWelcomeMessages";
            this.tableLayoutWelcomeMessages.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutWelcomeMessages.RowCount = 9;
            this.tableLayoutWelcomeMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutWelcomeMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutWelcomeMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutWelcomeMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutWelcomeMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutWelcomeMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutWelcomeMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutWelcomeMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutWelcomeMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutWelcomeMessages.Size = new System.Drawing.Size(622, 563);
            this.tableLayoutWelcomeMessages.TabIndex = 1;
            // 
            // labelWelcomeRestaurant
            // 
            this.labelWelcomeRestaurant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWelcomeRestaurant.AutoSize = true;
            this.labelWelcomeRestaurant.Location = new System.Drawing.Point(25, 70);
            this.labelWelcomeRestaurant.Name = "labelWelcomeRestaurant";
            this.labelWelcomeRestaurant.Size = new System.Drawing.Size(82, 20);
            this.labelWelcomeRestaurant.TabIndex = 0;
            this.labelWelcomeRestaurant.Text = "Restaurant";
            // 
            // labelWelcomeTakeAway
            // 
            this.labelWelcomeTakeAway.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWelcomeTakeAway.AutoSize = true;
            this.labelWelcomeTakeAway.Location = new System.Drawing.Point(26, 150);
            this.labelWelcomeTakeAway.Name = "labelWelcomeTakeAway";
            this.labelWelcomeTakeAway.Size = new System.Drawing.Size(81, 20);
            this.labelWelcomeTakeAway.TabIndex = 0;
            this.labelWelcomeTakeAway.Text = "Take Away";
            // 
            // labelWelcomeHotel
            // 
            this.labelWelcomeHotel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWelcomeHotel.AutoSize = true;
            this.labelWelcomeHotel.Location = new System.Drawing.Point(61, 230);
            this.labelWelcomeHotel.Name = "labelWelcomeHotel";
            this.labelWelcomeHotel.Size = new System.Drawing.Size(46, 20);
            this.labelWelcomeHotel.TabIndex = 0;
            this.labelWelcomeHotel.Text = "Hotel";
            // 
            // textBoxWelcomeRestaurant
            // 
            this.textBoxWelcomeRestaurant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWelcomeRestaurant.Location = new System.Drawing.Point(110, 45);
            this.textBoxWelcomeRestaurant.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.textBoxWelcomeRestaurant.Multiline = true;
            this.textBoxWelcomeRestaurant.Name = "textBoxWelcomeRestaurant";
            this.textBoxWelcomeRestaurant.Size = new System.Drawing.Size(502, 70);
            this.textBoxWelcomeRestaurant.TabIndex = 1;
            // 
            // textBoxHaveNiceMeal
            // 
            this.textBoxHaveNiceMeal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHaveNiceMeal.Location = new System.Drawing.Point(110, 125);
            this.textBoxHaveNiceMeal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.textBoxHaveNiceMeal.Multiline = true;
            this.textBoxHaveNiceMeal.Name = "textBoxHaveNiceMeal";
            this.textBoxHaveNiceMeal.Size = new System.Drawing.Size(502, 70);
            this.textBoxHaveNiceMeal.TabIndex = 1;
            // 
            // textBoxWelcomeHotel
            // 
            this.textBoxWelcomeHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWelcomeHotel.Location = new System.Drawing.Point(110, 205);
            this.textBoxWelcomeHotel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.textBoxWelcomeHotel.Multiline = true;
            this.textBoxWelcomeHotel.Name = "textBoxWelcomeHotel";
            this.textBoxWelcomeHotel.Size = new System.Drawing.Size(502, 70);
            this.textBoxWelcomeHotel.TabIndex = 1;
            // 
            // labelWelcomeMessages
            // 
            this.labelWelcomeMessages.AutoSize = true;
            this.tableLayoutWelcomeMessages.SetColumnSpan(this.labelWelcomeMessages, 2);
            this.labelWelcomeMessages.Location = new System.Drawing.Point(13, 10);
            this.labelWelcomeMessages.Name = "labelWelcomeMessages";
            this.labelWelcomeMessages.Size = new System.Drawing.Size(141, 20);
            this.labelWelcomeMessages.TabIndex = 2;
            this.labelWelcomeMessages.Text = "Welcome Messages";
            // 
            // labelDeclineMessages
            // 
            this.labelDeclineMessages.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDeclineMessages.AutoSize = true;
            this.tableLayoutWelcomeMessages.SetColumnSpan(this.labelDeclineMessages, 2);
            this.labelDeclineMessages.Location = new System.Drawing.Point(13, 285);
            this.labelDeclineMessages.Name = "labelDeclineMessages";
            this.labelDeclineMessages.Size = new System.Drawing.Size(129, 20);
            this.labelDeclineMessages.TabIndex = 2;
            this.labelDeclineMessages.Text = "Decline Messages";
            // 
            // labelDeclineRestaurant
            // 
            this.labelDeclineRestaurant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDeclineRestaurant.AutoSize = true;
            this.labelDeclineRestaurant.Location = new System.Drawing.Point(25, 340);
            this.labelDeclineRestaurant.Name = "labelDeclineRestaurant";
            this.labelDeclineRestaurant.Size = new System.Drawing.Size(82, 20);
            this.labelDeclineRestaurant.TabIndex = 0;
            this.labelDeclineRestaurant.Text = "Restaurant";
            // 
            // labelDeclineTakeAway
            // 
            this.labelDeclineTakeAway.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDeclineTakeAway.AutoSize = true;
            this.labelDeclineTakeAway.Location = new System.Drawing.Point(26, 420);
            this.labelDeclineTakeAway.Name = "labelDeclineTakeAway";
            this.labelDeclineTakeAway.Size = new System.Drawing.Size(81, 20);
            this.labelDeclineTakeAway.TabIndex = 0;
            this.labelDeclineTakeAway.Text = "Take Away";
            // 
            // labelDeclineHotel
            // 
            this.labelDeclineHotel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDeclineHotel.AutoSize = true;
            this.labelDeclineHotel.Location = new System.Drawing.Point(61, 500);
            this.labelDeclineHotel.Name = "labelDeclineHotel";
            this.labelDeclineHotel.Size = new System.Drawing.Size(46, 20);
            this.labelDeclineHotel.TabIndex = 0;
            this.labelDeclineHotel.Text = "Hotel";
            // 
            // textBoxDeclineRestaurant
            // 
            this.textBoxDeclineRestaurant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeclineRestaurant.Location = new System.Drawing.Point(110, 315);
            this.textBoxDeclineRestaurant.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.textBoxDeclineRestaurant.Multiline = true;
            this.textBoxDeclineRestaurant.Name = "textBoxDeclineRestaurant";
            this.textBoxDeclineRestaurant.Size = new System.Drawing.Size(502, 70);
            this.textBoxDeclineRestaurant.TabIndex = 1;
            // 
            // textBoxDeclineTakeAway
            // 
            this.textBoxDeclineTakeAway.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeclineTakeAway.Location = new System.Drawing.Point(110, 395);
            this.textBoxDeclineTakeAway.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.textBoxDeclineTakeAway.Multiline = true;
            this.textBoxDeclineTakeAway.Name = "textBoxDeclineTakeAway";
            this.textBoxDeclineTakeAway.Size = new System.Drawing.Size(502, 70);
            this.textBoxDeclineTakeAway.TabIndex = 1;
            // 
            // textBoxDeclineHotel
            // 
            this.textBoxDeclineHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeclineHotel.Location = new System.Drawing.Point(110, 475);
            this.textBoxDeclineHotel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.textBoxDeclineHotel.Multiline = true;
            this.textBoxDeclineHotel.Name = "textBoxDeclineHotel";
            this.textBoxDeclineHotel.Size = new System.Drawing.Size(502, 70);
            this.textBoxDeclineHotel.TabIndex = 1;
            // 
            // tabPageSorryMessage
            // 
            this.tabPageSorryMessage.Controls.Add(this.tableLayoutPanel3);
            this.tabPageSorryMessage.Location = new System.Drawing.Point(4, 29);
            this.tabPageSorryMessage.Name = "tabPageSorryMessage";
            this.tabPageSorryMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSorryMessage.Size = new System.Drawing.Size(628, 569);
            this.tabPageSorryMessage.TabIndex = 4;
            this.tabPageSorryMessage.Text = "Sorry Messages";
            this.tabPageSorryMessage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelSorryRestaurant, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelSorryTakeAway, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxSorryRestaurant, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxSorryTakeAway, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(622, 563);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelSorryRestaurant
            // 
            this.labelSorryRestaurant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSorryRestaurant.AutoSize = true;
            this.labelSorryRestaurant.Location = new System.Drawing.Point(15, 60);
            this.labelSorryRestaurant.Name = "labelSorryRestaurant";
            this.labelSorryRestaurant.Size = new System.Drawing.Size(82, 20);
            this.labelSorryRestaurant.TabIndex = 1;
            this.labelSorryRestaurant.Text = "Restaurant";
            // 
            // labelSorryTakeAway
            // 
            this.labelSorryTakeAway.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSorryTakeAway.AutoSize = true;
            this.labelSorryTakeAway.Location = new System.Drawing.Point(16, 140);
            this.labelSorryTakeAway.Name = "labelSorryTakeAway";
            this.labelSorryTakeAway.Size = new System.Drawing.Size(81, 20);
            this.labelSorryTakeAway.TabIndex = 1;
            this.labelSorryTakeAway.Text = "Take Away";
            // 
            // textBoxSorryRestaurant
            // 
            this.textBoxSorryRestaurant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSorryRestaurant.Location = new System.Drawing.Point(103, 33);
            this.textBoxSorryRestaurant.Multiline = true;
            this.textBoxSorryRestaurant.Name = "textBoxSorryRestaurant";
            this.textBoxSorryRestaurant.Size = new System.Drawing.Size(516, 74);
            this.textBoxSorryRestaurant.TabIndex = 2;
            // 
            // textBoxSorryTakeAway
            // 
            this.textBoxSorryTakeAway.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSorryTakeAway.Location = new System.Drawing.Point(103, 113);
            this.textBoxSorryTakeAway.Multiline = true;
            this.textBoxSorryTakeAway.Name = "textBoxSorryTakeAway";
            this.textBoxSorryTakeAway.Size = new System.Drawing.Size(516, 74);
            this.textBoxSorryTakeAway.TabIndex = 3;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(174, 14);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 28);
            this.comboBoxLanguage.TabIndex = 2;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(13, 17);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(76, 20);
            this.labelLanguage.TabIndex = 3;
            this.labelLanguage.Text = "Language";
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Red;
            this.buttonQuit.ForeColor = System.Drawing.Color.White;
            this.buttonQuit.Location = new System.Drawing.Point(457, 13);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(172, 29);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit ";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "TLS version";
            // 
            // comboBoxTLSVersion
            // 
            this.comboBoxTLSVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTLSVersion.FormattingEnabled = true;
            this.comboBoxTLSVersion.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3"});
            this.comboBoxTLSVersion.Location = new System.Drawing.Point(86, 1);
            this.comboBoxTLSVersion.Name = "comboBoxTLSVersion";
            this.comboBoxTLSVersion.Size = new System.Drawing.Size(94, 28);
            this.comboBoxTLSVersion.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboBoxTLSVersion);
            this.panel4.Location = new System.Drawing.Point(13, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 30);
            this.panel4.TabIndex = 14;
            // 
            // alarmSelectionConnectionLost
            // 
            this.alarmSelectionConnectionLost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarmSelectionConnectionLost.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.alarmSelectionConnectionLost.Location = new System.Drawing.Point(20, 29);
            this.alarmSelectionConnectionLost.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.alarmSelectionConnectionLost.Name = "alarmSelectionConnectionLost";
            this.alarmSelectionConnectionLost.Size = new System.Drawing.Size(574, 68);
            this.alarmSelectionConnectionLost.TabIndex = 13;
            // 
            // alarmSelectionTableReservation
            // 
            this.alarmSelectionTableReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarmSelectionTableReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.alarmSelectionTableReservation.Location = new System.Drawing.Point(20, 29);
            this.alarmSelectionTableReservation.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.alarmSelectionTableReservation.Name = "alarmSelectionTableReservation";
            this.alarmSelectionTableReservation.Size = new System.Drawing.Size(574, 68);
            this.alarmSelectionTableReservation.TabIndex = 13;
            // 
            // alarmSelectionFoodReservation
            // 
            this.alarmSelectionFoodReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarmSelectionFoodReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.alarmSelectionFoodReservation.Location = new System.Drawing.Point(20, 29);
            this.alarmSelectionFoodReservation.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.alarmSelectionFoodReservation.Name = "alarmSelectionFoodReservation";
            this.alarmSelectionFoodReservation.Size = new System.Drawing.Size(574, 68);
            this.alarmSelectionFoodReservation.TabIndex = 13;
            // 
            // alarmSelectionHotelReservation
            // 
            this.alarmSelectionHotelReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarmSelectionHotelReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.alarmSelectionHotelReservation.Location = new System.Drawing.Point(20, 29);
            this.alarmSelectionHotelReservation.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.alarmSelectionHotelReservation.Name = "alarmSelectionHotelReservation";
            this.alarmSelectionHotelReservation.Size = new System.Drawing.Size(574, 68);
            this.alarmSelectionHotelReservation.TabIndex = 13;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonSaveOptions;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(666, 703);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonSaveOptions);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Printer Gate Settings";
            this.tableLayoutSettingsMain.ResumeLayout(false);
            this.tableLayoutSettingsMain.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPagePrinters.ResumeLayout(false);
            this.tableLayoutServerAndPrinters.ResumeLayout(false);
            this.tableLayoutServerHeader.ResumeLayout(false);
            this.tableLayoutPrintersHeader.ResumeLayout(false);
            this.tableLayoutPrintersHeader.PerformLayout();
            this.tableLayoutHostSettings.ResumeLayout(false);
            this.tableLayoutHostSettings.PerformLayout();
            this.tableLayoutPrintersList.ResumeLayout(false);
            this.tableLayoutPrintersList.PerformLayout();
            this.tabPageConfigs.ResumeLayout(false);
            this.tabPageAlarm.ResumeLayout(false);
            this.tableLayoutAlarmSettings.ResumeLayout(false);
            this.tableLayoutAlarmSettings.PerformLayout();
            this.panelConnectionLost.ResumeLayout(false);
            this.tableLayoutAlarmConnection.ResumeLayout(false);
            this.tableLayoutAlarmConnection.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPopup.ResumeLayout(false);
            this.tableLayoutPopup.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutTakeAwayAlarm.ResumeLayout(false);
            this.tableLayoutTakeAwayAlarm.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageMessages.ResumeLayout(false);
            this.tableLayoutWelcomeMessages.ResumeLayout(false);
            this.tableLayoutWelcomeMessages.PerformLayout();
            this.tabPageSorryMessage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutSettingsMain;

		private global::System.Windows.Forms.CheckBox checkBoxXMLExport;

		private global::System.Windows.Forms.CheckBox checkBoxWelcomeMessage;

		private global::System.Windows.Forms.CheckBox checkBoxFullAddressDelivery;

		private global::System.Windows.Forms.CheckBox checkBoxShowPrinterDialog;

		private global::System.Windows.Forms.Button buttonSaveOptions;

		private global::System.Windows.Forms.TabControl tabControlSettings;

		private global::System.Windows.Forms.TabPage tabPagePrinters;

		private global::System.Windows.Forms.TabPage tabPageConfigs;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutServerAndPrinters;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutServerHeader;

		private global::System.Windows.Forms.Label labelServerHeader;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPrintersList;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPrintersHeader;

		private global::System.Windows.Forms.Button buttonAddPrinter;

		private global::System.Windows.Forms.Label labelPrinters;

		private global::System.Windows.Forms.Label labelPrintersWarning;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutHostSettings;

		private global::System.Windows.Forms.Label labelServer;

		private global::System.Windows.Forms.Button buttonChangeServer;

		private global::System.Windows.Forms.TabPage tabPageMessages;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutWelcomeMessages;

		private global::System.Windows.Forms.Label labelWelcomeRestaurant;

		private global::System.Windows.Forms.Label labelWelcomeTakeAway;

		private global::System.Windows.Forms.Label labelWelcomeHotel;

		private global::System.Windows.Forms.TextBox textBoxWelcomeRestaurant;

		private global::System.Windows.Forms.TextBox textBoxHaveNiceMeal;

		private global::System.Windows.Forms.TextBox textBoxWelcomeHotel;

		private global::System.Windows.Forms.TabPage tabPageAlarm;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutAlarmSettings;

		private global::System.Windows.Forms.CheckBox checkBoxTableReservationPopup;

		private global::System.Windows.Forms.CheckBox checkBoxFoodReservationPopup;

		private global::System.Windows.Forms.CheckBox checkBoxHotelReservationPopup;

		private global::PrinterGateXP.AlarmSelection alarmSelectionTableReservation;

		private global::PrinterGateXP.AlarmSelection alarmSelectionFoodReservation;

		private global::PrinterGateXP.AlarmSelection alarmSelectionHotelReservation;

		private global::System.Windows.Forms.ComboBox comboBoxLanguage;

		private global::System.Windows.Forms.Label labelLanguage;

		private global::System.Windows.Forms.Label labelClosePopup;

		private global::System.Windows.Forms.Label labelReopenPopup;

		private global::System.Windows.Forms.TextBox textBoxClosePopupAfter;

		private global::System.Windows.Forms.TextBox textBoxReopenPopupAfter;

		private global::System.Windows.Forms.Label labelSeconds1;

		private global::System.Windows.Forms.Label labelSeconds2;

		private global::System.Windows.Forms.Label labelConnectionTimeout;

		private global::System.Windows.Forms.TextBox textBoxConnectionTimeout;

		private global::System.Windows.Forms.Label labelSeconds3;

		private global::System.Windows.Forms.Label labelWelcomeMessages;

		private global::System.Windows.Forms.Label labelDeclineMessages;

		private global::System.Windows.Forms.Label labelDeclineRestaurant;

		private global::System.Windows.Forms.Label labelDeclineTakeAway;

		private global::System.Windows.Forms.Label labelDeclineHotel;

		private global::System.Windows.Forms.TextBox textBoxDeclineRestaurant;

		private global::System.Windows.Forms.TextBox textBoxDeclineTakeAway;

		private global::System.Windows.Forms.TextBox textBoxDeclineHotel;

		private global::System.Windows.Forms.CheckBox checkBoxShowBalloon;

		private global::System.Windows.Forms.Button buttonQuit;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPopup;

		private global::System.Windows.Forms.Panel panelConnectionLost;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutAlarmConnection;

		private global::System.Windows.Forms.CheckBox checkBoxAlarmConnectionLost;

		private global::PrinterGateXP.AlarmSelection alarmSelectionConnectionLost;

		private global::System.Windows.Forms.Panel panel1;

		private global::System.Windows.Forms.Panel panel2;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutTakeAwayAlarm;

		private global::System.Windows.Forms.Panel panel3;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		private global::System.Windows.Forms.Label labelStartupDelay;

		private global::System.Windows.Forms.TextBox textBoxStartupDelay;

		private global::System.Windows.Forms.TabPage tabPageSorryMessage;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

		private global::System.Windows.Forms.Label labelSorryRestaurant;

		private global::System.Windows.Forms.Label labelSorryTakeAway;

		private global::System.Windows.Forms.TextBox textBoxSorryRestaurant;

		private global::System.Windows.Forms.TextBox textBoxSorryTakeAway;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonExportBrowse;
        private System.Windows.Forms.Label labelSeconds4;
        private System.Windows.Forms.TextBox textBoxXmlPath;
        private System.Windows.Forms.CheckBox checkBoxBeautyPrintWhenConfirmed1;
        private System.Windows.Forms.CheckBox checkBoxPrintReservationAnyWay1;
        private System.Windows.Forms.CheckBox checkBoxReservationAutoConfirm1;
        private System.Windows.Forms.CheckBox checkBoxTakeAwayAutoConfirm1;
        private System.Windows.Forms.CheckBox checkBoxPrintTKAnyway1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxTLSVersion;
    }
}
