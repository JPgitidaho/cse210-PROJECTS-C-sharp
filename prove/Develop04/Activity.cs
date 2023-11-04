
class Activity
{
    protected string NameOfActivity;
    protected string Message;
    protected int duration;
    protected List<int> Timespacing = new List<int>();
    public Activity()
    {

    }
public void star(int Length)
{
    string[] chars = { "", "|", "||", "|||", "||||" };
    Console.Write("Get Ready ");
    for (int i = 0; i < Length * 8; i++)
    {
        Console.Write( chars[i % 5] );
        Thread.Sleep(80);
        
    }
}

    public void setTimeSpacing(int NormalSpacing, bool Pairs = false)
    {
        int WholeNumber = (int)duration / NormalSpacing;
        int Remander = duration - WholeNumber * NormalSpacing;
        for (int i = 0; i < WholeNumber; i++)
        {
            if (Pairs)
            {
                int half = (int)NormalSpacing / 2;
                int secondHalf = NormalSpacing / 2 > half ? half + 1 : half;
                Timespacing.Add(secondHalf);
                Timespacing.Add(half);
            }
            else
            {
                Timespacing.Add(NormalSpacing);
            }

        }
        if (Remander > 0)
        {
            if (Pairs)
            {
                int half = (int)Remander / 2;
                int secondHalf = Remander / 2 > half ? half + 1 : half;
                Timespacing.Add(secondHalf);
                Timespacing.Add(half);
            }
            else
            {
                Timespacing.Add(Remander);
            }

        }

    }

    public void CountDown(int length)
    {
        for (int i = length; i >= 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
        Console.WriteLine(); 
    }


    public void Spinner(int length)
    {
        string[] spinnerChars = { "|", "/", "-", "\\" };
        int index = 0;

        for (int i = 0; i < length * 10; i++)
        {
            Thread.Sleep(100);
            Console.Write("\b" + spinnerChars[index]);
            index = (index + 1) % spinnerChars.Length;
        }
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {NameOfActivity}");
        Console.WriteLine($"\n{Message}");
        Console.WriteLine($"How long would you like your activity to take in seconds?");
        duration = int.Parse(Console.ReadLine());
        activity();
        EndActivity();
    }
    public virtual void activity()
    {
        star(3);
        
    }
    public void EndActivity()
    {
        Console.Clear();
        Console.WriteLine("Congratulation!");
        Console.Clear();
        Console.WriteLine($"You have completed  the {NameOfActivity}!");
        CountDown(3);
    }
}