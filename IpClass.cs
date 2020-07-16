using System;

namespace IpTools
{
	public class IpClass
	{
		private string ip;

		private string city;

		public string Ip
		{
			get
			{
				return this.ip;
			}
			set
			{
				this.ip = value;
			}
		}

		public string City
		{
			get
			{
				return this.city;
			}
			set
			{
				this.city = value;
			}
		}
	}
}
