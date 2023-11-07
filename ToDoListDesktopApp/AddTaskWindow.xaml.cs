using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ToDoListLogic;

namespace ToDoListDesktopApp
{
    /// <summary>
    /// Логика взаимодействия для AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        private ToDoList _myTaskList;

        private MainWindow _mainWindow;


        public AddTaskWindow(ToDoList myTaskList, MainWindow mainWindow)
        {
            InitializeComponent();
            this._myTaskList = myTaskList;
            this._mainWindow = mainWindow;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {

            string name = TextBoxName.Text;
            string? desc = TextBoxDescription.Text;

            DateTime? deadline = PickTaskDeadline.SelectedDate;


            int priority = 0;
            if (Priority1.IsChecked == true)
            {
                priority = 1;
            }
            else if (Priority2.IsChecked == true)
            {
                priority = 2;
            }
            else if (Priority3.IsChecked == true)
            {
                priority = 3;
            }


            Task taso4ka = new Task(name, desc, deadline.GetValueOrDefault(), 1, priority);


            TextBoxName.Clear();
            TextBoxDescription.Clear();
            PickTaskDeadline.SelectedDate = DateTime.Now;
            Priority1.IsChecked = false;
            Priority2.IsChecked = false;
            Priority3.IsChecked = false;

            MessageBox.Show("Задача успешно добавлена!");
            _myTaskList.AddTask(taso4ka);
            _mainWindow.Show();
            this.Close();

        }
     
    }
}
