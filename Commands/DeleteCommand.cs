using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GroupViewer
{
    public class DeleteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainVM viewModel { get; set; }

        public DeleteCommand(MainVM vm) 
        {
            viewModel = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.deleteEl();
        }
    }
}
