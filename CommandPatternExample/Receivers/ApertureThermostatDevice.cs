using System;

namespace CommandPatternExample.Receivers
{
	class ApertureThermostatDevice : IThermostatDevice
	{
		private int _temperature;
		public void decrementTemperature()
		{
			_temperature--;
			Console.WriteLine("Temperature is now set to: " + _temperature);
		}

		public void incrementTemperature()
		{
			_temperature++;
			Console.WriteLine("Temperature is now set to: " + _temperature);
		}

		public void setTemperature(int newTemperature)
		{
			_temperature = newTemperature;
			Console.WriteLine("Temperature is now set to: " + _temperature);
		}
	}
}
