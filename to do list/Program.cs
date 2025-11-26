namespace to_do_list
{
    class Task
    {
        public string task_title { set; get; }
        public string status = "incomplete";
        public Task(string task_title)
        {
            this.task_title = task_title;
        }

        public void markComplete()
        { status = "complete"; }
        public void markIncomplete()
        { status = "incomplete";}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> taskList = new List <Task>();
            bool use = true;
            do
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1- View tasks");
                Console.WriteLine("2- Add task");
                Console.WriteLine("3- Remove task");
                Console.WriteLine("4- Mark task as complete");
                Console.WriteLine("5- Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        viewTasks();
                        break;
                    case 2:
                        addTask();
                        break;
                    case 3:
                        removeTask();
                        break;
                    case 4:
                        taskStatus();
                        break;
                    case 5:
                        use = false;
                        break;
                    default:
                        Console.WriteLine("Invaild option, please try again!");
                        break;
                }
            }
            while (use == true);

            void viewTasks()
            {
                if (taskList.Count == 0)
                {
                    Console.WriteLine("No tasks available!");
                }
                else
                {
                    Console.WriteLine($"You have {taskList.Count} task/s");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}-  {taskList[i].task_title} status: {taskList[i].status}");
                    }
                }
            }

            void addTask()
            {
                Console.WriteLine("Please enter the number of tasks to add");
                int add_loop = int.Parse(Console.ReadLine());
                for (; add_loop > 0; add_loop--)
                {
                    Console.WriteLine("Please enter task");
                    string task = Console.ReadLine();
                    if (string.IsNullOrEmpty(task))
                    { Console.WriteLine("Please enter task correctly!"); }
                    else
                    {
                        taskList.Add(new Task(task));
                        Console.WriteLine("Task entered successfully!");
                    }

                }
                }

                void removeTask()
                {
                    viewTasks();
                Console.WriteLine("Please enter the number of tasks to remove");
                int remove_loop = int.Parse(Console.ReadLine());
                for (; remove_loop > 0; remove_loop--)
                    Console.WriteLine("Please enter the number of the task you would like to remove!");
                    int number = int.Parse(Console.ReadLine());
                    if (number > 0 && number <= taskList.Count)
                    {
                        taskList.Remove(taskList[number - 1]);
                        Console.WriteLine("Task removed successfully!");
                    }
                    else Console.WriteLine("Please enter a valid number!");

                }

                void taskStatus()
            {if (taskList.Count == 0)
                { Console.WriteLine("no tasks available!"); }
                else
                {
                    viewTasks();
                    Console.WriteLine("Please enter the number of the task you would like to mark!");
                    int n = int.Parse(Console.ReadLine());
                    if (n > 0 && n <= taskList.Count)
                    {
                        Console.WriteLine("please enter c if complete or i if incomplete");
                        char state = char.Parse(Console.ReadLine());
                        state = Char.ToLower(state);
                        switch (state)
                        {
                            case 'c':
                                taskList[n - 1].markComplete();
                                break;

                            case 'i':
                                taskList[n - 1].markIncomplete();
                                break;
                            default:
                                Console.WriteLine("Invalid character, please try again.");
                                break;

                        }
                    }
                    else Console.WriteLine("Invalid number, please try again.");
                }
            }

            


        }
    }
}
