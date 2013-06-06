using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace SnapAlarm
{
	public class DateTimeComparer : IComparer
	{
		public int Compare(object x, object y)
		{
			DateTime dt1 = Convert.ToDateTime(((ListViewItem)x).SubItems[0].Text);
			DateTime dt2 = Convert.ToDateTime(((ListViewItem)y).SubItems[0].Text);

			return dt1.CompareTo(dt2);
		}
	}
}
