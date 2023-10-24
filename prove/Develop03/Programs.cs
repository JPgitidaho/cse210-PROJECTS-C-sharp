using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("John", 3, 16);
        var words = new List<Word>
        {
            new Word("For", true),
            new Word("God", true),
            new Word("so", true),
            new Word("loved", true),
            new Word("the", true),
            new Word("world,", true),
            new Word("that", true),
            new Word("he", true),
            new Word("gave", true),
            new Word("his", true),
            new Word("only", true),
            new Word("Son,", true),
            new Word("that", true),
            new Word("whoever", true),
            new Word("believes", true),
            new Word("in", true),
            new Word("him", true),
            new Word("should", true),
            new Word("not", true),
            new Word("perish", true),
            new Word("but", true),
            new Word("have", true),
            new Word("eternal", true),
            new Word("life.", true)
        };

        var scripture = new Scripture(reference, words);

        Console.WriteLine("Press Enter to hide words or type 'exit' to quit.");
        string input;
        do
        {
            input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting.");
                break;
            }
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Exiting.");
                break;
            }
            scripture.HideWords();
            Console.Clear();
            Console.WriteLine(scripture.RenderText());
        } while (true);
    }
}