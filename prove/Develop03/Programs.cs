using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static void Main()
    {
        List<Scripture> scriptureList = LoadScripturesFromFile("D:\\BYU 3 SEMESTRE\\cse210-project\\prove\\Develop03\\scriptures.txt");
        Random random = new Random();
        bool continuePlaying = true;

        while (continuePlaying)
        {
            foreach (var selectedScripture in scriptureList)
            {
                continuePlaying = PlayScriptureGame(selectedScripture, random);
                if (!continuePlaying)
                {
                    break;
                }
            }
        }
    }

    public static bool PlayScriptureGame(Scripture selectedScripture, Random random)
    {
        bool continuePlaying = true;

        while (continuePlaying)
        {
            selectedScripture.Reset();
            Console.Clear();
            Console.WriteLine("Scripture Hiding Game");
            Console.WriteLine(selectedScripture.GetReferenceString());
            Console.WriteLine(selectedScripture.GetRenderedText());

            while (!selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    return false;
                }

                selectedScripture.HideRandomWord(random);
                Console.Clear();
                Console.WriteLine("Scripture Hiding Game");
                Console.WriteLine(selectedScripture.GetReferenceString());
                Console.WriteLine(selectedScripture.GetRenderedText());
            }

            Console.WriteLine("All words in the scripture are hidden.");
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

    public static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

          for (int i = 0; i < lines.Length - 1; i += 2)
{
                string referenceLine = lines[i];
                string textLine = lines[i];
                

                string[] referenceParts = referenceLine.Split('|')[0].Split(' ');
                string book = referenceParts[0];
                int chapter = int.Parse(referenceParts[1].Split(':')[0]);
                int verse = int.Parse(referenceParts[1].Split(':')[1]);

                scriptures.Add(new Scripture(new Reference(book, chapter, verse), textLine));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while reading the file: {e.Message}");
        }

        return scriptures;
    }
}
