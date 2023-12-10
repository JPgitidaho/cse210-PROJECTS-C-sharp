/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Task
{
    public string Description { get; private set; }
    public bool IsCompleted { get; set; }
    public int CompletionCount { get; private set; }

    public Task(string description)
    {
        Description = description;
    }

    public void CompleteTask()
    {
        IsCompleted = true;
        CompletionCount++;
    }

    public string GetDescription()
    {
        return Description;
    }

    public int GetCompletionCount()
    {
        return CompletionCount;
    }
}

abstract class TaskList
{
    public string ListName { get; protected set; }
    protected List<Task> Tasks;

    public TaskList(string listName)
    {
        ListName = listName;
        Tasks = new List<Task>();
    }

    public abstract void DisplayTasks();

    public List<Task> GetTasks()
    {
        return Tasks;
    }
    public void AddTask(string description)
    {
        Tasks.Add(new Task(description));
    }

    public string GetListName()
    {
        return ListName;
    }
}

class CleaningTaskList : TaskList
{
    public CleaningTaskList(string listName) : base(listName) { }

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


public void CompleteTask(int taskIndex, User user)
        {
            int adjustedIndex = taskIndex - 1;

            if (adjustedIndex >= 0 && adjustedIndex < Tasks.Count)
            {
                Tasks[adjustedIndex].CompleteTask();
                Console.WriteLine($"Task '{Tasks[adjustedIndex].GetDescription()}' marked as completed.");

                user.GetTaskLists().Add(this);

                Reward.ProvideRewards(user);
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
    }
}

class User
{
    public string UserName { get; set; }
    public int Points { get; set; }
    public List<TaskList> TaskLists { get; set; }

    public User(string userName)
    {
        this.UserName = userName;
        this.Points = 0;
        this.TaskLists = new List<TaskList>();
    }

    public int GetPoints()
    {
        return Points;
    }

    public void AddPoints(int additionalPoints)
    {
        Points += additionalPoints;
    }

    public List<TaskList> GetTaskLists()
    {
        return TaskLists;
    }
}

class Reward
{
    public static void ProvideRewards(User user)
    {
        Console.WriteLine($"{user.GetPoints()} earned rewards!");
        user.AddPoints(5);
    }
}

class Report
{
    public static void GenerateReport(User user)
    {
        Console.WriteLine($"Generating report for {user.UserName}...");
        // Implementación para generar el informe
    }

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

    public static void DisplayCompletedTasks(User user)
    {
        Console.WriteLine(GetCompletedTasks(user));
    }
}

class Statistics
{
    public static void DisplayStatistics(User user)
    {
        Console.WriteLine($"Statistics for {user.GetPoints()}: Points - {user.GetPoints()}");
    }
}

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        User user = new User("UsuarioEjemplo");
        user.TaskLists.Add(new CleaningTaskList("Lista de Tareas de Limpieza"));

        // Agregar tareas de ejemplo
        user.TaskLists[0].GetTasks().Add(new Task("Limpiar el baño"));
        user.TaskLists[0].GetTasks().Add(new Task("Barrer el suelo"));

        // Completar una tarea de ejemplo
        user.TaskLists[0].GetTasks()[0].CompleteTask(); // Completar la primera tarea en la lista

        // Mostrar estadísticas y recompensas
        Statistics.DisplayStatistics(user);
        Reward.ProvideRewards(user);

        // Generar y mostrar un informe
        Report.GenerateReport(user);
    }
}
*/