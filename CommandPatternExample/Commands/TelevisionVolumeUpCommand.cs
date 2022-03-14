

namespace CommandPatternExample.Commands
{
	class TelevisionVolumeUpCommand: ICommand
	{
		private ITelevisionDevice _device;
		public TelevisionVolumeUpCommand(ITelevisionDevice device)
		{
			this._device = device;
		}

		public void execute()
		{
			this._device.VolumeUp();
		}
	}
}
