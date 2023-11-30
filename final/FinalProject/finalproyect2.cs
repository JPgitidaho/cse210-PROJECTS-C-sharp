/*using System;
using System.Collections.Generic;

// Abstraction: Define abstract classes/interfaces to model objects
abstract class TaskList
{
    public string ListName { get; set; }
    public List<Task> Tasks { get; set; }

    // Abstraction: Constructor para inicializar las propiedades
    public TaskList(string listName)
    {
        ListName = listName;
        Tasks = new List<Task>();
    }

    // Abstraction: Defining an abstract method to be implemented by derived classes
    public abstract void DisplayTasks();
}

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

class User
{
    public string UserName { get; set; }
    public int Points { get; set; }
    public List<TaskList> TaskLists { get; set; }

    public User(string userName)
    {
        UserName = userName;
        Points = 0;
        TaskLists = new List<TaskList>();
    }
}


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


// Encapsulation: Separate concerns with a dedicated class for rewards
class Reward
{
    public static void ProvideRewards(User user)
    {
        Console.WriteLine($"{user.UserName} earned rewards!");
        user.Points += 5;
    }
}

// Encapsulation: Separate concerns with a dedicated class for statistics
class Statistics
{
    public static void DisplayStatistics(User user)
    {
        Console.WriteLine($"Statistics for {user.UserName}: Points - {user.Points}");
    }
}

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

class Program
{
    static void Main()
    {
        // Solicitar el nombre del usuario
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Crear una instancia del usuario
        User user = new User(userName);

        // Crear una lista personalizada de tareas para el usuario
        CleaningTaskList customTaskList = new CleaningTaskList("Your Tasks list");

        // Agregar la instancia de CleaningTaskList a la lista TaskLists del usuario
        user.TaskLists.Add(customTaskList);

        // Mensaje de bienvenida
        Console.WriteLine($"Welcome to the Household Task Manager, {user.UserName}!");

        // Bucle principal del programa
        while (true)
        {
            // Menú de opciones
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Tasks");
            Console.WriteLine("2. Add Custom Task");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Display Statistics");
            Console.WriteLine("5. Generate Report");
            Console.WriteLine("0. Exit");

            // Solicitar la elección del usuario
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            // Procesar la elección del usuario
            switch (choice)
            {
                case "1":
                    customTaskList.DisplayTasks();
                    break;
                case "2":
                    // Solicitar al usuario descripción de la tarea y agregarla a la lista
                    Console.Write("Enter task description: ");
                    string taskDescription = Console.ReadLine();
                    customTaskList.AddTask(taskDescription);
                    Console.WriteLine($"Task '{taskDescription}' added.");
                    break;
                case "3":
                    // Solicitar al usuario el índice de la tarea a completar y marcarla como completada
                    Console.Write("Enter the index of the task to complete: ");
                    if (int.TryParse(Console.ReadLine(), out int taskIndex))
                    {
                        customTaskList.CompleteTask(taskIndex, user);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "4":
                    // Mostrar estadísticas del usuario
                    Statistics.DisplayStatistics(user);
                    break;
                case "5":
                    // Generar un informe para el usuario
                    Report.GenerateReport(user);
                    break;

                case "0":
                    // Salir del programa
                    Console.WriteLine("Exiting. Goodbye!");
                    return;
                default:
                    // Mensaje para elecciones no válidas
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
*/