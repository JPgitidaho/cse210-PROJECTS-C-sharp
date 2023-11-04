class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        NameOfActivity = "Breathing Activity";
        Message = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
public override void activity()
{
    base.activity();

    setTimeSpacing(10, Pairs: true);

    string[] spinnerChars = { "|", "/", "--", "\\" };
    int spinnerIndex = 0;

    for (int t = 0; t < Timespacing.Count; t++)
    {
        int timeSpacingValue = Timespacing[t];
        string breathText = t % 2 == 0 ? "Breath IN" : "Breath OUT";

        for (int i = timeSpacingValue; i > 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{breathText} {i} {spinnerChars[spinnerIndex]}");

            spinnerIndex = (spinnerIndex + 1) % spinnerChars.Length; // Cambia el índice del spinner
            Thread.Sleep(1000);
        }
    }
}

}

