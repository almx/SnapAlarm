namespace SnapAlarm
{
	partial class Form1
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
				this.notifyIcon1.Dispose();
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quickAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.minutesToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.hourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewAlarmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "SnapAlarm";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAlarmToolStripMenuItem,
            this.quickAlarmToolStripMenuItem,
            this.viewAlarmsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(147, 92);
			this.contextMenuStrip1.Text = "Test";
			// 
			// addAlarmToolStripMenuItem
			// 
			this.addAlarmToolStripMenuItem.Name = "addAlarmToolStripMenuItem";
			this.addAlarmToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.addAlarmToolStripMenuItem.Text = "Add Alarm...";
			this.addAlarmToolStripMenuItem.Click += new System.EventHandler(this.addAlarmToolStripMenuItem_Click);
			// 
			// quickAlarmToolStripMenuItem
			// 
			this.quickAlarmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minutesToolStripMenuItem,
            this.minutesToolStripMenuItem1,
            this.minutesToolStripMenuItem2,
            this.minutesToolStripMenuItem3,
            this.minutesToolStripMenuItem4,
            this.minutesToolStripMenuItem5,
            this.hourToolStripMenuItem});
			this.quickAlarmToolStripMenuItem.Name = "quickAlarmToolStripMenuItem";
			this.quickAlarmToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.quickAlarmToolStripMenuItem.Text = "Quick Alarm";
			// 
			// minutesToolStripMenuItem
			// 
			this.minutesToolStripMenuItem.Name = "minutesToolStripMenuItem";
			this.minutesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.minutesToolStripMenuItem.Text = "5 Minutes";
			this.minutesToolStripMenuItem.Click += new System.EventHandler(this.minutesToolStripMenuItem_Click);
			// 
			// minutesToolStripMenuItem1
			// 
			this.minutesToolStripMenuItem1.Name = "minutesToolStripMenuItem1";
			this.minutesToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
			this.minutesToolStripMenuItem1.Text = "10 Minutes";
			this.minutesToolStripMenuItem1.Click += new System.EventHandler(this.minutesToolStripMenuItem1_Click);
			// 
			// minutesToolStripMenuItem2
			// 
			this.minutesToolStripMenuItem2.Name = "minutesToolStripMenuItem2";
			this.minutesToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
			this.minutesToolStripMenuItem2.Text = "15 Minutes";
			this.minutesToolStripMenuItem2.Click += new System.EventHandler(this.minutesToolStripMenuItem2_Click);
			// 
			// minutesToolStripMenuItem3
			// 
			this.minutesToolStripMenuItem3.Name = "minutesToolStripMenuItem3";
			this.minutesToolStripMenuItem3.Size = new System.Drawing.Size(137, 22);
			this.minutesToolStripMenuItem3.Text = "20 Minutes";
			this.minutesToolStripMenuItem3.Click += new System.EventHandler(this.minutesToolStripMenuItem3_Click);
			// 
			// minutesToolStripMenuItem4
			// 
			this.minutesToolStripMenuItem4.Name = "minutesToolStripMenuItem4";
			this.minutesToolStripMenuItem4.Size = new System.Drawing.Size(137, 22);
			this.minutesToolStripMenuItem4.Text = "30 Minutes";
			this.minutesToolStripMenuItem4.Click += new System.EventHandler(this.minutesToolStripMenuItem4_Click);
			// 
			// minutesToolStripMenuItem5
			// 
			this.minutesToolStripMenuItem5.Name = "minutesToolStripMenuItem5";
			this.minutesToolStripMenuItem5.Size = new System.Drawing.Size(137, 22);
			this.minutesToolStripMenuItem5.Text = "45 Minutes";
			this.minutesToolStripMenuItem5.Click += new System.EventHandler(this.minutesToolStripMenuItem5_Click);
			// 
			// hourToolStripMenuItem
			// 
			this.hourToolStripMenuItem.Name = "hourToolStripMenuItem";
			this.hourToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.hourToolStripMenuItem.Text = "1 Hour";
			this.hourToolStripMenuItem.Click += new System.EventHandler(this.hourToolStripMenuItem_Click);
			// 
			// viewAlarmsToolStripMenuItem
			// 
			this.viewAlarmsToolStripMenuItem.Name = "viewAlarmsToolStripMenuItem";
			this.viewAlarmsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.viewAlarmsToolStripMenuItem.Text = "View Alarms";
			this.viewAlarmsToolStripMenuItem.Click += new System.EventHandler(this.viewAlarmsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(146, 29);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Opacity = 0;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Form1";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addAlarmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quickAlarmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem viewAlarmsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem hourToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
	}
}

