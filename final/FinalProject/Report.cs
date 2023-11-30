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
        int completedTaskCount = 0;

        foreach (var taskList in user.TaskLists)
        {
            foreach (var task in taskList.Tasks)
            {
                if (task.IsCompleted)
                {
                    Console.WriteLine($"- {task.Description} (Category: {taskList.ListName})");
                    completedTaskCount++;
                }
            }
        }

        if (completedTaskCount == 0)
        {
            Console.WriteLine("No tasks completed yet.");
        }
    }
}