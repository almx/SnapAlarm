using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnapAlarm
{
	public partial class AlarmNotice : Form
	{
		public AlarmNotice(Alarm alarm)
		{
			InitializeComponent();

			this.lblDateTime.Text = DateTime.Now.ToString("G");
			this.txtMessage.Text = alarm.Message;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}