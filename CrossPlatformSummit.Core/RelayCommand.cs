using System;
using System.Windows.Input;

namespace CrossPlatformSummit.Core
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _executeAction;

        public RelayCommand(Action<T> executeAction)
        {
            _executeAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (_executeAction != null)
            {
                _executeAction.Invoke((T)parameter);
            }
        }

        public event EventHandler CanExecuteChanged;
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _executeAction;

        public RelayCommand(Action executeAction)
        {
            _executeAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (_executeAction != null)
            {
                _executeAction.Invoke();
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
