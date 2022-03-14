
namespace CommandPatternExample.Commands
{
	class TelevisionVolumeDownCommand: ICommand
	{
		private ITelevisionDevice _device;
		public TelevisionVolumeDownCommand(ITelevisionDevice device)
		{
			this._device = device;
		}

		public void execute()
		{
			this._device.VolumeDown();
		}
	}
}
