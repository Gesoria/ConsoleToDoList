namespace ToDoListLogic
{
    public class ToDoList
    {
        public string UserName { get; set; }
        public List<ToDoTask> Tasks { get; set; }

        private int TaskId { get; set; }

        public ToDoList(string username)
        {
            UserName = username;
            Tasks = new List<ToDoTask>();
            TaskId = 0;
        }

        public void AddTask(string name, string description, string deadline, string priority)
        {
            TaskId++;
            DateTime deadline1 = StringHelper.ConvertStringToDate(deadline);
            int priority1 = int.Parse(priority);
            ToDoTask newtask = new ToDoTask(name, description, deadline1, TaskId, priority1);
            Tasks.Add(newtask);
        }
        
        public void AddTask(ToDoTask task)
        {
            TaskId++;
            Tasks.Add(task);
        }

        public void PrintAlltasks()
        {
            if (Tasks.Count == 0)
            {
                Console.WriteLine("Задач нет");
                return;
            }
            for(int i = 0; i < Tasks.Count; i++)
            {
                Tasks[i].PrintAboutOfTask();
            }
        }
        public void EditTask(int changeID, string newName = "", string newDescription = "", string newDeadline = "",  int newPriority = 0)
        {            
            ToDoTask neededtask = Tasks.Find(task => task.TaskID == changeID);
            neededtask.EditTask(newName, newDescription, newDeadline, newPriority);            
        }
        public void DeleteTask(int taskID)
        {
            ToDoTask neededtask = Tasks.Find(deltask => deltask.TaskID == taskID);
            Tasks.Remove(neededtask);
        }

        

    }
}