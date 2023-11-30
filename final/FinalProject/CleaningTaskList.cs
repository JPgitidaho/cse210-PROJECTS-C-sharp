// Inheritance: Inherit from TaskList for different areas of the home
class CleaningTaskList : TaskList
{
    public CleaningTaskList(string listName) : base(listName) { }

    public void AddTask(string taskDescription)
    {
        Tasks.Add(new Task(taskDescription));
    }

    public void CompleteTask(int userProvidedIndex, User user)
    {
        int taskIndex = userProvidedIndex - 1;

        if (taskIndex >= 0 && taskIndex < Tasks.Count)
        {
            Tasks[taskIndex].CompleteTask();
            Console.WriteLine($"Task '{Tasks[taskIndex].Description}' marked as completed.");

            // Agregar la tarea completada a la lista de TaskLists del usuario
            user.TaskLists.Add(this);

            // Reward user with points for completing a task
            Reward.ProvideRewards(user);
        }
        else
        {
            Console.WriteLine("Invalid task index.");
        }
    }

    // Implementación del método abstracto en la clase derivada
    public override void DisplayTasks()
    {
        Console.WriteLine($"Cleaning Tasks for {ListName}:");

        for (int i = 0; i < Tasks.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] - {Tasks[i].Description} {(Tasks[i].IsCompleted ? "[Completed]" : "")}");
        }
    }
}