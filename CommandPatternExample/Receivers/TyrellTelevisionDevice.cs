using System;

namespace CommandPatternExample.Receivers
{
	public class TyrellTelevisionDevice : ITelevisionDevice
	{
		private int _channel = 4;
		private int _volume = 0;
		public void SetChannel(int channel)
		{
			_channel = channel;
			Console.WriteLine("Channel set to: " + _channel);
		}

		public void TelevisionOff()
		{
			Console.WriteLine("The TV is off.");
		}

		public void TelevisionOn()
		{
			Console.WriteLine("The TV is on.");
		}

		public void VolumeDown()
		{
			_volume--;
			Console.WriteLine("TV volume is set to: " + _volume);
		}

		public void VolumeUp()
		{
			_volume++;
			Console.WriteLine("TV volume is set to: " + _volume);
		}
	}
}
