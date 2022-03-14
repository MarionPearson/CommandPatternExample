
namespace CommandPatternExample
{
	/// <summary>
	/// Interface inherited by any Command class.
	/// Contains one method, execute(), which performs a task specific to the command calling it.
	/// </summary>
	public interface ICommand
	{
		void execute();
	}
}
