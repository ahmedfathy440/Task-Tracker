namespace Task_Tracker
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int index = 0;
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to my task tracker");
            Console.WriteLine("enter 1 for Add new task  \n" +
                                  "enter 2 for view all tasks\n" +
                                  "enter 3 for task completed\n" +
                                  "enter 4 for delete task   \n" +
                                  "enter 5 to exit           \n");

            bool isLooped = true;

            while (isLooped)
            {
                Console.WriteLine("Enter choise from 1 to 5:");
                
                string userChoise = Console.ReadLine();
                
                switch (userChoise)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        MarkComplete();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "5":
                        //Environment.Exit(0);
                        isLooped = false;
                        break;
                    default:
                        Console.WriteLine("Please enter number from 1 to 5");
                        break;
                }
            }
        }

        private static void AddTask()
        {
            Console.WriteLine("Enter task title");
            string newTask = Console.ReadLine();
            Console.WriteLine("task added succeefully\n");
            
            tasks[index] = newTask;
            index++;
        }

        private static void ViewTasks()
        {
            for (int i = 0; i < index ; i++) 
            {
                Console.WriteLine($"{i+1}. Task Title: {tasks[i]}");
            }
            Console.WriteLine();
        }

        private static void MarkComplete()
        {
            Console.WriteLine("Enter task number to complete");
            int num = int.Parse(Console.ReadLine());

            tasks[num  - 1] =  tasks[num -1] +" --Completed";
            Console.WriteLine($"task {num } marked as completed");
            Console.WriteLine();
            ViewTasks();
        }

        private static void RemoveTask()
        {
            Console.WriteLine("Enter task number to delete");

            int deleteNum = Convert.ToInt32(Console.ReadLine());

            tasks[deleteNum - 1] = string.Empty;
            
            Console.WriteLine($"task {deleteNum } deleted ");
            Console.WriteLine();
            ViewTasks();
        }
    }
}
