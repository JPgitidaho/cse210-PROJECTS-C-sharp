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
using Newtonsoft.Json;


class Bible
{
    public Metadata metadata { get; set; }
    public Verse[] verses { get; set; }
}

class Metadata
{
    public string name { get; set; }
}

class Verse
{
    public string book_name { get; set; }
    public VerseDetail[] verses { get; set; }
}

class VerseDetail
{
    public int chapter { get; set; }
    public int verse { get; set; }
    public string text { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string jsonPath = @"D:\BYU 3 SEMESTRE\cse210-project\prove\Develop03\bible.json"; // Ruta al archivo JSON

        if (File.Exists(jsonPath))
        {
            string json = File.ReadAllText(jsonPath);
            var bible = JsonConvert.DeserializeObject<Bible>(json);

            Console.WriteLine($"Nombre de la Biblia: {bible.metadata.name}");

            foreach (var book in bible.verses)
            {
                Console.WriteLine($"Libro: {book.book_name}");
                foreach (var verse in book.verses)
                {
                    Console.WriteLine($"   Capítulo {verse.chapter}, Versículo {verse.verse}: {verse.text}");
                }
            }
        }
        else
        {
            Console.WriteLine("El archivo JSON no se encuentra en la ruta especificada.");
        }
    }
}
