// Encapsulation: Separate concerns with a dedicated class for reports
class Report
{
    public static void GenerateReport(User user)
    {
        Console.WriteLine($"Generating report for {user.UserName}...");

        // Mostrar la lista de tareas completadas
        DisplayCompletedTasks(user);

    }

    private static void DisplayCompletedTasks(User user)
{
    Console.WriteLine($"Completed Tasks for {user.UserName}:");

    foreach (var taskList in user.TaskLists)
    {
        var completedTasksInList = taskList.Tasks.Where(task => task.IsCompleted);

        if (completedTasksInList.Any())
        {
            Console.WriteLine($"Tasks in {taskList.ListName}:");

            foreach (var completedTask in completedTasksInList)
            {
                Console.WriteLine($"- {completedTask.Description}");
            }
        }
        else
        {
            Console.WriteLine($"No completed tasks in {taskList.ListName}.");
        }
    }

    if (!user.TaskLists.Any())
    {
        Console.WriteLine("No completed tasks yet.");
    }
}
}