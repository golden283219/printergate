namespace PrinterGateXP
{
	
	public partial class AddPrinterForm : global::System.Windows.Forms.Form
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
            this.labelPrinterName = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelSelectFoods = new System.Windows.Forms.Label();
            this.listBoxSelectedMenus = new System.Windows.Forms.ListBox();
            this.labelSelectedMenus = new System.Windows.Forms.Label();
            this.listBoxRemainingMenus = new System.Windows.Forms.ListBox();
            this.labelRemainingMenus = new System.Windows.Forms.Label();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrinterName
            // 
            this.labelPrinterName.AutoSize = true;
            this.labelPrinterName.Location = new System.Drawing.Point(15, 14);
            this.labelPrinterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrinterName.Name = "labelPrinterName";
            this.labelPrinterName.Size = new System.Drawing.Size(140, 20);
            this.labelPrinterName.TabIndex = 0;
            this.labelPrinterName.Text = "Name your &printer.";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(15, 46);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(460, 27);
            this.textBoxCategoryName.TabIndex = 1;
            this.textBoxCategoryName.Text = "Put your category. (e.g. Pasta)";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(319, 309);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 32);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(400, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 32);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelSelectFoods
            // 
            this.labelSelectFoods.AutoSize = true;
            this.labelSelectFoods.Location = new System.Drawing.Point(15, 87);
            this.labelSelectFoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectFoods.Name = "labelSelectFoods";
            this.labelSelectFoods.Size = new System.Drawing.Size(304, 20);
            this.labelSelectFoods.TabIndex = 0;
            this.labelSelectFoods.Text = "Select your menus to print with this printer.";
            // 
            // listBoxSelectedMenus
            // 
            this.listBoxSelectedMenus.FormattingEnabled = true;
            this.listBoxSelectedMenus.ItemHeight = 20;
            this.listBoxSelectedMenus.Location = new System.Drawing.Point(286, 156);
            this.listBoxSelectedMenus.Name = "listBoxSelectedMenus";
            this.listBoxSelectedMenus.Size = new System.Drawing.Size(189, 124);
            this.listBoxSelectedMenus.TabIndex = 5;
            this.listBoxSelectedMenus.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedMenus_SelectedIndexChanged);
            this.listBoxSelectedMenus.DoubleClick += new System.EventHandler(this.listBoxSelectedMenus_DoubleClick);
            // 
            // labelSelectedMenus
            // 
            this.labelSelectedMenus.AutoSize = true;
            this.labelSelectedMenus.Location = new System.Drawing.Point(286, 133);
            this.labelSelectedMenus.Name = "labelSelectedMenus";
            this.labelSelectedMenus.Size = new System.Drawing.Size(116, 20);
            this.labelSelectedMenus.TabIndex = 6;
            this.labelSelectedMenus.Text = "Selected Menus";
            // 
            // listBoxRemainingMenus
            // 
            this.listBoxRemainingMenus.FormattingEnabled = true;
            this.listBoxRemainingMenus.ItemHeight = 20;
            this.listBoxRemainingMenus.Location = new System.Drawing.Point(12, 156);
            this.listBoxRemainingMenus.Name = "listBoxRemainingMenus";
            this.listBoxRemainingMenus.Size = new System.Drawing.Size(189, 124);
            this.listBoxRemainingMenus.TabIndex = 7;
            this.listBoxRemainingMenus.SelectedIndexChanged += new System.EventHandler(this.listBoxRemainingMenus_SelectedIndexChanged);
            this.listBoxRemainingMenus.DoubleClick += new System.EventHandler(this.listBoxRemainingMenus_DoubleClick);
            // 
            // labelRemainingMenus
            // 
            this.labelRemainingMenus.AutoSize = true;
            this.labelRemainingMenus.Location = new System.Drawing.Point(8, 133);
            this.labelRemainingMenus.Name = "labelRemainingMenus";
            this.labelRemainingMenus.Size = new System.Drawing.Size(132, 20);
            this.labelRemainingMenus.TabIndex = 6;
            this.labelRemainingMenus.Text = "Remaining Menus";
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Location = new System.Drawing.Point(216, 234);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(47, 32);
            this.buttonMoveLeft.TabIndex = 8;
            this.buttonMoveLeft.Text = "<<";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Location = new System.Drawing.Point(216, 175);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(47, 32);
            this.buttonMoveRight.TabIndex = 8;
            this.buttonMoveRight.Text = ">>";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // AddPrinterForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(243)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(487, 353);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.listBoxRemainingMenus);
            this.Controls.Add(this.labelRemainingMenus);
            this.Controls.Add(this.labelSelectedMenus);
            this.Controls.Add(this.listBoxSelectedMenus);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.labelSelectFoods);
            this.Controls.Add(this.labelPrinterName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPrinterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Printer";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		
		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Label labelPrinterName;

		private global::System.Windows.Forms.TextBox textBoxCategoryName;

		private global::System.Windows.Forms.Button buttonAdd;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.Label labelSelectFoods;

		private global::System.Windows.Forms.ListBox listBoxSelectedMenus;

		private global::System.Windows.Forms.Label labelSelectedMenus;

		private global::System.Windows.Forms.ListBox listBoxRemainingMenus;

		private global::System.Windows.Forms.Label labelRemainingMenus;

		private global::System.Windows.Forms.Button buttonMoveLeft;

		private global::System.Windows.Forms.Button buttonMoveRight;
	}
}
