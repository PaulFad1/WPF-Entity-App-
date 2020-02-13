using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace GroupViewer
{
    public class MainVM :INotifyPropertyChanged
    {
        private List<Student> list;
        public event PropertyChangedEventHandler PropertyChanged;
        public SortCommand SortCommand { get; set; }  
        public DeleteCommand DeleteCommand { get; set; }
        public AddWindowCommand AddWindowCommand { get; set; }
        protected virtual void OnPropertyChanged(string propertyName = "") 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public MainWindow MainWindow { get; set; }
        public List<Student> StudentsList {
            get
            {
                return list;
            }
            set
            {
                list = value;
                OnPropertyChanged("StudentsList");
            }
        }
        public void SortByStip() 
        {
            StudentsList =  StudentsList.OrderByDescending(x => x.Stip).ToList();
        }
        public void deleteEl() 
        {
            var st = (Student)MainWindow.StudentsList.SelectedItem;
            StudentsList.Remove(st);
            StudentsList = StudentsList.ToList();
            db.students.Remove(st);
            db.SaveChanges();
            
        }
        public StudentDb db { get; set; }
        public MainVM(MainWindow mw)
        {
            MainWindow = mw;
            SortCommand = new SortCommand(this);
            DeleteCommand = new DeleteCommand(this);
            AddWindowCommand = new AddWindowCommand(this);
            db = new StudentDb();
            var stud = db.students.ToList();
            StudentsList = new List<Student>();
            foreach(var s in stud) 
            {
                StudentsList.Add(s);
            }
            //Student = new Student { LName = "Фадеев", FName = "Павел", SName = "Сергеевич", Group = "НПИбд", Stip = 0 };
            //StudentsList.Add(new Student { LName = "Фадеев", FName = "Павел", SName = "Сергеевич", Group = "НПИбд", Stip = 0 });
            //StudentsList.Add(new Student { LName = "Аносов", FName = "Роман", SName = "Сергеевич", Group = "НПИбд", Stip = 5000 });
            //StudentsList.Add(new Student { LName = "Удалов", FName = "Тимофей", SName = "Дмитриевич", Group = "НПИбд", Stip = 1000 });
            //StudentsList.Add(new Student { LName = "Новосельцев", FName = "Максим", SName = "Сергеевич", Group = "НПИбд", Stip = 2000 });
        }

    }
}
