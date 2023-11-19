abstract class Goal
{
    // Protected fields to store goal details
    protected string _name;
    protected string _description;
    protected bool _achieved;
    protected int _points;

    // Method to prepare the details of the goal
    public virtual void PrepareGoal()
    {   Console.WriteLine();
        Console.Write("What would you like to name your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Write a short description of your goal: ");
        _description = Console.ReadLine();
        Console.WriteLine();
        _points = GoalManager.ReadInt("How many points would you like to assign to this goal? ");
        Console.WriteLine();
    }

    // Abstract method to be implemented by subclasses to record an event for the goal
    public abstract void RecordEvent();

    // Virtual method to display the goal details
    public virtual void DisplayGoal()
    {
        Console.Write(_achieved ? "[X]" : "[ ]");
        Console.Write($" {_name} ({_description})");
    }

    // Abstract method to get a string representation of the goal
    public abstract string GetStringRepresentation();

    // Method to add bonus points to the goal
    public void AddPoints(int bonusPoints)
    {
        Console.WriteLine($"Congratulations! You got {bonusPoints} bonus points");
        Goal.Totalpoints += bonusPoints;
    }

    // Method to add standard points to the goal
    public void AddPoints()
    {
        Console.WriteLine($"Congratulations! You got {_points} points");
        Goal.Totalpoints += _points;
    }

    // Method to check if the goal is achieved
    public bool IsAchieved()
    {
        return _achieved;
    }

    // Static property to track the total points across all goals
    public static int Totalpoints { get; set; }
}
