class Program
{
    static void Main(string[] args)
    {
        // Create a variable to store user input
        string input;

        do
        {
            // Clear the console screen
            Console.Clear();
            Console.WriteLine("Welcome to Mindful Activities!");
            Console.WriteLine("\nPlease select an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            // Read the user's choice
            input = Console.ReadLine();

            if (input == "1")
            {
                // Create a BreathingActivity instance and start the activity
                BreathingActivity BA = new BreathingActivity();
                BA.StartActivity();
            }
            else if (input == "2")
            {
                // Create a ReflectingActivity instance and start the activity
                ReflectingActivity RA = new ReflectingActivity();
                RA.StartActivity();
            }
            else if (input == "3")
            {
                // Create a ListingActivity instance and start the activity
                ListingActivity LA = new ListingActivity();
                LA.StartActivity();
            }
            else if (input == "4")
            {
                // Exit the loop and end the program
                break;
            }
        } while (input != "4");
    }
}
