using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnapAlarm
{
	public partial class ViewAlarms : Form
	{
		public ViewAlarms()
		{
			InitializeComponent();

			this.RefreshList();
		}

		public void RefreshList()
		{
			listAlarms.Items.Clear();
			listAlarms.BeginUpdate();

			foreach (Alarm alarm in AlarmCache.Instance.Alarms)
			{
				listAlarms.Items.Add(new ListViewItem(new string[] {
					alarm.Trigger.ToString("G"), alarm.Message, alarm.Id.ToString() }));
			}

			listAlarms.EndUpdate();
			
			listAlarms.Sorting = SortOrder.Ascending;
			listAlarms.ListViewItemSorter = new DateTimeComparer();
			listAlarms.Sort();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void listAlarms_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left || e.Button == MouseButtons.Middle)
				return;

			if (listAlarms.SelectedItems.Count != 1)
				return;

			ListViewItem sel = listAlarms.SelectedItems[0];

			if (sel != null)
			{
				Alarm alarm = new Alarm();
				alarm.Id = new Guid(sel.SubItems[2].Text);
				alarm.Trigger = DateTime.Parse(sel.SubItems[0].Text);
				alarm.Message = sel.SubItems[1].Text;

				new EditAlarm(alarm, this.RefreshList).Show();
			}
		}

		private void listAlarms_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && listAlarms.SelectedItems.Count == 1)
			{
				ListViewItem sel = listAlarms.SelectedItems[0];
				int selIndex = sel.Index;

				AlarmCache.Instance.Delete(new Guid(sel.SubItems[2].Text));
				this.RefreshList();

				if (listAlarms.Items.Count >= 1)
				{
					if (selIndex >= listAlarms.Items.Count)
						selIndex = listAlarms.Items.Count - 1;

					listAlarms.Items[selIndex].Selected = true;
				}

			}
		}
	}
}