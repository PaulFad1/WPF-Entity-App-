using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace GroupViewer
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public AddWindowVM viewModel { get; set; }


        public AddCommand(AddWindowVM vm) 
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.Db.students.Add(new Student { LName = viewModel.LName, FName = viewModel.FName, SName = viewModel.SName, GroupStudent = viewModel.StudentsGroup, Stip = viewModel.Stip });
            viewModel.Db.SaveChanges();
            viewModel.close();
        }
    }
}
