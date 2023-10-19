/*using System;
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
}*/


using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "D:/BYU 3 SEMESTER/cse210-project/prove/Develop03/bible.csv";

        if (File.Exists(filePath))
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split(',');
                        if (fields.Length >= 6)
                        {
                            int field1 = int.Parse(fields[0]);
                            string book = fields[1];
                            int chapter = int.Parse(fields[2]);
                            int verse = int.Parse(fields[3]);
                            int field5 = int.Parse(fields[4]);
                            string text = fields[5];

                            Console.WriteLine($"{field1}, {book}, {chapter}, {verse}, {field5}, {text}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("The file does not exist at the specified path.");
        }
    }
}

