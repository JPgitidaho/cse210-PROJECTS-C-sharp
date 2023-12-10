// Represents a specific type of task list for cleaning tasks.
class CleaningTaskList : TaskList
{
    // Constructor to initialize the cleaning task list with a name.
    public CleaningTaskList(string listName) : base(listName) { }
    

    // Overrides the DisplayTasks method to show tasks in the cleaning task list.
    public override void DisplayTasks()
    {
        Console.WriteLine($"Tasks in {ListName}:");

        if (Tasks.Any())
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Tasks[i].GetDescription()}");
            }
        }
        else
        {
            Console.WriteLine("No tasks in the list.");
        }
    }
    

    // Marks a task in the cleaning task list as completed and provides rewards to the user.
     public override void CompleteTask(int taskIndex, User user)
    {
        int adjustedIndex = taskIndex - 1;

        if (adjustedIndex >= 0 && adjustedIndex < Tasks.Count)
        {
            Tasks[adjustedIndex].CompleteTask();
            Console.WriteLine($"Task '{Tasks[adjustedIndex].GetDescription()}' marked as completed.");

            // Adds the completed task to the user's task lists.
            user.AddTaskList(this);

            // Provides rewards to the user.
            Reward.ProvideRewards(user);
        }
        else
        {
            Console.WriteLine("Invalid task index.");
        }
    }
    
}
