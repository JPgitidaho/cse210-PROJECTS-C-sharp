class ReflectingActivity : Activity
{
    // Lists of prompts for reflection
    private List<string> Prompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> DeeperPrompt = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructor for the ReflectingActivity class
    public ReflectingActivity()
    {
        // Set the name and message for the ReflectingActivity
        NameOfActivity = "Reflecting Activity";
        Message = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    // Override the base class activity function for the reflecting activity
    public override void activity()
    {
        // Call the base class activity method to start with the standard animation
        base.activity();

        // Initialize a random number generator
        Random randomGenerator = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        // Store the original duration and set it back after a calculation
        int sD = duration;
        duration = (endTime - DateTime.Now).Seconds;
        duration = sD;

        Console.WriteLine();
        Console.WriteLine("Consider the following prompts:");

        List<string> remainingPrompts = new List<string>(Prompt);

        // Continue the activity as long as there's time and prompts remaining
        while (DateTime.Now < endTime && remainingPrompts.Count > 0)
        {
            int randomPromptIndex = randomGenerator.Next(0, remainingPrompts.Count);
            string randomPrompt = remainingPrompts[randomPromptIndex];
            Console.WriteLine();
            Console.WriteLine($">>>>>{randomPrompt}");
            Console.WriteLine();
            Console.WriteLine("(When you have something in mind, press Enter.)");
            Console.ReadLine();

            int remainingTime = (int)(endTime - DateTime.Now).TotalSeconds;

            for (int t = 0; t < Timespacing.Count && remainingTime > 0; t++)
            {
                int timeSpacingValue = Math.Min(Timespacing[t], remainingTime);
                Console.Clear();
                string deeperRandomPrompt = GetRandomItem(DeeperPrompt, randomGenerator);
                Console.WriteLine($"{deeperRandomPrompt} {timeSpacingValue}");
                Thread.Sleep(timeSpacingValue * 1000);
                remainingTime -= timeSpacingValue;
            }

            // Remove the used prompt from the list of remaining prompts
            remainingPrompts.RemoveAt(randomPromptIndex);
        }
    }

    // Helper function to get a random item from a list
    private string GetRandomItem(List<string> items, Random randomGenerator)
    {
        int randomIndex = randomGenerator.Next(0, items.Count);
        return items[randomIndex];
    }
}
