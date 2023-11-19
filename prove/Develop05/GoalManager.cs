static class GoalManager
{
    // Method to read an integer from the console
    public static int ReadInt(string txt)
    {
        int n;
        bool isNumeric;

        // Keep prompting the user until a valid integer is entered
        do
        {
            Console.Write(txt);
            string input = Console.ReadLine();
            isNumeric = int.TryParse(input, out n);
        } while (!isNumeric);

        return n;
    }

    // Method to read goals from a file
    public static List<Goal> ReadGoals()
    {
        // Specify the file name for storing goals
        string filename = "myGoals.txt";

        // Check if the file exists
        if (File.Exists(filename))
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filename);
            List<Goal> Goals = new List<Goal>();

            // Read the total points from the first line
            Goal.Totalpoints = int.Parse(lines[0]);

            // Iterate through the lines starting from index 1 to read individual goals
            for (int i = 1; i < lines.Length; i++)
            {
                // Split each line into parts based on the colon (:)
                string[] parts = lines[i].Split(":");
                
                // Split the attributes based on commas (,) from the second part
                string[] attributes = parts[1].Split(",");

                // Create a new goal based on the type specified in the first part
                switch (parts[0])
                {
                    case "SimpleGoal":
                        Goals.Add(new SimpleGoal(attributes));
                        break;
                    case "EternalGoal":
                        Goals.Add(new EternalGoal(attributes));
                        break;
                    case "ChecklistGoal":
                        Goals.Add(new ChecklistGoal(attributes));
                        break;
                }
            }
            return Goals;
        }
        else
        {
            // If the file doesn't exist, inform the user and start with an empty list
            Console.WriteLine("No goals file found. Starting with an empty list.");
            return new List<Goal>();
        }
    }

    // Method to write goals to a file
    public static void WriteGoals(List<Goal> Goals)
    {
        // Specify the file name for storing goals
        string fileName = "myGoals.txt";

        // Use a StreamWriter to write goals to the file
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Write the total points to the first line
            outputFile.WriteLine(Goal.Totalpoints);

            // Iterate through each goal and write its string representation to the file
            foreach (Goal g in Goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
}
