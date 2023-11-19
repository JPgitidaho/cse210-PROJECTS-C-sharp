// Exceeding Requirements: The added functionality implements motivational notifications to remind users to log events or progress towards their goals.
// A timer automatically starts every 24 hours, sending a reminder message to users.
// The added functionality includes a menu option that allows users to return to the main menu.

static class NotificationManager
{
    private static Timer notificationTimer;

    public static void StartNotificationTimer()
    {
        // Starts the timer with an interval of 24 hours (86400000 milliseconds)
        notificationTimer = new Timer(SendMotivationalNotification, null, 0, 86400000);
    }

    private static void SendMotivationalNotification(object state)
    {
        // You can customize the motivational notification message
        Console.WriteLine(">>>>>>>>>>>>Remember to log events for your goals today!");
    }
}

static class Menu
{
    // List to store the goals
    static List<Goal> Goals = new List<Goal>();

    // Main method to display the menu and handle user input
    public static void Main()
    {
        // Starts the notification timer at the beginning of the program
        NotificationManager.StartNotificationTimer();

        // Display total points
        Console.WriteLine($"**** Your Total Points: {Goal.Totalpoints} ****");
        Console.WriteLine();

        // Displays the reminder message
        Console.WriteLine(">>>>>>>>>>>>Remember to log events for your goals today!");
        Console.WriteLine();

        List<string> Options = new List<string> { "Create New Goal", "Record Event", "List Goals", "Save Goals", "Load Goals", "Quit" };

        // Adds the "Back" option at the end of the menu
        Options.Add("Back");

        foreach (var option in Options.Select((value, index) => new { Index = index + 1, Value = value }))
        {
            Console.WriteLine($"{option.Index}. {option.Value}");
        }

        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();

        // Handle user choice
        switch (input)
        {
            case "1":
                CreateNewGoal();
                break;
            case "2":
                RecordEvents();
                break;
            case "3":
                ListGoals();
                break;
            case "4":
                GoalManager.WriteGoals(Goals);
                Console.WriteLine("Your goals have been successfully saved!");
                Console.ReadLine();
                Main();
                break;
            case "5":
                Goals = GoalManager.ReadGoals();
                Console.WriteLine("Your goals have been successfully loaded!");
                Console.ReadLine();
                Main();
                break;
            case "6":
                Console.WriteLine("Best of luck in achieving your goals!");
                break;
            case "7": // This is the new "Back" option to return to the beginning
                Main();
                break;
            default:
                Main();
                break;
        }
    }

    // Method to create a new goal based on user input
    public static void CreateNewGoal()
    {
        List<string> Options = new List<string> { "Simple Goal", "Eternal Goal", "Check-List Goal", "Back" };
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine($" {i + 1}. {Options[i]}");
        }
        Console.Write("Select the type of goal you would like to create: ");
        string input = Console.ReadLine();

        // Create a new goal based on user choice
        switch (input)
        {
            case "1":
                Goals.Add(new SimpleGoal());
                break;
            case "2":
                Goals.Add(new EternalGoal());
                break;
            case "3":
                Goals.Add(new ChecklistGoal());
                break;
            case "4":
                Main();
                break;
            default:
                CreateNewGoal();
                break;
        }
        Main();
    }

    // Method to record events for goals
    public static void RecordEvents()
    {
        List<int> currentGoals = new List<int>();
        for (int i = 0; i < Goals.Count; i++)
        {
            if (!Goals[i].IsAchieved())
            {
                currentGoals.Add(i);
            }
        }

        for (int i = 0; i < currentGoals.Count; i++)
        {
            int CG = currentGoals[i];
            Console.WriteLine();
            Console.Write($"\n {i + 1}. ");
            Goals[CG].DisplayGoal();
        }

        if (currentGoals.Count == 0)
        {
            Console.WriteLine("You have no goals at the moment");
        }

        // Adjusted the option label to match the pattern
        Console.WriteLine($"{currentGoals.Count + 1}. Back");
        int input = GoalManager.ReadInt("Choose an option: ") - 1;

        if (input == currentGoals.Count)
        {
            Main();
        }
        else if (input < currentGoals.Count)
        {
            int idx = currentGoals[input];
            Goals[idx].RecordEvent();
            Main();
        }
        else
        {
            RecordEvents();
        }
    }

    // Method to list all goals
    public static void ListGoals()
    {
        Console.Clear();
        Console.WriteLine($" You have {Goals.Count} goals:");
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            Goals[i].DisplayGoal();
        }
        Console.WriteLine($"Press any enter to continue:");
        Console.ReadLine();
        Main();
    }
}
