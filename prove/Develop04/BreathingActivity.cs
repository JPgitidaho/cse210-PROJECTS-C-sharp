class BreathingActivity : Activity
{
    // Constructor for the BreathingActivity class
    public BreathingActivity()
    {
        // Set the name and message for the BreathingActivity
        NameOfActivity = "Breathing Activity";
        Message = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Override the base class activity function for breathing activity
    public override void activity()
    {
        // Call the base class activity method to start with the standard animation
        base.activity();

        // Set time spacing for breathing activity with a 10-second interval and pairs of breaths
        SetTimeSpacing(10, Pairs: true);

        // Define an array of spinner characters
        string[] spinnerChars = { "|", "/", "--", "\\" };
        int spinnerIndex = 0;

        // Loop through the time spacing intervals
        for (int t = 0; t < Timespacing.Count; t++)
        {
            int timeSpacingValue = Timespacing[t];
            string breathText = t % 2 == 0 ? "Breath IN" : "Breath OUT";

            // Display breathing instructions with a countdown and spinner animation
            for (int i = timeSpacingValue; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"{breathText} {i} {spinnerChars[spinnerIndex]}");

                spinnerIndex = (spinnerIndex + 1) % spinnerChars.Length; // Change the spinner index
                Thread.Sleep(1000);
            }
        }
    }
}
