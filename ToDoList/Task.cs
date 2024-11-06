using System;

public class Task
{
    public int ID { get; set; }
    public string Description { get; set; }  // Corrected the spelling here
    public bool IsComplete { get; set; }

    public Task(int id, string description)
    {
        ID = id;
        Description = description;
        IsComplete = false;
    }

    public void MarkAsComplete()
    {
        IsComplete = true;
    }

    public override string ToString()
    {
        string status = IsComplete ? "Completed" : "Pending";
        return $"[{ID}] {Description} - {status}";
    }
}
