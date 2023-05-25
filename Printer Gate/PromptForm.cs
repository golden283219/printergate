using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PrinterGateXP
{
	// Token: 0x02000025 RID: 37
	public partial class PromptForm : Form
	{
		// Token: 0x060000AB RID: 171 RVA: 0x000098B1 File Offset: 0x00007AB1
		public PromptForm(string prompt = "", string caption = "", string defaultValue = "")
		{
			this.InitializeComponent();
			this.labelPromptQuestion.Text = prompt;
			this.Text = caption;
			this.textBoxInput.Text = defaultValue;
			this.Localize();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000098E4 File Offset: 0x00007AE4
		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.result = this.textBoxInput.Text;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000098F7 File Offset: 0x00007AF7
		public void Localize()
		{
			this.buttonCancel.Text = Localization.Translation("cancel");
		}

		// Token: 0x0400014F RID: 335
		public string result;
	}
}
