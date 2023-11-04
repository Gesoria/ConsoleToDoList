using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListLogic
{
    public class Task
    {
        public  string Name { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }

        public int TaskID { get; set; }

        private const int MaxPriority = 3;

        public Task(string name, string description, DateTime deadline, int taskID, int priority = 0) 
        {
            Name = name;
            Description = description;
            DeadLine = deadline;
            IsCompleted = false;
            Priority = priority;
            TaskID = taskID;
        }
        public void PrintAboutOfTask() 
        {
            Console.WriteLine($"Номер задачи: {TaskID}");
            Console.WriteLine($"Наименование задачи: {Name}");
            Console.WriteLine($"Описание задачи: {Description}");
            Console.WriteLine($"Дата выполнения задачи: {DeadLine.Date}");
            Console.WriteLine($"Приоритет задачи: {Priority} из {MaxPriority}");
            if (IsCompleted) Console.WriteLine("Задача выполнена");
            else Console.WriteLine("Задача не выполнена");

        }
        public void EditTask(string newName = "", string newDescription = "", string newDeadline = "", int newPriority = 0 )
        {
            if (newName != "")
            {
                Name = newName;
            }
            if (newDescription != "")
            {
                Description = newDescription;
            }
            if (newDeadline != "")
            {
                DeadLine = StringHelper.ConvertStringToDate(newDeadline);
            }
            if (newPriority != 0)
            {
                Priority = newPriority;
            }
        }



    } 

}
