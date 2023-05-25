namespace PrinterGateXP
{
	public partial class PromptForm : global::System.Windows.Forms.Form
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
			this.labelPromptQuestion = new global::System.Windows.Forms.Label();
			this.textBoxInput = new global::System.Windows.Forms.TextBox();
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.labelPromptQuestion.AutoSize = true;
			this.labelPromptQuestion.Location = new global::System.Drawing.Point(15, 12);
			this.labelPromptQuestion.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPromptQuestion.Name = "labelPromptQuestion";
			this.labelPromptQuestion.Size = new global::System.Drawing.Size(143, 20);
			this.labelPromptQuestion.TabIndex = 0;
			this.labelPromptQuestion.Text = "<prompt question>";
			this.textBoxInput.Location = new global::System.Drawing.Point(15, 46);
			this.textBoxInput.Multiline = true;
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new global::System.Drawing.Size(460, 59);
			this.textBoxInput.TabIndex = 1;
			this.buttonOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new global::System.Drawing.Point(319, 122);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(75, 32);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new global::System.EventHandler(this.buttonOk_Click);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(400, 122);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 32);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			base.AcceptButton = this.buttonOk;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(234, 232, 243);
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(487, 166);
			base.ControlBox = false;
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.textBoxInput);
			base.Controls.Add(this.labelPromptQuestion);
			this.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11.25f, global::System.Drawing.FontStyle.Bold);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PromptForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PromptForm";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Label labelPromptQuestion;

		private global::System.Windows.Forms.TextBox textBoxInput;

		private global::System.Windows.Forms.Button buttonOk;

		private global::System.Windows.Forms.Button buttonCancel;
	}
}
