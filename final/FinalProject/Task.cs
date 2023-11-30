class Task
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public int CompletionCount { get; private set; }

    public Task(string description)
    {
        Description = description;
        IsCompleted = false;
        CompletionCount = 0;
    }

    public void CompleteTask()
    {
        IsCompleted = true;
        CompletionCount++;
    }
}