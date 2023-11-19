class SimpleGoal : Goal
{
    // Constructor for creating a new SimpleGoal
    public SimpleGoal()
    {
        // Initialize the SimpleGoal by preparing its details
        PrepareGoal();
    }

    // Constructor for recreating a SimpleGoal from stored information
    public SimpleGoal(string[] info)
    {
        // Initialize SimpleGoal properties from stored information
        _name = info[0];
        _description = info[1];
        _points = int.Parse(info[2]);
        _achieved = bool.Parse(info[3]);
    }

    // Override method to prepare the details of the SimpleGoal
    public override void PrepareGoal()
    {
        // Call the base class method to handle common preparation steps
        base.PrepareGoal();
    }

    // Override method to record an event for the SimpleGoal
    public override void RecordEvent()
    {
        // Set the achieved flag to true as the goal is completed
        _achieved = true;

        // Add points for achieving the goal
        AddPoints();
    }

    // Override method to display the SimpleGoal's information
    public override void DisplayGoal()
    {
        // Call the base class method to display common goal information
        base.DisplayGoal();

        // Append specific information for SimpleGoal
        Console.Write(" (Simple Goal)");
    }

    // Override method to get a string representation of the SimpleGoal
    public override string GetStringRepresentation()
    {
        // Return a formatted string with SimpleGoal details for storage
        return $"SimpleGoal:{_name},{_description},{_points},{_achieved}";
    }
}
