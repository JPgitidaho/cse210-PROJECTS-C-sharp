class ChecklistGoal : Goal
{
    // Private fields to store additional information specific to ChecklistGoal
    private int _reps = 0;
    private int _completedReps = 0;
    private int _bonusPoints = 0;

    // Default constructor to create a new ChecklistGoal
    public ChecklistGoal()
    {
        // Initialize the ChecklistGoal by preparing its details
        PrepareGoal();
    }

    // Constructor for recreating a ChecklistGoal from stored information
    public ChecklistGoal(string[] info)
    {
        // Initialize ChecklistGoal properties from stored information
        _name = info[0];
        _description = info[1];
        _points = int.Parse(info[2]);
        _bonusPoints = int.Parse(info[3]);
        _achieved = bool.Parse(info[4]);
        _reps = int.Parse(info[5]);
        _completedReps = int.Parse(info[6]);
    }

    // Override method to prepare the details of the ChecklistGoal
    public override void PrepareGoal()
    {
        // Call the base class method to prepare common goal details
        base.PrepareGoal();

        // Get additional information specific to ChecklistGoal from the user
        _reps = GoalManager.ReadInt("How many times does this goal need to be accomplished for a bonus? ");
        Console.WriteLine();

        _bonusPoints = GoalManager.ReadInt("How many points would this bonus give? ");
        Console.WriteLine();
    }

    // Override method to record an event for the ChecklistGoal
    public override void RecordEvent()
    {
        // Increment the count of completed repetitions
        _completedReps++;

        // Add points for achieving the goal
        AddPoints();

        // Check if the goal is achieved based on completed repetitions
        if (_completedReps >= _reps)
        {
            _achieved = true;
            AddPoints(_bonusPoints);
        }
    }

    // Override method to display the ChecklistGoal's information
    public override void DisplayGoal()
    {
        // Call the base class method to display common goal information
        base.DisplayGoal();

        // Append specific information for ChecklistGoal
        Console.Write($"***Currently completed: [{_completedReps}/{_reps}]");
    }

    // Override method to get a string representation of the ChecklistGoal
    public override string GetStringRepresentation()
    {
        // Return a formatted string with ChecklistGoal details for storage
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonusPoints},{_achieved},{_reps},{_completedReps}";
    }
}
