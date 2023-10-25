using System;
using System.Collections;
using System.IO;
using System.Threading;

class Program
{
    // The main entry point of the program.
    public static void Main()
    {
        // Load a list of scriptures from a file.
        List<Scripture> scriptureList = LoadScripturesFromFile("D:\\BYU 3 SEMESTRE\\cse210-project\\prove\\Develop03\\scriptures.txt");
        
        // Initialize a random number generator.
        Random random = new Random();
        
        // Initialize a flag to control the main loop.
        bool continuePlaying = true;

        // Prompt the user to press Enter to show a random scripture or type 'quit' to exit.
        Console.WriteLine("Press Enter to display a random scripture or type 'quit' to exit.");

        // Main game loop, continues until the user chooses to quit.
        while (continuePlaying)
        {
            // Read user input.
            if (Console.ReadLine().ToLower() == "quit")
            {
                break;
            }

            // Get a random scripture from the list.
            var selectedScripture = GetRandomScripture(scriptureList, random);

            // Start playing the scripture hiding game.
            continuePlaying = PlayScriptureGame(selectedScripture, random);
        }
    }

    // Function to play the scripture hiding game with a selected scripture.
    public static bool PlayScriptureGame(Scripture selectedScripture, Random random)
    {
        bool continuePlaying = true;

        while (continuePlaying)
        {
            // Reset the scripture, clear the console, and display the reference and text.
            selectedScripture.Reset();
            Console.Clear();
            Console.WriteLine("Scripture Hiding Game");
            Console.WriteLine(selectedScripture.GetReferenceString());
            Console.WriteLine(selectedScripture.GetRenderedText());

            // Continue the game until all words in the scripture are hidden.
            while (!selectedScripture.IsCompletelyHidden())
            {
                // Prompt the user to press Enter to continue or type 'quit' to exit.
                Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    return false;
                }

                // Hide a random word in the scripture.
                selectedScripture.HideRandomWord(random);
                Console.Clear();
                Console.WriteLine("Scripture Hiding Game");
                Console.WriteLine(selectedScripture.GetReferenceString());
                Console.WriteLine(selectedScripture.GetRenderedText());
            }

            // All words in the scripture are hidden.
            Console.WriteLine("All words in the scripture are hidden.");

            // Prompt the user to play again with the same scripture, a different scripture, or quit.
            Console.WriteLine("Do you want to play again with the same scripture, a different scripture, or quit? (same/different/quit)");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput == "same")
            {
                continuePlaying = true;
            }
            else if (playAgainInput == "different")
            {
                continuePlaying = true;
                break;
            }
            else if (playAgainInput == "quit")
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        return continuePlaying;
    }

    // Function to load a list of scriptures from a file.
    public static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        try
        {
            // Read lines from the file.
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length - 1; i += 2)
            {
                // Extract reference and text from the file lines.
                string referenceLine = lines[i];
                string textLine = lines[i];

                // Parse the reference line to get book, chapter, and verse information.
                string[] referenceParts = referenceLine.Split('|')[0].Split(' ');
                string book = referenceParts[0];
                int chapter = int.Parse(referenceParts[1].Split(':')[0]);
                int verse = int.Parse(referenceParts[1].Split(':')[1]);

                // Create a new Scripture object and add it to the list.
                scriptures.Add(new Scripture(new Reference(book, chapter, verse), textLine));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while reading the file: {e.Message}");
        }

        return scriptures;
    }

    // Function to get a random scripture from the list.
    public static Scripture GetRandomScripture(List<Scripture> scriptureList, Random random)
    {
        int randomIndex = random.Next(scriptureList.Count);
        return scriptureList[randomIndex];
    }
}
