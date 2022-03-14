
namespace CommandPatternExample.Commands
{
	class ThermostatTemperatureDownCommand: ICommand
	{
		private IThermostatDevice _device;
		public ThermostatTemperatureDownCommand(IThermostatDevice device)
		{
			_device = device;
		}
		public void execute()
		{
			_device.decrementTemperature();
		}
	}
}
