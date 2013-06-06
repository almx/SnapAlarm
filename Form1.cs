using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnapAlarm
{
	public partial class Form1 : Form
	{
		ViewAlarms va = new ViewAlarms();

		public Form1()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void addAlarmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new EditAlarm(this.va.RefreshList).Show();
		}

		private void viewAlarmsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.va.IsDisposed)
				this.va = new ViewAlarms();

			this.va.Show();
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.addAlarmToolStripMenuItem_Click(sender, e);
		}

		#region QuickAlarm Events
		private void minutesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.AddQuickAlarm(5);
		}

		private void minutesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.AddQuickAlarm(10);
		}

		private void minutesToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.AddQuickAlarm(15);
		}

		private void minutesToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			this.AddQuickAlarm(20);
		}

		private void minutesToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.AddQuickAlarm(30);
		}

		private void minutesToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			this.AddQuickAlarm(45);
		}

		private void hourToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.AddQuickAlarm(60);
		}
		#endregion

		private void AddQuickAlarm(int minutes)
		{
			Alarm alarm = new Alarm();
			alarm.Trigger = DateTime.Now.AddMinutes(minutes);
			alarm.Message = minutes.ToString() + "-minute reminder (set on " +
				DateTime.Now.ToString("G") + ")";

			AlarmCache.Instance.Save(alarm);

			this.RefreshAlarmList();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			List<Alarm> alDelete = new List<Alarm>();

			foreach (Alarm alarm in AlarmCache.Instance.Alarms)
			{
				if (alarm.Trigger < DateTime.Now)
				{
					new AlarmNotice(alarm).Show();

					alDelete.Add(alarm);
				}
			}

			if (alDelete.Count >= 1)
			{
				foreach (Alarm alarm in alDelete)
				{
					AlarmCache.Instance.Delete(alarm.Id);
				}

				this.RefreshAlarmList();
			}
		}

		private void RefreshAlarmList()
		{
			if (!this.va.IsDisposed)
				this.va.RefreshList();
		}

	}
}