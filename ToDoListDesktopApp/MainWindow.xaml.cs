using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoListDesktopApp.ViewModels;
using ToDoListLogic;

namespace ToDoListDesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ToDoList myTaskList;

        public ObservableCollection<ToDoTask> tasksToDo;
        public MainWindow()
        {
            myTaskList = new("Pirozho4ek");
            InitializeComponent();


            dataGrid.ItemsSource = tasksToDo;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.DataContext is ToDoTask task)
            {
                // Удалите задачу из исходной коллекции (поменяйте это на свою логику)
                (dataGrid.ItemsSource as ObservableCollection<ToDoTask>)?.Remove(task);
            }
        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonAddTask_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow taskWindow = new AddTaskWindow(myTaskList, this);
            taskWindow.Show();
            this.Hide();
        }
    }
}
