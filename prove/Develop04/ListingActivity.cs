using System;
using System.IO;

class ListingActivity : Activity
{
    // List of prompts for the listing activity
    private List<string> Prompt = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes"
    };

    // Constructor for the ListingActivity class
    public ListingActivity()
    {
        // Set the name and message for the ListingActivity
        NameOfActivity = "Listing Activity";
        Message = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n**If you play this option more than once, you can view your previous responses**.";
    }

    // Override the base class activity function for the listing activity
    public override void activity()
    {
        // Call the base class activity method to start with the standard animation
        base.activity();
        
        // Initialize a random number generator
        Random randomGenerator = new Random();
        int RandomNumber = randomGenerator.Next(0, Prompt.Count);
        Console.WriteLine();

        // Define a file path to save responses
        string filePath = @"D:text.txt";

        // Load and display previous responses, if the file exists
        if (File.Exists(filePath))
        {
            Console.WriteLine("Your previous responses:");
            string[] previousResponses = File.ReadAllLines(filePath);
            foreach (string response in previousResponses)
            {
                Console.WriteLine($"- {response}");
            }
        }

        // Display the current prompt to the user
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($">>>>>>{Prompt[RandomNumber]}");

        // Calculate the end time for the activity
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        // Allow the user to input responses within the specified duration
        do
        {
            Console.Write(" > ");
            string input = Console.ReadLine();

            // Save the user's response to the file
            File.AppendAllText(filePath, $"{input}\n");
        } while (endTime > DateTime.Now);

        // Display a message indicating that responses have been saved to the file
        Console.WriteLine("Responses saved to file.");
    }
}
