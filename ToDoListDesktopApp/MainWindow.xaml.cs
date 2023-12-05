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
        public MainWindow()
        {
            myTaskList = new("Pirozho4ek");
            InitializeComponent();
         

            dataGrid.ItemsSource = myTaskList.Tasks;
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
