
using System.Text;
using System.Linq;

class Report
{
    // Generates a report for completed tasks of a user.
    public static void GenerateReport(User user)
    {
        Console.WriteLine($"Generating report for {user.UserName}...");
        // Implementation for generating the report.
    }

    // Gets a string representation of completed tasks for a user.
    private static string GetCompletedTasks(User user)
    {
        StringBuilder report = new StringBuilder($"Completed Tasks for {user.UserName}:");

        foreach (var taskList in user.TaskLists)
        {
            var completedTasksInList = taskList.GetTasks().Where(task => task.IsCompleted);

            if (completedTasksInList.Any())
            {
                report.AppendLine($"Tasks in {taskList.GetListName()}:");

                foreach (var completedTask in completedTasksInList)
                {
                    report.AppendLine($"- {completedTask.Description}");
                }
            }
            else
            {
                report.AppendLine($"No completed tasks in {taskList.GetListName()}.");
            }
        }

        if (!user.TaskLists.Any())
        {
            report.AppendLine("No completed tasks yet.");
        }

        return report.ToString();
    }

    // Displays completed tasks for a user.
    public static void DisplayCompletedTasks(User user)
    {
        Console.WriteLine(GetCompletedTasks(user));
    }
}
