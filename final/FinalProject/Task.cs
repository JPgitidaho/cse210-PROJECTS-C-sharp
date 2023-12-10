
class Task
{
    // Gets the description of the task.
    public string Description { get; private set; }

    // Indicates whether the task is completed.
    public bool IsCompleted { get; set; }

    // Keeps track of how many times the task has been completed.
    public int CompletionCount { get; private set; }

    // Constructor to initialize the task with a description.
    public Task(string description)
    {
        Description = description;
    }

    // Marks the task as completed and increments the completion count.
    public void CompleteTask()
    {
        IsCompleted = true;
        CompletionCount++;
    }

    // Gets the description of the task.
    public string GetDescription()
    {
        return Description;
    }

    // Gets the completion count of the task.
    public int GetCompletionCount()
    {
        return CompletionCount;
    }
}
