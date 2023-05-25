using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PrinterGateXP
{
	public partial class AddPrinterForm : Form
	{
		public AddPrinterForm(string categoryName = "", List<string> categories = null)
		{
			this.InitializeComponent();
			this.categories = ((categories == null) ? new List<string>() : categories);
			this.categoryName = categoryName;
			List<TKMenu> tkMenus = Gate.Instance.tkMenus;
			List<TKMenu> list = AppConfig.appConfig.FindRemainingMenus();
			if (categories != null)
			{
				this.Text = "Update a Printer";
				this.buttonAdd.Text = "Update";
				this.textBoxCategoryName.Text = categoryName;
				this.bUpdateMode = true;
			}
			else
			{
				this.textBoxCategoryName.Text = Localization.Translation("name_product_group");
			}
			using (List<string>.Enumerator enumerator = this.categories.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string id = enumerator.Current;
					TKMenu tkmenu = tkMenus.Find((TKMenu t) => t.id == id);
					this.listBoxSelectedMenus.Items.Add(tkmenu);
				}
			}
			foreach (TKMenu tkmenu2 in list)
			{
				this.listBoxRemainingMenus.Items.Add(tkmenu2);
			}
			this.buttonMoveRight.Enabled = this.buttonMoveLeft.Enabled = false;
			this.Localize();
		}

		public void Localize()
		{
			this.Text = Localization.Translation("add_printer");
			this.labelPrinterName.Text = Localization.Translation("name_your_printer");
			this.labelSelectFoods.Text = Localization.Translation("select_menus");
			this.labelSelectedMenus.Text = Localization.Translation("selected_menus");
			this.labelRemainingMenus.Text = Localization.Translation("remaining_menus");
			this.buttonAdd.Text = Localization.Translation("add");
			this.buttonCancel.Text = Localization.Translation("cancel");
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.categoryName = this.textBoxCategoryName.Text;
			if (this.categoryName == "")
			{
				MessageBox.Show(Localization.Translation("category_name_should_not_be_empty"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (this.listBoxSelectedMenus.Items.Count == 0)
			{
				MessageBox.Show(Localization.Translation("add_1_menu"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (!this.bUpdateMode && AppConfig.appConfig.FindPrinter(this.categoryName) != null)
			{
				MessageBox.Show(Localization.Translation("category_printer_exists"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			this.categories.Clear();
			foreach (object obj in this.listBoxSelectedMenus.Items)
			{
				TKMenu tkmenu = (TKMenu)obj;
				this.categories.Add(tkmenu.id);
			}
			base.Close();
			base.DialogResult = DialogResult.OK;
		}

		private void addSelectedItem()
		{
			if (this.listBoxRemainingMenus.SelectedItem == null) return;
			this.listBoxSelectedMenus.Items.Add(this.listBoxRemainingMenus.SelectedItem);
			this.listBoxRemainingMenus.Items.RemoveAt(this.listBoxRemainingMenus.SelectedIndex);
		}

		private void removeSelectedItem()
		{
			if (this.listBoxSelectedMenus.SelectedItem == null) return;
			this.listBoxRemainingMenus.Items.Add(this.listBoxSelectedMenus.SelectedItem);
			this.listBoxSelectedMenus.Items.RemoveAt(this.listBoxSelectedMenus.SelectedIndex);
		}

		private void buttonMoveLeft_Click(object sender, EventArgs e)
		{
			this.removeSelectedItem();
			
		}

		private void buttonMoveRight_Click(object sender, EventArgs e)
		{
			this.addSelectedItem();
		}

		private void listBoxRemainingMenus_SelectedIndexChanged(object sender, EventArgs e)
		{
			//this.buttonMoveLeft.Enabled = (this.listBoxRemainingMenus.SelectedIndex != -1);
			this.buttonMoveRight.Enabled = (this.listBoxRemainingMenus.SelectedIndex != -1);
		}

		private void listBoxSelectedMenus_SelectedIndexChanged(object sender, EventArgs e)
		{
			//this.buttonMoveRight.Enabled = (this.listBoxSelectedMenus.SelectedIndex != -1);
			this.buttonMoveLeft.Enabled = (this.listBoxSelectedMenus.SelectedIndex != -1);
		}

		private void listBoxRemainingMenus_DoubleClick(object sender, EventArgs e)
		{
			if (this.listBoxRemainingMenus.SelectedIndex != -1)
			{
				this.addSelectedItem();
			}
		}

		private void listBoxSelectedMenus_DoubleClick(object sender, EventArgs e)
		{
			if (this.listBoxSelectedMenus.SelectedIndex != -1)
			{
				this.removeSelectedItem();
			}
		}

		public string categoryName;

		public List<string> categories;

		private bool bUpdateMode;
	}
}
