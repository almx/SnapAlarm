using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnapAlarm
{
	public partial class EditAlarm : Form
	{
		private Alarm alarm;
		private RefreshAlarmList ral;

		public EditAlarm(RefreshAlarmList ral)
		{
			InitializeComponent();
			this.Text = "Add Alarm";
			this.dtpTime.Value = DateTime.Now.Subtract(new TimeSpan(0, 0, DateTime.Now.Second));
			this.ral = ral;

			this.Focus();
		}

		public EditAlarm(Alarm alarm, RefreshAlarmList ral)
		{
			InitializeComponent();
			this.Text = "Edit Alarm";
			this.alarm = alarm;
			this.ral = ral;

			this.PopulateForm();
		}

		private void PopulateForm()
		{
			this.dtpTime.Value = this.alarm.Trigger;
			this.dtpDate.Value = this.alarm.Trigger;
			this.txtMessage.Text = this.alarm.Message;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (DateIsInPast())
				MessageBox.Show("Selected date/time is in the past", "SnapAlarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				if (this.alarm == null)
				{
					this.alarm = new Alarm();
					this.alarm.Trigger = this.GetDateTime();
					this.alarm.Message = txtMessage.Text;
				}
				else
				{
					this.alarm.Trigger = this.GetDateTime();
					this.alarm.Message = txtMessage.Text;
				}

				AlarmCache.Instance.Save(this.alarm);

				this.ral();
				this.Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private DateTime GetDateTime()
		{
			return new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day,
				dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);
		}

		private bool DateIsInPast()
		{
			return (this.GetDateTime().CompareTo(DateTime.Now) <= 0);
		}
	}
}