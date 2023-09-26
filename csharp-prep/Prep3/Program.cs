using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = random.Next(1, 201);
            int numberOfGuesses = 0;
            int userGuess;

            Console.WriteLine("Welcome to Guess My Number!");
            Console.WriteLine("I'm thinking of a number between 1 and 200.");

            do
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();

                if (int.TryParse(guessInput, out userGuess))
                {
                    numberOfGuesses++;

                    if (userGuess < magicNumber)
                    {
                        Console.WriteLine("Higuer");
                    }
                    else if (userGuess > magicNumber)
                    {
                        Console.WriteLine("Lower");

                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in ¨{numberOfGuesses} guesses!");
                    }
                }
                else
                {
                    Console.WriteLine("Pease enter a valid number.");
                }
            } while (userGuess != magicNumber);
            Console.Write("Do you want to play again (yes/no): ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thank you for playing!");
    }
}


