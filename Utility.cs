using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SnapAlarm
{
	public delegate void RefreshAlarmList();

	public class Utility
	{
		public static string StorageFile
		{
			get
			{
				return Path.Combine(Application.StartupPath, "SnapAlarm.Alarms.xml");
			}
		}
	}
}
