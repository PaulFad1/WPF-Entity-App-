using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GroupViewer
{
    public class AddWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public AddWindow window { get; set; }
        public MainVM vm { get; set; }
        public AddCommand AddCommand { get; set; }


        public string LName { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string StudentsGroup { get; set; }

        public float Stip { get; set; }

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public StudentDb Db { get; set; }
        public MainVM Mvm { get; set; }
        public void close() 
        {
            Mvm.StudentsList = Mvm.db.students.ToList(); 
            window.Close();
        }
        public AddWindowVM(AddWindow w, MainVM vm) 
        {
            Mvm = vm;
            window = w;
            AddCommand = new AddCommand(this);
            Db = new StudentDb();
            
        }
    }
}
