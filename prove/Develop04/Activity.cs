class Activity
{
    // Fields for storing activity details
    protected string NameOfActivity;
    protected string Message;
    protected int duration;
    protected List<int> Timespacing = new List<int>();

    // Display a loading animation to get ready for the activity
    public void Start(int Length)
    {
        // Define an array of characters for the loading animation
        string[] chars = { "", "|", "||", "|||", "||||" };
        
        // Display "Get Ready" message
        Console.Write("Get Ready ");

        // Loop through the animation characters
        for (int i = 0; i < Length * 8; i++)
        {
            Console.Write(chars[i % 5]);
            Thread.Sleep(80);
        }
    }

    // Set time spacing for the activity
    public void SetTimeSpacing(int NormalSpacing, bool Pairs = false)
    {
        // Calculate how many times NormalSpacing fits into the duration
        int WholeNumber = (int)duration / NormalSpacing;

        // Calculate the remainder of the duration
        int Remainder = duration - WholeNumber * NormalSpacing;

        // Loop through and add time spacing values based on Pairs
        for (int i = 0; i < WholeNumber; i++)
        {
            if (Pairs)
            {
                // Calculate half of NormalSpacing
                int Half = (int)NormalSpacing / 2;

                // Calculate the second half, considering rounding
                int SecondHalf = NormalSpacing / 2 > Half ? Half + 1 : Half;

                // Add time spacing values in pairs
                Timespacing.Add(SecondHalf);
                Timespacing.Add(Half);
            }
            else
            {
                // Add NormalSpacing value
                Timespacing.Add(NormalSpacing);
            }
        }

        // If there is a remainder, add it
        if (Remainder > 0)
        {
            if (Pairs)
            {
                // Calculate half of the remainder
                int Half = (int)Remainder / 2;

                // Calculate the second half, considering rounding
                int SecondHalf = Remainder / 2 > Half ? Half + 1 : Half;

                // Add time spacing values in pairs for the remainder
                Timespacing.Add(SecondHalf);
                Timespacing.Add(Half);
            }
            else
            {
                // Add the remainder value
                Timespacing.Add(Remainder);
            }
        }
    }

    // Display a countdown for a given length
    public void CountDown(int length)
    {
        // Loop through the countdown
        for (int i = length; i >= 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
        Console.WriteLine(); // Clear the countdown line
    }

    // Display a spinner animation for a given length
    public void Spinner(int length)
    {
        // Define an array of spinner characters
        string[] spinnerChars = { "|", "/", "-", "\\" };
        int index = 0;

        // Loop through the spinner animation
        for (int i = 0; i < length * 10; i++)
        {
            Thread.Sleep(100);
            Console.Write("\b" + spinnerChars[index]);
            index = (index + 1) % spinnerChars.Length;
        }
    }

    // Start the activity, get user input, and call the activity-specific function
    public void StartActivity()
    {
        // Display welcome message and instructions
        Console.WriteLine($"Welcome to the {NameOfActivity}");
         Console.WriteLine();
        Console.WriteLine($"{Message}");
        Console.WriteLine($"How long would you like your activity to take in seconds?");
        duration = int.Parse(Console.ReadLine());

        // Call the activity-specific function (to be overridden in derived classes)
        activity();

        // Finish the activity and display congratulations message
        EndActivity();
    }

    // Virtual function for the activity-specific logic (to be overridden)
    public virtual void activity()
    {
        // By default, display the start animation
        Start(3);
    }

    // End the activity and display a completion message
    public void EndActivity()
    {
        Console.Clear();
        Console.WriteLine("Congratulation!");
        Console.Clear();
        Console.WriteLine($"You have completed the {NameOfActivity}!");
        CountDown(3);
    }
}
