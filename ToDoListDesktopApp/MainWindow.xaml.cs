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
using ToDoListLogic;

namespace ToDoListDesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {

            string name = ZalupkaMedvezhonka.Text;
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


            ZalupkaMedvezhonka.Clear();
            TextBoxDescription.Clear();
            PickTaskDeadline.SelectedDate = DateTime.Now;
            Priority1.IsChecked = false;
            Priority2.IsChecked = false;
            Priority3.IsChecked = false;

            MessageBox.Show("Задача успешно добавлена!");




            List<Task> tasks = new List<Task>();//в нём 100 элементов

            Task? neededTask = tasks.Find(t => t.Name == "Оторвать лапку медвежонку)");

            PrintTaskInfo(neededTask);
        }

        private void PrintTaskInfo(Task task)
        {
            Console.WriteLine(task.Name);
        }
    }
}
