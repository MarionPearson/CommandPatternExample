
namespace CommandPatternExample
{
	/// <summary>
	/// The ITelevisionDevice, alongside the IThermostatDevice, serve as interfaces for the receivers in the command pattern.
	/// The receiver is the concrete member of the command pattern that understands and implements the execute() logic invoked in the command.
	/// </summary>
	interface IThermostatDevice
	{
		void incrementTemperature();
		void decrementTemperature();
		void setTemperature(int newTemperature);
	}
}
