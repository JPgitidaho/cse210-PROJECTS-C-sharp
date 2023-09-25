using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();

        if (int.TryParse(answer, out int percent)) // Try to parse user input to an integer.
        {
            string letter;

            // I use a control structure called switch; I like to simplify the code, 
            //and I believe this tool allows me to perform the comparisons I need.".
            switch (percent)
            {
                case int n when n >= 90:
                    letter = "A";
                    break;
                case int n when n >= 80:
                    letter = "B";
                    break;
                case int n when n >= 70:
                    letter = "C";
                    break;
                case int n when n >= 60:
                    letter = "D";
                    break;
                default:
                    letter = "F";
                    break;
            }

            Console.WriteLine($"Your grade is: {letter}");

            if (percent >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid percentage.");
        }
    }
}
