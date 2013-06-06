using System;
using System.Collections.Generic;
using System.Text;

namespace SnapAlarm
{
	public class AlarmCache
	{
		private List<Alarm> alarms;
		private static AlarmCache instance = null;

		public static AlarmCache Instance
		{
			get
			{
				if(AlarmCache.instance == null)
					AlarmCache.instance = new AlarmCache();
				
				return AlarmCache.instance;
			}
		}

		private AlarmCache()
		{
			this.alarms = new AlarmStorage().Alarms;
		}

		public List<Alarm> Alarms
		{
			get { return alarms; }
		}
		
		public Alarm Save(Alarm alarm)
		{
			Guid id = new AlarmStorage().Save(alarm);
			Alarm newAlarm;

			if (this.GetAlarm(id) == null)
			{
				newAlarm = new Alarm();
				newAlarm.Id = id;
				newAlarm.Message = alarm.Message;
				newAlarm.Trigger = alarm.Trigger;

				this.alarms.Add(newAlarm);
			}
			else
			{
				newAlarm = this.GetAlarm(id);
				newAlarm.Message = alarm.Message;
				newAlarm.Trigger = alarm.Trigger;
			}

			return newAlarm;
		}

		public void Delete(Guid id)
		{
			new AlarmStorage().Delete(id);

			Alarm alarmDelte = this.GetAlarm(id);

			this.alarms.Remove(alarmDelte);
		}

		private Alarm GetAlarm(Guid id)
		{
			foreach (Alarm alarm in this.Alarms)
			{
				if (alarm.Id.CompareTo(id.ToString()) == 0)
					return alarm;
			}

			return null;
		}
	}
}
