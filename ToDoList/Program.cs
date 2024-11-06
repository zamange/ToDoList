using System;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nTo-Do List App");
            Console.WriteLine("1. Add a new task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Mark task as complete");
            Console.WriteLine("4. Delete a task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the task description: ");
                    string description = Console.ReadLine();
                    taskManager.AddTask(description);
                    break;
                case "2":
                    taskManager.ViewTasks();
                    break;
                case "3":
                    Console.Write("Enter the ID of the task to mark as complete: ");
                    if (int.TryParse(Console.ReadLine(), out int completeId))
                    {
                        taskManager.MarkTaskAsComplete(completeId);
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID.");
                    }
                    break;
                case "4":
                    Console.Write("Enter the ID of the task to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                    {
                        taskManager.DeleteTask(deleteId);
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID.");
                    }
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
