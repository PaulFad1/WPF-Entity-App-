using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace GroupViewer
{
    public class AddWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainVM viewModel { get; set; }

        public AddWindowCommand(MainVM vm) 
        {
            viewModel = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Window window = new AddWindow(viewModel);
            window.Show();

        }
    }
}
