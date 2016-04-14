using System;
using System.Windows.Input;

namespace TeamCityTestApp.ViewModels
{
	internal class SimpleCommand
		: ICommand
	{
		private readonly Action _action;
		
		public SimpleCommand(Action action)
		{
			if (action == null)
			{
				throw new ArgumentNullException(nameof(action));
			}

			_action = action;
		}

		public void Execute(object parameter) => _action();

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter) => true;
	}
}