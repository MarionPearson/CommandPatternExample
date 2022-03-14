namespace CommandPatternExample
{
	/// <summary>
	/// The ITelevisionDevice, alongside the IThermostatDevice, serve as interfaces for the receivers in the command pattern.
	/// The receiver is the concrete member of the command pattern that understands and implements the execute() logic invoked in the command.
	/// </summary>
	public interface ITelevisionDevice
	{
		void VolumeUp();
		void VolumeDown();
		void TelevisionOn();
		void TelevisionOff();

		void SetChannel(int channel);
	}
}