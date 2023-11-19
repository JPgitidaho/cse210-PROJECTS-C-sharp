class EternalGoal : Goal
{
    // Private field to store the number of times the eternal goal has been completed
    private int _timesCompleted = 0;

    // Default constructor to create a new EternalGoal
    public EternalGoal()
    {
        // Initialize the EternalGoal by preparing its details
        PrepareGoal();
    }

    // Constructor for recreating an EternalGoal from stored information
    public EternalGoal(string[] info)
    {
        // Initialize EternalGoal properties from stored information
        _name = info[0];
        _description = info[1];
        _points = int.Parse(info[2]);
        _timesCompleted = int.Parse(info[3]);
    }

    // Override method to record an event for the EternalGoal
    public override void RecordEvent()
    {
        // Increment the count of times the eternal goal has been completed
        _timesCompleted++;

        // Add points for achieving the goal
        AddPoints();
    }

    // Override method to display the EternalGoal's information
    public override void DisplayGoal()
    {
        // Call the base class method to display common goal information
        base.DisplayGoal();

        // Append specific information for EternalGoal
        Console.Write($"****Currently completed: {_timesCompleted} times");
    }

    // Override method to get a string representation of the EternalGoal
    public override string GetStringRepresentation()
    {
        // Return a formatted string with EternalGoal details for storage
        return $"EternalGoal:{_name},{_description},{_points},{_timesCompleted}";
    }
}
