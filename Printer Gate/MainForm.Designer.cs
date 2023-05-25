namespace PrinterGateXP
{
	// Token: 0x02000012 RID: 18
	public partial class MainForm : global::System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonHideToTray = new System.Windows.Forms.Button();
            this.labelServerStatus = new System.Windows.Forms.Label();
            this.spinnerLoading = new PrinterGateXP.SpinningCircles();
            this.buttonBigClose = new System.Windows.Forms.Button();
            this.tableLayoutOrders = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutOrdersHeader = new System.Windows.Forms.TableLayoutPanel();
            this.labelReservations = new System.Windows.Forms.Label();
            this.labelReservationPrinterWarning = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTakeAway = new System.Windows.Forms.Label();
            this.labelTakeAwayPrinterWarning = new System.Windows.Forms.Label();
            this.ordersTableReservation = new PrinterGateXP.OrdersTable();
            this.ordersTableTakeAway = new PrinterGateXP.OrdersTable();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.tableLayoutOrders.SuspendLayout();
            this.tableLayoutOrdersHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.tableLayoutTitleBar, 0, 0);
            this.tableLayoutMain.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1020, 764);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // tableLayoutTitleBar
            // 
            this.tableLayoutTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.tableLayoutTitleBar.ColumnCount = 8;
            this.tableLayoutTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutTitleBar.Controls.Add(this.appIcon, 0, 0);
            this.tableLayoutTitleBar.Controls.Add(this.btnMaximize, 7, 0);
            this.tableLayoutTitleBar.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutTitleBar.Controls.Add(this.buttonSettings, 5, 0);
            this.tableLayoutTitleBar.Controls.Add(this.buttonHideToTray, 6, 0);
            this.tableLayoutTitleBar.Controls.Add(this.labelServerStatus, 4, 0);
            this.tableLayoutTitleBar.Controls.Add(this.spinnerLoading, 3, 0);
            this.tableLayoutTitleBar.Controls.Add(this.buttonBigClose, 2, 0);
            this.tableLayoutTitleBar.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutTitleBar.Name = "tableLayoutTitleBar";
            this.tableLayoutTitleBar.RowCount = 1;
            this.tableLayoutTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutTitleBar.Size = new System.Drawing.Size(1020, 60);
            this.tableLayoutTitleBar.TabIndex = 4;
            this.tableLayoutTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutTitleBarSpacer_MouseDown);
            // 
            // appIcon
            // 
            this.appIcon.BackgroundImage = global::PrinterGateXP.Properties.Resources.appIcon_BackgroundImage;
            this.appIcon.InitialImage = null;
            this.appIcon.Location = new System.Drawing.Point(10, 10);
            this.appIcon.Margin = new System.Windows.Forms.Padding(10);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(40, 40);
            this.appIcon.TabIndex = 0;
            this.appIcon.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::PrinterGateXP.Properties.Resources.restore_up;
            this.btnMaximize.Location = new System.Drawing.Point(960, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(60, 60);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.OnMaximize);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(63, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(147, 60);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Printer Gate 2.0";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutTitleBarSpacer_MouseDown);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Image = global::PrinterGateXP.Properties.Resources.buttonSettings;
            this.buttonSettings.Location = new System.Drawing.Point(840, 0);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(60, 60);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // buttonHideToTray
            // 
            this.buttonHideToTray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHideToTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHideToTray.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHideToTray.FlatAppearance.BorderSize = 0;
            this.buttonHideToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHideToTray.Image = global::PrinterGateXP.Properties.Resources.hide_up;
            this.buttonHideToTray.Location = new System.Drawing.Point(900, 0);
            this.buttonHideToTray.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHideToTray.Name = "buttonHideToTray";
            this.buttonHideToTray.Size = new System.Drawing.Size(60, 60);
            this.buttonHideToTray.TabIndex = 2;
            this.buttonHideToTray.UseVisualStyleBackColor = false;
            this.buttonHideToTray.Click += new System.EventHandler(this.OnHideToTray);
            // 
            // labelServerStatus
            // 
            this.labelServerStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelServerStatus.Location = new System.Drawing.Point(795, 15);
            this.labelServerStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelServerStatus.Name = "labelServerStatus";
            this.labelServerStatus.Size = new System.Drawing.Size(30, 30);
            this.labelServerStatus.TabIndex = 5;
            // 
            // spinnerLoading
            // 
            this.spinnerLoading.BackColor = System.Drawing.Color.Transparent;
            this.spinnerLoading.Location = new System.Drawing.Point(723, 3);
            this.spinnerLoading.Name = "spinnerLoading";
            this.spinnerLoading.Size = new System.Drawing.Size(54, 54);
            this.spinnerLoading.TabIndex = 6;
            this.spinnerLoading.Text = "spinningCircles1";
            // 
            // buttonBigClose
            // 
            this.buttonBigClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBigClose.BackColor = System.Drawing.Color.Red;
            this.buttonBigClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBigClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBigClose.FlatAppearance.BorderSize = 0;
            this.buttonBigClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBigClose.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBigClose.ForeColor = System.Drawing.Color.White;
            this.buttonBigClose.Location = new System.Drawing.Point(400, 0);
            this.buttonBigClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBigClose.Name = "buttonBigClose";
            this.buttonBigClose.Size = new System.Drawing.Size(220, 60);
            this.buttonBigClose.TabIndex = 2;
            this.buttonBigClose.Text = "Close";
            this.buttonBigClose.UseVisualStyleBackColor = false;
            this.buttonBigClose.Click += new System.EventHandler(this.OnHideToTray);
            // 
            // tableLayoutOrders
            // 
            this.tableLayoutOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(243)))));
            this.tableLayoutOrders.ColumnCount = 1;
            this.tableLayoutOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOrders.Controls.Add(this.tableLayoutOrdersHeader, 0, 0);
            this.tableLayoutOrders.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutOrders.Controls.Add(this.ordersTableReservation, 0, 1);
            this.tableLayoutOrders.Controls.Add(this.ordersTableTakeAway, 0, 3);
            this.tableLayoutOrders.Controls.Add(this.pictureBoxLogo, 0, 4);
            this.tableLayoutOrders.Location = new System.Drawing.Point(1, 62);
            this.tableLayoutOrders.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutOrders.Name = "tableLayoutOrders";
            this.tableLayoutOrders.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutOrders.RowCount = 5;
            this.tableLayoutOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutOrders.Size = new System.Drawing.Size(1020, 704);
            this.tableLayoutOrders.TabIndex = 1;
            // 
            // tableLayoutOrdersHeader
            // 
            this.tableLayoutOrdersHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.tableLayoutOrdersHeader.ColumnCount = 2;
            this.tableLayoutOrdersHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutOrdersHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOrdersHeader.Controls.Add(this.labelReservations, 0, 0);
            this.tableLayoutOrdersHeader.Controls.Add(this.labelReservationPrinterWarning, 1, 0);
            this.tableLayoutOrdersHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutOrdersHeader.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutOrdersHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutOrdersHeader.Name = "tableLayoutOrdersHeader";
            this.tableLayoutOrdersHeader.RowCount = 1;
            this.tableLayoutOrdersHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOrdersHeader.Size = new System.Drawing.Size(980, 40);
            this.tableLayoutOrdersHeader.TabIndex = 2;
            // 
            // labelReservations
            // 
            this.labelReservations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelReservations.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelReservations.ForeColor = System.Drawing.Color.White;
            this.labelReservations.Location = new System.Drawing.Point(10, 0);
            this.labelReservations.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelReservations.Name = "labelReservations";
            this.labelReservations.Size = new System.Drawing.Size(115, 40);
            this.labelReservations.TabIndex = 0;
            this.labelReservations.Text = "Reservations";
            this.labelReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReservationPrinterWarning
            // 
            this.labelReservationPrinterWarning.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelReservationPrinterWarning.AutoSize = true;
            this.labelReservationPrinterWarning.ForeColor = System.Drawing.Color.White;
            this.labelReservationPrinterWarning.Location = new System.Drawing.Point(781, 10);
            this.labelReservationPrinterWarning.Name = "labelReservationPrinterWarning";
            this.labelReservationPrinterWarning.Size = new System.Drawing.Size(196, 20);
            this.labelReservationPrinterWarning.TabIndex = 1;
            this.labelReservationPrinterWarning.Text = "Printer is not setup correctly.";
            this.labelReservationPrinterWarning.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelTakeAway, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTakeAwayPrinterWarning, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 295);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 40);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelTakeAway
            // 
            this.labelTakeAway.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTakeAway.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelTakeAway.ForeColor = System.Drawing.Color.White;
            this.labelTakeAway.Location = new System.Drawing.Point(10, 0);
            this.labelTakeAway.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelTakeAway.Name = "labelTakeAway";
            this.labelTakeAway.Size = new System.Drawing.Size(115, 40);
            this.labelTakeAway.TabIndex = 0;
            this.labelTakeAway.Text = "Take Away";
            this.labelTakeAway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTakeAwayPrinterWarning
            // 
            this.labelTakeAwayPrinterWarning.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTakeAwayPrinterWarning.AutoSize = true;
            this.labelTakeAwayPrinterWarning.ForeColor = System.Drawing.Color.White;
            this.labelTakeAwayPrinterWarning.Location = new System.Drawing.Point(764, 10);
            this.labelTakeAwayPrinterWarning.Name = "labelTakeAwayPrinterWarning";
            this.labelTakeAwayPrinterWarning.Size = new System.Drawing.Size(213, 20);
            this.labelTakeAwayPrinterWarning.TabIndex = 1;
            this.labelTakeAwayPrinterWarning.Text = "Printers are not setup correctly.";
            this.labelTakeAwayPrinterWarning.Visible = false;
            // 
            // ordersTableReservation
            // 
            this.ordersTableReservation.AutoSize = true;
            this.ordersTableReservation.BackColor = System.Drawing.Color.White;
            this.ordersTableReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTableReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersTableReservation.Location = new System.Drawing.Point(26, 66);
            this.ordersTableReservation.Margin = new System.Windows.Forms.Padding(6);
            this.ordersTableReservation.Name = "ordersTableReservation";
            this.ordersTableReservation.Size = new System.Drawing.Size(968, 223);
            this.ordersTableReservation.TabIndex = 4;
            // 
            // ordersTableTakeAway
            // 
            this.ordersTableTakeAway.AutoSize = true;
            this.ordersTableTakeAway.BackColor = System.Drawing.Color.White;
            this.ordersTableTakeAway.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTableTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersTableTakeAway.Location = new System.Drawing.Point(26, 341);
            this.ordersTableTakeAway.Margin = new System.Windows.Forms.Padding(6);
            this.ordersTableTakeAway.Name = "ordersTableTakeAway";
            this.ordersTableTakeAway.Size = new System.Drawing.Size(968, 223);
            this.ordersTableTakeAway.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogo.Image = global::PrinterGateXP.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(797, 573);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 108);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutOrders);
            this.Controls.Add(this.tableLayoutMain);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutTitleBar.ResumeLayout(false);
            this.tableLayoutTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.tableLayoutOrders.ResumeLayout(false);
            this.tableLayoutOrders.PerformLayout();
            this.tableLayoutOrdersHeader.ResumeLayout(false);
            this.tableLayoutOrdersHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

		}

		
		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutMain;

		
		private global::System.Windows.Forms.PictureBox appIcon;

		private global::System.Windows.Forms.Button btnMaximize;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutTitleBar;

		private global::System.Windows.Forms.Label labelTitle;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutOrders;

		private global::System.Windows.Forms.Button buttonSettings;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutOrdersHeader;

		private global::System.Windows.Forms.Label labelReservations;

		private global::System.Windows.Forms.Label labelServerStatus;

		private global::System.Windows.Forms.Button buttonHideToTray;

		private global::PrinterGateXP.SpinningCircles spinnerLoading;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		private global::System.Windows.Forms.Label labelTakeAway;

		private global::PrinterGateXP.OrdersTable ordersTableReservation;

		private global::PrinterGateXP.OrdersTable ordersTableTakeAway;

		private global::System.Windows.Forms.Label labelReservationPrinterWarning;

		private global::System.Windows.Forms.Label labelTakeAwayPrinterWarning;

		private global::System.Windows.Forms.Button buttonBigClose;

		private global::System.Windows.Forms.PictureBox pictureBoxLogo;
	}
}
