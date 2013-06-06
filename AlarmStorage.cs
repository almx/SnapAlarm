using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using SnapAlarm.Exceptions;
using System.IO;

namespace SnapAlarm
{
	public class AlarmStorage
	{
		private XmlDocument xd;

		public AlarmStorage()
		{
			this.xd = new XmlDocument();

			this.InitializeStorageFile();
		}

		private void InitializeStorageFile()
		{
			if (!File.Exists(Utility.StorageFile))
			{
				XmlDocument xd = new XmlDocument();
				xd.CreateXmlDeclaration("1.0", "utf-8", null);
				xd.AppendChild(xd.CreateElement("SnapAlarm"));
				xd.Save(Utility.StorageFile);
			}

			this.xd.Load(Utility.StorageFile);
		}

		public Guid Save(Alarm alarm)
		{
			Guid retGuid = new Guid();

			if (!this.AlarmExists(alarm.Id))
			{
				retGuid = Guid.NewGuid();

				XmlElement xe = (XmlElement)this.xd.DocumentElement.AppendChild(this.xd.CreateElement("Alarm"));
				xe.SetAttribute("id", retGuid.ToString());
				xe.AppendChild(this.xd.CreateElement("Message")).InnerText = alarm.Message;
				xe.AppendChild(this.xd.CreateElement("Trigger")).InnerText = alarm.Trigger.ToString("G");
			}
			else
			{
				retGuid = alarm.Id;

				XmlElement xe = (XmlElement)this.xd.SelectSingleNode("//SnapAlarm/Alarm[@id='" + alarm.Id.ToString() + "']");
				xe.SelectSingleNode("Message").InnerText = alarm.Message;
				xe.SelectSingleNode("Trigger").InnerText = alarm.Trigger.ToString("G");
			}

			this.xd.Save(Utility.StorageFile);

			return retGuid;
		}

		public Alarm Fetch(Guid id)
		{
			XmlElement xe = (XmlElement)this.xd.SelectSingleNode(String.Format("/SnapAlarm/Alarm[@id='{0}']", id));

			if (xe == null)
				return null;
			else
			{
				Alarm alarm = new Alarm();
				alarm.Id = id;
				alarm.Message = xe.SelectSingleNode("Message").InnerText;
				alarm.Trigger = DateTime.Parse(xe.SelectSingleNode("Trigger").InnerText);

				return alarm;
			}
		}

		public List<Alarm> Alarms
		{
			get
			{
				List<Alarm> alarms = new List<Alarm>();

				XmlNodeList xnl = this.xd.SelectNodes("//SnapAlarm/Alarm");

				foreach (XmlNode xn in xnl)
				{
					Alarm alarm = new Alarm();
					alarm.Id = new Guid(xn.Attributes["id"].Value);
					alarm.Message = xn.SelectSingleNode("Message").InnerText;
					alarm.Trigger = DateTime.Parse(xn.SelectSingleNode("Trigger").InnerText);

					alarms.Add(alarm);
				}

				return alarms;
			}
		}

		public void Delete(Guid id)
		{
			XmlNode xn = this.xd.SelectSingleNode(String.Format("/SnapAlarm/Alarm[@id='{0}']", id));

			if (xn == null)
				throw new AlarmNotFoundException("Alarm not found with GUID: '" + id.ToString() + "'.", id);
			else
			{
				this.xd.DocumentElement.RemoveChild(xn);

				this.xd.Save(Utility.StorageFile);
			}
		}

		public bool AlarmExists(Guid id)
		{
			XmlNodeList xnl = this.xd.SelectNodes("//SnapAlarm/Alarm");

			foreach (XmlNode xn in xnl)
			{
				if (xn.Attributes["id"].Value == id.ToString())
					return true;
			}

			return false;
		}
	}
}
