
namespace CommandPatternExample.Commands
{
	class ThermostatTemperatureUpCommand : ICommand
	{
		private IThermostatDevice _device;
		public ThermostatTemperatureUpCommand(IThermostatDevice device)
		{
			_device = device;
		}
		public void execute()
		{
			_device.incrementTemperature();
		}
	}
}
