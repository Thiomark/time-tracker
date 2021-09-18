using System;
using System.Windows.Input;

namespace Time_Tracker.Core
{
    class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value ;}
            remove { CommandManager.RequerySuggested -= value; }
        }
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public bool CanExecute(object param)
        {
            return canExecute == null || canExecute(param);
        }
        public void Execute(object param)
        {
            execute(param);
        }
    }
}
