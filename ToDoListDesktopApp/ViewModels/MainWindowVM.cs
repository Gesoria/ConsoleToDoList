using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using ToDoListLogic;

namespace ToDoListDesktopApp.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged
    {

        public ObservableCollection<ToDoTask> Tasks
        {
            get { return tasks; }
            set
            {
                tasks = value;
                OnPropertyChanged(nameof(Tasks));
            }
        }      

        public event PropertyChangedEventHandler? PropertyChanged;
        private ObservableCollection<ToDoTask> tasks;

        public MainWindowVM()
        {
            tasks = new ObservableCollection<ToDoTask>();

            ToDoTask task1 = new("Помыть кота", "С фейри", DateTime.Now, 1, 2);
            ToDoTask task2 = new("Помыть кота", "С фейри", DateTime.Now, 1, 2);
            ToDoTask task3 = new("Помыть кота", "С фейри", DateTime.Now, 1, 3);
            ToDoTask task4 = new("Помыть кота", "С фейри", DateTime.Now, 1, 1);
            ToDoTask task5 = new("Помыть кота", "С фейри", DateTime.Now, 1, 3);
            ToDoTask task6 = new("Помыть кота", "С фейри", DateTime.Now, 1, 1);
            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);
            tasks.Add(task6); tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);
            tasks.Add(task6); tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);
            tasks.Add(task6); tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);
            tasks.Add(task6); tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);
            tasks.Add(task6);

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}



