using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<Task> tasks;
    private int nextId;

    public TaskManager()
    {
        tasks = new List<Task>();
        nextId = 1;
    }

    public void AddTask(string description)
    {
        Task newTask = new Task(nextId, description);
        tasks.Add(newTask);
        nextId++;
        Console.WriteLine("Task added!");
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to display.");
            return;
        }

        Console.WriteLine("\nTasks:");
        foreach (Task task in tasks)
        {
            Console.WriteLine(task.ToString());
        }
    }

    public void MarkTaskAsComplete(int id)
    {
        Task task = tasks.Find(t => t.ID == id);
        if (task != null)
        {
            task.MarkAsComplete();
            Console.WriteLine("Task marked as complete!");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }

    public void DeleteTask(int id)
    {
        Task task = tasks.Find(t => t.ID == id);
        if (task != null)
        {
            tasks.Remove(task);
            Console.WriteLine("Task deleted!");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }
}
