namespace SnapAlarm
{
	partial class ViewAlarms
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAlarms));
			this.btnClose = new System.Windows.Forms.Button();
			this.listAlarms = new System.Windows.Forms.ListView();
			this.colTrigger = new System.Windows.Forms.ColumnHeader();
			this.colMessage = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(412, 220);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// listAlarms
			// 
			this.listAlarms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTrigger,
            this.colMessage});
			this.listAlarms.FullRowSelect = true;
			this.listAlarms.GridLines = true;
			this.listAlarms.Location = new System.Drawing.Point(12, 12);
			this.listAlarms.MultiSelect = false;
			this.listAlarms.Name = "listAlarms";
			this.listAlarms.Size = new System.Drawing.Size(472, 200);
			this.listAlarms.TabIndex = 2;
			this.listAlarms.UseCompatibleStateImageBehavior = false;
			this.listAlarms.View = System.Windows.Forms.View.Details;
			this.listAlarms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listAlarms_MouseDoubleClick);
			this.listAlarms.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listAlarms_KeyUp);
			// 
			// colTrigger
			// 
			this.colTrigger.Text = "Trigger";
			this.colTrigger.Width = 150;
			// 
			// colMessage
			// 
			this.colMessage.Text = "Message";
			this.colMessage.Width = 300;
			// 
			// ViewAlarms
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(495, 250);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.listAlarms);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ViewAlarms";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Alarms";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ListView listAlarms;
		private System.Windows.Forms.ColumnHeader colTrigger;
		private System.Windows.Forms.ColumnHeader colMessage;
	}
}