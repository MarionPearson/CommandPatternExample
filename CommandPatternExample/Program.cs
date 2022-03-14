using CommandPatternExample.Commands;
using CommandPatternExample.Invokers;
using CommandPatternExample.Receivers;

namespace CommandPatternExample
{
	class Program
	{
		/// <summary>
		/// The main method here acts as the client in the command pattern.
		/// It is responsible for creating the receivers and commands, as well as assigning them to the correct invoker.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			// Instantiate the invoker
			Remote remote = new Remote();

			// Instantiate the receivers
			ApertureThermostatDevice thermostat = new ApertureThermostatDevice();
			TyrellTelevisionDevice television = new TyrellTelevisionDevice();

			// Instantiate the commands
			TelevisionVolumeUpCommand volUp = new TelevisionVolumeUpCommand(television);
			TelevisionVolumeDownCommand volDown = new TelevisionVolumeDownCommand(television);
			ThermostatTemperatureUpCommand tempUp = new ThermostatTemperatureUpCommand(thermostat);
			ThermostatTemperatureDownCommand tempDown = new ThermostatTemperatureDownCommand(thermostat);

			// Execute some commands on the invoker
			remote.setButtonCommand(volUp);
			remote.onPressed();
			remote.setButtonCommand(volDown);
			remote.onPressed();
			remote.setButtonCommand(tempUp);
			remote.onPressed();
			remote.setButtonCommand(tempDown);
			remote.onPressed();
		}
	}
}
