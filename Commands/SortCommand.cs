using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GroupViewer
{
    public class SortCommand : ICommand
    {
        public MainVM viewModel { get; set; }
        public event EventHandler CanExecuteChanged;

        public SortCommand(MainVM vm) 
        {
            viewModel = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.SortByStip();
        }
    }
}
