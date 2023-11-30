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

        }       

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}



