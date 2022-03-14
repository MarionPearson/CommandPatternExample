
namespace CommandPatternExample.Invokers
{
	class Remote: ISingleButtonRemote
	{
		private ICommand buttonSlot;

		public void setButtonCommand(ICommand command)
		{
			buttonSlot = command;
		}

		public void onPressed()
		{
			buttonSlot.execute();
		}
	}
}
