using System;
using System.Collections.Generic;
using System.Text;

namespace SnapAlarm
{
	public class Alarm
	{
		private DateTime trigger;
		private string message;
		private Guid id = new Guid();

		public Guid Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Message
		{
			get { return message; }
			set { message = value; }
		}
		
		public DateTime Trigger
		{
			get { return trigger; }
			set { trigger = value; }
		}

		public Alarm()
		{
		}
	}
}
