using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SnapAlarm
{
	public delegate void RefreshAlarmList();

	public class Utility
	{
		public static string StorageFile
		{
			get
			{
				string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
#if DEBUG
				path = @"..\..\";
#endif
				return path + @"\SnapAlarm.Alarms.xml";			
			}
		}
	}
}
