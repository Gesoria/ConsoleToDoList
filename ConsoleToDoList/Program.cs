using ToDoListLogic;

namespace ConsoleToDoList
{
    internal class Program
    {
        static void AddTask(ToDoList current)
        {
            Console.WriteLine("Введите название задачи:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите описание задачи:");
            string description = Console.ReadLine();
            Console.WriteLine("Введите дату выполнения задачи (гггг-мм-дд):");
            string deadline = Console.ReadLine();
            Console.WriteLine("Выберите приоритет задачи (от 1 до 3, где: 1 - неважно, 2 - важно, 3 - критически важно):");
            string priority = Console.ReadLine();
            current.AddTask(name, description, deadline, priority);
            Console.WriteLine("Задача успешно добавлена");
        }
        static void EditTask(ToDoList current)
        {
            Console.WriteLine("Введите номер задачи");
            int changeID = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите изменения в наименование задачи (Нажмите Enter, чтобы пропустить)");
            string newName = Console.ReadLine();
            Console.WriteLine("Введите изменения в описание задачи (Нажмите Enter, чтобы пропустить)");
            string newDescription = Console.ReadLine();
            Console.WriteLine("Измените дату выполнения задачи (Нажмите Enter, чтобы пропустить)");
            string newDeadline = Console.ReadLine();
            Console.WriteLine("Измените приоритет задачи (от 1 до 3, где: 1 - неважно, 2 - важно, 3 - критически важно)" +
                " (Нажмите Enter, чтобы пропустить)");
            int newPriority = int.Parse(Console.ReadLine());
            current.EditTask(changeID, newName, newDescription, newDeadline, newPriority);
            Console.WriteLine("Задача успешно изменена");
        }
        static void DeleteTask(ToDoList current)
        {
            Console.WriteLine("Введите номер задачи");
            int changeID = int.Parse(Console.ReadLine());
            current.DeleteTask(changeID);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в ваш список дел!");
            Console.WriteLine("Введите имя пользователя");
            string name = Console.ReadLine();
            ToDoList newlist = new ToDoList(name);
            int action = -1;
            while (action != 5)
            {
                Console.WriteLine("1. Добавить задачу\n2. Просмотреть список задач\n3. Редактировать задачу\n4. Удалить задачу\n5. Выйти");
                Console.WriteLine("Выберите действие (1/2/3/4/5):");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            AddTask(newlist);
                        }
                        break;
                    case 2:
                        {
                            newlist.PrintAlltasks();
                        }
                        break;
                    case 3:
                        {
                            EditTask(newlist);
                        }
                        break;
                    case 4:
                        {
                            DeleteTask(newlist);
                        }
                        break;
                    case 5:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Введите число от 1 до 5");
                        }
                        break;
                }
                Console.WriteLine("");

            }
        }

    }
}