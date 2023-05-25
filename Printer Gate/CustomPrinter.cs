using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PrinterGateXP
{
	public class CustomPrinter : UserControl
	{
		public event EventHandler PrinterChanged;

		public string CategoryName
		{
			get
			{
				return this._categoryName;
			}
			set
			{
				this._categoryName = value;
				this.labelName.Text = this._categoryName;
			}
		}

		public string PrinterName
		{
			get
			{
				return this._printerName;
			}
			set
			{
				this._printerName = value;
				this.textBoxPrinterName.Text = this._printerName;
				this.labelStatus.BackColor = ((this._printerName != "") ? AppColor.GREEN : AppColor.DANGER);
			}
		}

		public CustomPrinter(string categoryName = "", string printerName = "", int printerIndex = 999)
		{
			this.InitializeComponent();
			this.Dock = DockStyle.Fill;
			this.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			base.Margin = new Padding(0, 0, 0, 0);
			this.CategoryName = categoryName;
			this.PrinterName = printerName;
			this.buttonEditPrinter.Visible = (printerIndex > 1);
			this._printerIndex = printerIndex;
		}

		public void Localize()
		{
			if (this._printerIndex == 0)
			{
				this.labelName.Text = Localization.Translation("table");
				//this.CategoryName = Localization.Translation("table");
			}
			if (this._printerIndex == 1)
			{
				this.labelName.Text = Localization.Translation("beautiful");
				//this.CategoryName = Localization.Translation("beautiful");
			}
		}

		private void buttonChangePrinter_Click(object sender, EventArgs e)
		{
			PrintDialog printDialog = new PrintDialog();
			printDialog.UseEXDialog = true;
			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				this.PrinterName = printDialog.PrinterSettings.PrinterName;
				GatePrinter gatePrinter = AppConfig.appConfig.FindPrinter(this.CategoryName);
#if DEBUG
				if (gatePrinter == null)
				{
					MessageBox.Show("no found printer: " + this.CategoryName);
					return;
				}
				else
					MessageBox.Show("printer found: " + this.CategoryName);
#endif
				AppConfig.appConfig.FindPrinter(this.CategoryName).printerName = this.PrinterName;
				AppConfig.SavePrinterConfig();
				EventHandler printerChanged = this.PrinterChanged;
				if (printerChanged == null)
				{
					return;
				}
				printerChanged(this, e);
			}
		}

		private void buttonEditPrinter_Click(object sender, EventArgs e)
		{
			GatePrinter gatePrinter = AppConfig.appConfig.FindPrinter(this.CategoryName);
#if DEBUG
			if (gatePrinter == null)
			{
				MessageBox.Show("no found printer: " + this.CategoryName);
				return;
			}
			else
				MessageBox.Show("printer found: " + this.CategoryName);
#endif
			if(Gate.Instance.tkMenus.Count == 0)
            {
				MessageBox.Show(Localization.Translation("api_not_installed"));
				return;
			}
			AddPrinterForm addPrinterForm = new AddPrinterForm(gatePrinter.categoryName, gatePrinter.tkMenuIds);
			if (addPrinterForm.ShowDialog() == DialogResult.OK)
			{
				gatePrinter.categoryName = addPrinterForm.categoryName;
				gatePrinter.tkMenuIds = addPrinterForm.categories;
				this.labelName.Text = gatePrinter.categoryName;
				this.CategoryName = gatePrinter.categoryName;
				AppConfig.SavePrinterConfig();
				EventHandler printerChanged = this.PrinterChanged;
				if (printerChanged == null)
				{
					return;
				}
				printerChanged(this, e);
			}
		}

		private void labelStatus_Click(object sender, EventArgs e)
		{
			GatePrinter gatePrinter = AppConfig.appConfig.FindPrinter(this.CategoryName);
#if DEBUG
			if (gatePrinter == null)
			{
				MessageBox.Show("no found printer: " + this.CategoryName);
				return;
			}
			else
				MessageBox.Show("printer found: " + this.CategoryName);
#endif
			AppConfig.appConfig.FindPrinter(this.CategoryName).printerName = "";
			this.PrinterName = "";
			AppConfig.SavePrinterConfig();
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
			this.tableLayoutMain = new TableLayoutPanel();
			this.labelName = new Label();
			this.labelStatus = new Label();
			this.textBoxPrinterName = new TextBox();
			this.buttonChangePrinter = new Button();
			this.buttonEditPrinter = new Button();
			this.tableLayoutMain.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.tableLayoutMain.ColumnCount = 5;
			this.tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150f));
			this.tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30f));
			this.tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30f));
			this.tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30f));
			this.tableLayoutMain.Controls.Add(this.labelName, 0, 0);
			this.tableLayoutMain.Controls.Add(this.labelStatus, 1, 0);
			this.tableLayoutMain.Controls.Add(this.textBoxPrinterName, 2, 0);
			this.tableLayoutMain.Controls.Add(this.buttonChangePrinter, 3, 0);
			this.tableLayoutMain.Controls.Add(this.buttonEditPrinter, 4, 0);
			this.tableLayoutMain.Dock = DockStyle.Fill;
			this.tableLayoutMain.Location = new Point(0, 0);
			this.tableLayoutMain.Margin = new Padding(0);
			this.tableLayoutMain.Name = "tableLayoutMain";
			this.tableLayoutMain.RowCount = 1;
			this.tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutMain.Size = new Size(359, 30);
			this.tableLayoutMain.TabIndex = 0;
			this.labelName.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.labelName.AutoSize = true;
			this.labelName.Location = new Point(0, 0);
			this.labelName.Margin = new Padding(0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new Size(81, 30);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Take Away";
			this.labelName.TextAlign = ContentAlignment.MiddleLeft;
			this.labelStatus.Anchor = AnchorStyles.None;
			this.labelStatus.BackColor = Color.Red;
			this.labelStatus.Cursor = Cursors.Hand;
			this.labelStatus.Location = new Point(152, 2);
			this.labelStatus.Margin = new Padding(0);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new Size(25, 25);
			this.labelStatus.TabIndex = 1;
			this.labelStatus.Click += this.labelStatus_Click;
			this.textBoxPrinterName.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
			this.textBoxPrinterName.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.textBoxPrinterName.Location = new Point(180, 3);
			this.textBoxPrinterName.Margin = new Padding(0);
			this.textBoxPrinterName.Name = "textBoxPrinterName";
			this.textBoxPrinterName.ReadOnly = true;
			this.textBoxPrinterName.Size = new Size(119, 23);
			this.textBoxPrinterName.TabIndex = 2;
			this.buttonChangePrinter.Anchor = AnchorStyles.None;
			this.buttonChangePrinter.Location = new Point(301, 2);
			this.buttonChangePrinter.Margin = new Padding(0);
			this.buttonChangePrinter.Name = "buttonChangePrinter";
			this.buttonChangePrinter.Size = new Size(25, 25);
			this.buttonChangePrinter.TabIndex = 3;
			this.buttonChangePrinter.Text = "P";
			this.buttonChangePrinter.UseVisualStyleBackColor = true;
			this.buttonChangePrinter.Click += this.buttonChangePrinter_Click;
			this.buttonEditPrinter.Anchor = AnchorStyles.None;
			this.buttonEditPrinter.Location = new Point(331, 2);
			this.buttonEditPrinter.Margin = new Padding(0);
			this.buttonEditPrinter.Name = "buttonEditPrinter";
			this.buttonEditPrinter.Size = new Size(25, 25);
			this.buttonEditPrinter.TabIndex = 3;
			this.buttonEditPrinter.Text = "E";
			this.buttonEditPrinter.UseVisualStyleBackColor = true;
			this.buttonEditPrinter.Click += this.buttonEditPrinter_Click;
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutMain);
			this.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold);
			base.Margin = new Padding(0, 4, 0, 4);
			base.Name = "CustomPrinter";
			base.Size = new Size(359, 30);
			this.tableLayoutMain.ResumeLayout(false);
			this.tableLayoutMain.PerformLayout();
			base.ResumeLayout(false);
		}

		private string _categoryName;

		private string _printerName;

		private int _printerIndex;

		private IContainer components;

		private TableLayoutPanel tableLayoutMain;

		private Label labelName;

		private Label labelStatus;

		private TextBox textBoxPrinterName;

		private Button buttonChangePrinter;

		private Button buttonEditPrinter;
	}
}
