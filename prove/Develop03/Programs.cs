using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<Scripture> scriptureList = new List<Scripture>()
        {
            new Scripture(new Reference("Genesis", 1, 1), "In the beginning God created the heaven and the earth."),
            new Scripture(new Reference("Matthew", 5, 16), "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."),
            new Scripture(new Reference("Psalms", 23, 1), "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Isaiah", 40, 31), "But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint."),
            new Scripture(new Reference("John", 14, 27), "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),
        };

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
            
            Console.Clear(); // Borra la pantalla de la consola.
            Console.WriteLine("Scripture Hiding Game");
            Console.WriteLine(selectedScripture.GetReferenceString());
            Console.WriteLine(selectedScripture.GetRenderedText());

            while (!selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    return false; // Termina el juego si el usuario escribe "quit."
                }

                selectedScripture.HideRandomWord(random);
                Console.Clear(); // Borra la pantalla de la consola.
                Console.WriteLine("Scripture Hiding Game");
                Console.WriteLine(selectedScripture.GetReferenceString());
                Console.WriteLine(selectedScripture.GetRenderedText());
            }

            Console.WriteLine("All words in the scripture are hidden.");
            Console.WriteLine("Do you want to play again with the same scripture, a different scripture, or quit? (same/different/quit)");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput == "same")
            {
                continuePlaying = true; // Continúa jugando con la misma escritura.
            }
            else if (playAgainInput == "different")
            {
                continuePlaying = true; // Juega con una escritura diferente.
                break;
            }
            else if (playAgainInput == "quit")
            {
                return false; // Termina el juego.
            }
            else
            {
                return false; // Si la entrada no es válida, también termina el juego.
            }
        }

        return continuePlaying;
    }
}

