using System;

class Program
{
    static void Main()
    {
        // Display a welcome message.
        DisplayWelcome();
        
        // Prompt the user for their name and store it.
        string userName = PromptUserName();
        
        // Prompt the user for their favorite number and store it.
        int userNumber = PromptUserNumber();
        
        // Calculate the square of the user's number.
        int squaredNumber = SquareNumber(userNumber);
        
        // Display the result.
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt the user for their name and return it as a string.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number and return it as an integer.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to calculate and return the square of a given number.
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display a result message, including the user's name and squared number.
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"Hello, {userName}! Your favorite number squared is: {squaredNumber}");
    }
}
