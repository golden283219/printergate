namespace PrinterGateXP
{
    partial class TicketItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEmailTitle = new System.Windows.Forms.Label();
            this.labelPhoneTitle = new System.Windows.Forms.Label();
            this.labelDateTimeTitle = new System.Windows.Forms.Label();
            this.labelNoTitle = new System.Windows.Forms.Label();
            this.group1 = new System.Windows.Forms.Panel();
            this.labelNameTitle = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Root = new System.Windows.Forms.FlowLayoutPanel();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.labelDateTimeTitle1 = new System.Windows.Forms.Label();
            this.labelDateTime1 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.detailPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPart1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPart2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPart3 = new System.Windows.Forms.FlowLayoutPanel();
            this.group3 = new System.Windows.Forms.Panel();
            this.buttonPrintAsBeauty = new System.Windows.Forms.Button();
            this.buttonPrintAsTicket = new System.Windows.Forms.Button();
            this.labelStatusTitle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPrintedTitle = new System.Windows.Forms.Label();
            this.labelPrinted = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonStress = new System.Windows.Forms.Button();
            this.group1.SuspendLayout();
            this.flowLayoutPanel_Root.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.flowLayoutPart1.SuspendLayout();
            this.flowLayoutPart3.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelDateTime.Location = new System.Drawing.Point(64, 15);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(61, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "02.11.2022";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDateTime.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelNo
            // 
            this.labelNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNo.AutoSize = true;
            this.labelNo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelNo.Location = new System.Drawing.Point(77, 3);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(37, 13);
            this.labelNo.TabIndex = 7;
            this.labelNo.Text = "12345";
            this.labelNo.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelName.Location = new System.Drawing.Point(3, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(102, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Christoph Wenger";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPhone.Location = new System.Drawing.Point(46, 62);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(81, 13);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "+41792770909";
            this.labelPhone.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelEmail.Location = new System.Drawing.Point(46, 74);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(96, 13);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "office@weratv.ch";
            this.labelEmail.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelEmailTitle
            // 
            this.labelEmailTitle.AutoSize = true;
            this.labelEmailTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelEmailTitle.Location = new System.Drawing.Point(3, 74);
            this.labelEmailTitle.Name = "labelEmailTitle";
            this.labelEmailTitle.Size = new System.Drawing.Size(42, 13);
            this.labelEmailTitle.TabIndex = 14;
            this.labelEmailTitle.Text = "E-mail:";
            this.labelEmailTitle.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelPhoneTitle
            // 
            this.labelPhoneTitle.AutoSize = true;
            this.labelPhoneTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelPhoneTitle.Location = new System.Drawing.Point(3, 62);
            this.labelPhoneTitle.Name = "labelPhoneTitle";
            this.labelPhoneTitle.Size = new System.Drawing.Size(44, 13);
            this.labelPhoneTitle.TabIndex = 15;
            this.labelPhoneTitle.Text = "Phone:";
            this.labelPhoneTitle.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelDateTimeTitle
            // 
            this.labelDateTimeTitle.AutoSize = true;
            this.labelDateTimeTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelDateTimeTitle.Location = new System.Drawing.Point(3, 15);
            this.labelDateTimeTitle.Name = "labelDateTimeTitle";
            this.labelDateTimeTitle.Size = new System.Drawing.Size(64, 13);
            this.labelDateTimeTitle.TabIndex = 17;
            this.labelDateTimeTitle.Text = "Date/Time:";
            this.labelDateTimeTitle.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelNoTitle
            // 
            this.labelNoTitle.AutoSize = true;
            this.labelNoTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelNoTitle.Location = new System.Drawing.Point(3, 3);
            this.labelNoTitle.Name = "labelNoTitle";
            this.labelNoTitle.Size = new System.Drawing.Size(71, 13);
            this.labelNoTitle.TabIndex = 18;
            this.labelNoTitle.Text = "Reservation:";
            this.labelNoTitle.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // group1
            // 
            this.group1.Controls.Add(this.labelNo);
            this.group1.Controls.Add(this.labelNoTitle);
            this.group1.Controls.Add(this.labelDateTimeTitle);
            this.group1.Controls.Add(this.labelDateTime);
            this.group1.Controls.Add(this.labelNameTitle);
            this.group1.Controls.Add(this.labelName);
            this.group1.Controls.Add(this.labelPhoneTitle);
            this.group1.Controls.Add(this.labelPhone);
            this.group1.Controls.Add(this.labelEmailTitle);
            this.group1.Controls.Add(this.labelEmail);
            this.group1.Controls.Add(this.buttonSend);
            this.group1.Location = new System.Drawing.Point(0, 0);
            this.group1.Margin = new System.Windows.Forms.Padding(0);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(150, 89);
            this.group1.TabIndex = 25;
            this.group1.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelNameTitle
            // 
            this.labelNameTitle.AutoSize = true;
            this.labelNameTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelNameTitle.Location = new System.Drawing.Point(3, 35);
            this.labelNameTitle.Name = "labelNameTitle";
            this.labelNameTitle.Size = new System.Drawing.Size(41, 13);
            this.labelNameTitle.TabIndex = 16;
            this.labelNameTitle.Text = "Name:";
            this.labelNameTitle.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Transparent;
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Image = global::PrinterGateXP.Properties.Resources.send;
            this.buttonSend.Location = new System.Drawing.Point(111, 26);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(35, 35);
            this.buttonSend.TabIndex = 28;
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // flowLayoutPanel_Root
            // 
            this.flowLayoutPanel_Root.AutoSize = true;
            this.flowLayoutPanel_Root.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_Root.Controls.Add(this.summaryPanel);
            this.flowLayoutPanel_Root.Controls.Add(this.detailPanel);
            this.flowLayoutPanel_Root.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Root.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_Root.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_Root.Name = "flowLayoutPanel_Root";
            this.flowLayoutPanel_Root.Size = new System.Drawing.Size(150, 211);
            this.flowLayoutPanel_Root.TabIndex = 26;
            // 
            // summaryPanel
            // 
            this.summaryPanel.Controls.Add(this.labelDateTimeTitle1);
            this.summaryPanel.Controls.Add(this.labelDateTime1);
            this.summaryPanel.Controls.Add(this.labelName1);
            this.summaryPanel.Location = new System.Drawing.Point(0, 0);
            this.summaryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(150, 35);
            this.summaryPanel.TabIndex = 27;
            this.summaryPanel.Click += new System.EventHandler(this.summaryPanel_Click);
            // 
            // labelDateTimeTitle1
            // 
            this.labelDateTimeTitle1.AutoSize = true;
            this.labelDateTimeTitle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelDateTimeTitle1.Location = new System.Drawing.Point(4, 4);
            this.labelDateTimeTitle1.Name = "labelDateTimeTitle1";
            this.labelDateTimeTitle1.Size = new System.Drawing.Size(64, 13);
            this.labelDateTimeTitle1.TabIndex = 18;
            this.labelDateTimeTitle1.Text = "Date/Time:";
            this.labelDateTimeTitle1.Click += new System.EventHandler(this.summaryPanel_Click);
            // 
            // labelDateTime1
            // 
            this.labelDateTime1.AutoSize = true;
            this.labelDateTime1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelDateTime1.Location = new System.Drawing.Point(68, 4);
            this.labelDateTime1.Name = "labelDateTime1";
            this.labelDateTime1.Size = new System.Drawing.Size(61, 13);
            this.labelDateTime1.TabIndex = 19;
            this.labelDateTime1.Text = "02.11.2022";
            this.labelDateTime1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDateTime1.Click += new System.EventHandler(this.summaryPanel_Click);
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelName1.Location = new System.Drawing.Point(4, 21);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(102, 13);
            this.labelName1.TabIndex = 20;
            this.labelName1.Text = "Christoph Wenger";
            this.labelName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName1.Click += new System.EventHandler(this.summaryPanel_Click);
            // 
            // detailPanel
            // 
            this.detailPanel.AutoSize = true;
            this.detailPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.detailPanel.Controls.Add(this.flowLayoutPart1);
            this.detailPanel.Controls.Add(this.flowLayoutPart2);
            this.detailPanel.Controls.Add(this.flowLayoutPart3);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.detailPanel.Location = new System.Drawing.Point(0, 35);
            this.detailPanel.Margin = new System.Windows.Forms.Padding(0);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(150, 176);
            this.detailPanel.TabIndex = 28;
            this.detailPanel.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // flowLayoutPart1
            // 
            this.flowLayoutPart1.AutoSize = true;
            this.flowLayoutPart1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPart1.Controls.Add(this.group1);
            this.flowLayoutPart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPart1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPart1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPart1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPart1.Name = "flowLayoutPart1";
            this.flowLayoutPart1.Size = new System.Drawing.Size(150, 89);
            this.flowLayoutPart1.TabIndex = 28;
            this.flowLayoutPart1.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // flowLayoutPart2
            // 
            this.flowLayoutPart2.AutoSize = true;
            this.flowLayoutPart2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPart2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPart2.Location = new System.Drawing.Point(2, 89);
            this.flowLayoutPart2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flowLayoutPart2.Name = "flowLayoutPart2";
            this.flowLayoutPart2.Size = new System.Drawing.Size(146, 0);
            this.flowLayoutPart2.TabIndex = 27;
            this.flowLayoutPart2.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // flowLayoutPart3
            // 
            this.flowLayoutPart3.AutoSize = true;
            this.flowLayoutPart3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPart3.Controls.Add(this.group3);
            this.flowLayoutPart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPart3.Location = new System.Drawing.Point(0, 89);
            this.flowLayoutPart3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPart3.Name = "flowLayoutPart3";
            this.flowLayoutPart3.Size = new System.Drawing.Size(150, 87);
            this.flowLayoutPart3.TabIndex = 26;
            this.flowLayoutPart3.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // group3
            // 
            this.group3.Controls.Add(this.buttonPrintAsBeauty);
            this.group3.Controls.Add(this.buttonPrintAsTicket);
            this.group3.Controls.Add(this.labelStatusTitle);
            this.group3.Controls.Add(this.labelStatus);
            this.group3.Controls.Add(this.labelPrintedTitle);
            this.group3.Controls.Add(this.labelPrinted);
            this.group3.Controls.Add(this.buttonConfirm);
            this.group3.Controls.Add(this.buttonReject);
            this.group3.Controls.Add(this.buttonStress);
            this.group3.Location = new System.Drawing.Point(0, 0);
            this.group3.Margin = new System.Windows.Forms.Padding(0);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(150, 87);
            this.group3.TabIndex = 26;
            this.group3.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // buttonPrintAsBeauty
            // 
            this.buttonPrintAsBeauty.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrintAsBeauty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrintAsBeauty.FlatAppearance.BorderSize = 0;
            this.buttonPrintAsBeauty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPrintAsBeauty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintAsBeauty.Image = global::PrinterGateXP.Properties.Resources.print1;
            this.buttonPrintAsBeauty.Location = new System.Drawing.Point(5, 50);
            this.buttonPrintAsBeauty.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrintAsBeauty.Name = "buttonPrintAsBeauty";
            this.buttonPrintAsBeauty.Size = new System.Drawing.Size(35, 35);
            this.buttonPrintAsBeauty.TabIndex = 29;
            this.buttonPrintAsBeauty.UseVisualStyleBackColor = false;
            this.buttonPrintAsBeauty.Click += new System.EventHandler(this.buttonPrintAsBeauty_click);
            // 
            // buttonPrintAsTicket
            // 
            this.buttonPrintAsTicket.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrintAsTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrintAsTicket.FlatAppearance.BorderSize = 0;
            this.buttonPrintAsTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPrintAsTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintAsTicket.Image = global::PrinterGateXP.Properties.Resources.print2;
            this.buttonPrintAsTicket.Location = new System.Drawing.Point(108, 51);
            this.buttonPrintAsTicket.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrintAsTicket.Name = "buttonPrintAsTicket";
            this.buttonPrintAsTicket.Size = new System.Drawing.Size(35, 35);
            this.buttonPrintAsTicket.TabIndex = 30;
            this.buttonPrintAsTicket.UseVisualStyleBackColor = false;
            this.buttonPrintAsTicket.Click += new System.EventHandler(this.buttonPrintAsTicket_click);
            // 
            // labelStatusTitle
            // 
            this.labelStatusTitle.AutoSize = true;
            this.labelStatusTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelStatusTitle.Location = new System.Drawing.Point(41, 39);
            this.labelStatusTitle.Name = "labelStatusTitle";
            this.labelStatusTitle.Size = new System.Drawing.Size(42, 13);
            this.labelStatusTitle.TabIndex = 13;
            this.labelStatusTitle.Text = "Status:";
            this.labelStatusTitle.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelStatus.Location = new System.Drawing.Point(83, 39);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(61, 13);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Confirmed";
            this.labelStatus.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelPrintedTitle
            // 
            this.labelPrintedTitle.AutoSize = true;
            this.labelPrintedTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelPrintedTitle.Location = new System.Drawing.Point(41, 57);
            this.labelPrintedTitle.Name = "labelPrintedTitle";
            this.labelPrintedTitle.Size = new System.Drawing.Size(48, 13);
            this.labelPrintedTitle.TabIndex = 5;
            this.labelPrintedTitle.Text = "Printed:";
            this.labelPrintedTitle.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // labelPrinted
            // 
            this.labelPrinted.AutoSize = true;
            this.labelPrinted.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelPrinted.Location = new System.Drawing.Point(87, 57);
            this.labelPrinted.Name = "labelPrinted";
            this.labelPrinted.Size = new System.Drawing.Size(23, 13);
            this.labelPrinted.TabIndex = 12;
            this.labelPrinted.Text = "yes";
            this.labelPrinted.Click += new System.EventHandler(this.detailPanel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Image = global::PrinterGateXP.Properties.Resources.confirm;
            this.buttonConfirm.Location = new System.Drawing.Point(5, 3);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(35, 35);
            this.buttonConfirm.TabIndex = 25;
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.Transparent;
            this.buttonReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReject.FlatAppearance.BorderSize = 0;
            this.buttonReject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReject.Image = global::PrinterGateXP.Properties.Resources.reject;
            this.buttonReject.Location = new System.Drawing.Point(58, 3);
            this.buttonReject.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(35, 35);
            this.buttonReject.TabIndex = 26;
            this.buttonReject.UseVisualStyleBackColor = false;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonStress
            // 
            this.buttonStress.BackColor = System.Drawing.Color.Transparent;
            this.buttonStress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStress.FlatAppearance.BorderSize = 0;
            this.buttonStress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonStress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStress.Image = global::PrinterGateXP.Properties.Resources.exclaim;
            this.buttonStress.Location = new System.Drawing.Point(109, 3);
            this.buttonStress.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStress.Name = "buttonStress";
            this.buttonStress.Size = new System.Drawing.Size(35, 35);
            this.buttonStress.TabIndex = 27;
            this.buttonStress.UseVisualStyleBackColor = false;
            this.buttonStress.Click += new System.EventHandler(this.buttonStress_Click);
            // 
            // TicketItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.flowLayoutPanel_Root);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TicketItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(150, 211);
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.flowLayoutPanel_Root.ResumeLayout(false);
            this.flowLayoutPanel_Root.PerformLayout();
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.flowLayoutPart1.ResumeLayout(false);
            this.flowLayoutPart3.ResumeLayout(false);
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEmailTitle;
        private System.Windows.Forms.Label labelPhoneTitle;
        private System.Windows.Forms.Label labelDateTimeTitle;
        private System.Windows.Forms.Label labelNoTitle;
        private System.Windows.Forms.Panel group1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Root;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label labelDateTimeTitle1;
        private System.Windows.Forms.Label labelDateTime1;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelNameTitle;
        private System.Windows.Forms.FlowLayoutPanel detailPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPart3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPart1;
        private System.Windows.Forms.Panel group3;
        private System.Windows.Forms.Label labelStatusTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPrintedTitle;
        private System.Windows.Forms.Label labelPrinted;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Button buttonStress;
        private System.Windows.Forms.Button buttonPrintAsBeauty;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPart2;
        private System.Windows.Forms.Button buttonPrintAsTicket;
    }
}
