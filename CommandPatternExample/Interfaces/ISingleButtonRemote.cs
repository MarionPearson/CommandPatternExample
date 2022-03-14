
namespace CommandPatternExample
{
	/// <summary>
	/// Classes inheriting ISingleButtonRemote represent the invokers of the command pattern.
	/// They are responsible for storing the commands, and executing them when called upon.
	/// Importantly, they are well encapsulated and are not aware of what devices or commands are really being used inside of them.
	/// </summary>
	public interface ISingleButtonRemote
	{
		void setButtonCommand(ICommand command);
		void onPressed();
	}
}
