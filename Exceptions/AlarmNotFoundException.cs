using System;
using System.Collections.Generic;
using System.Text;

namespace SnapAlarm.Exceptions
{
	class AlarmNotFoundException : Exception
	{
		private string message;

		public string Message
		{
			get { return message; }
			set { message = value; }
		}

		private Guid id;

		public Guid Id
		{
			get { return id; }
			set { id = value; }
		}


		public AlarmNotFoundException(string message, Guid id)
		{
			this.message = message;
			this.id = id;
		}
	}
}
