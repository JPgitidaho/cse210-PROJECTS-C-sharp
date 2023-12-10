using System;

class Program
{
    static void Main()
    {
        // Ask for the user's name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Create an instance of the user
        User user = new User(userName);

        // Create a custom task list for the user
        CleaningTaskList customTaskList = new CleaningTaskList("Your Tasks list");

        // Add the instance of CleaningTaskList to the user's TaskLists
        user.TaskLists.Add(customTaskList);

        // Welcome message
        Console.WriteLine($"Welcome to the Household Task Manager, {user.UserName}!");

        int choice;
        do
        {
            choice = Menu.ShowMenu();

            switch (choice)
            {
                case 1:
                    customTaskList.DisplayTasks();
                    break;
                case 2:
                    Console.Write("Enter task description: ");
                    string taskDescription = Console.ReadLine();
                    customTaskList.AddTask(taskDescription);
                    Console.WriteLine($"Task '{taskDescription}' added.");
                    break;
                case 3:
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
                case 4:
                    Statistics.DisplayStatistics(user);
                    break;
                case 5:
                    Report.GenerateReport(user);
                    break;
                case 0:
                    Console.WriteLine("Exiting. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 0);
    }
}
