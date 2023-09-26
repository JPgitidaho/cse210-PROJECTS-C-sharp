using System;

class Program
{
    static void Main(string[] args)
    {   
        //Initialize a random number generator
        Random random = new Random();
        string playAgain = "yes";

        //Star a Loop to allow the user to play multiple times
        while (playAgain.ToLower() == "yes")
        {
            //generate a random magic number between 1 and 200
            int magicNumber = random.Next(1, 201);
            int numberOfGuesses = 0;
            int userGuess;

            //display a welcome message
            Console.WriteLine("Welcome to Guess My Number!");
            Console.WriteLine("I'm thinking of a number between 1 and 200.");

            //star a loop for game
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

            //ask if user wants to play again
            Console.Write("Do you want to play again (yes/no): ");
            playAgain = Console.ReadLine();
        }

        //thank the user for playing when they are done
        Console.WriteLine("Thank you for playing!");
    }
}


