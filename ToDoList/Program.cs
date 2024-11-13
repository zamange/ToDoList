using System;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("        🌟 Welcome to the To-Do List App 🌟");
            Console.WriteLine("========================================");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1️⃣  ➔ Add a new task");
            Console.WriteLine("2️⃣  ➔ View tasks");
            Console.WriteLine("3️⃣  ➔ Mark task as complete");
            Console.WriteLine("4️⃣  ➔ Delete a task");
            Console.WriteLine("5️⃣  ➔ Exit");
            Console.Write("➡️  Enter your choice (1-5): ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n📝 Adding a new task...");
                    Console.Write("Enter the task description: ");
                    string description = Console.ReadLine();
                    taskManager.AddTask(description);
                    Console.WriteLine("✅ Task added successfully!");
                    break;
                
                case "2":
                    Console.WriteLine("\n📋 Viewing all tasks...");
                    taskManager.ViewTasks();
                    break;

                case "3":
                    Console.Write("\n✔️ Enter the ID of the task to mark as complete: ");
                    if (int.TryParse(Console.ReadLine(), out int completeId))
                    {
                        taskManager.MarkTaskAsComplete(completeId);
                    }
                    else
                    {
                        Console.WriteLine("❌ Invalid ID.");
                    }
                    break;

                case "4":
                    Console.Write("\n🗑️ Enter the ID of the task to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                    {
                        taskManager.DeleteTask(deleteId);
                        Console.WriteLine("🗑️ Task deleted successfully!");
                    }
                    
                    else
                    {
                        Console.WriteLine("❌ Invalid ID.");
                    }
                    break;

                case "5":
                    Console.WriteLine("\n👋 Exiting... Thank you for using the To-Do List App!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("⚠️ Invalid choice, please try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}
