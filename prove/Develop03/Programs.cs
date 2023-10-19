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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

public class DataClass
{
    public int Field1 { get; set; }
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }
    public int Field5 { get; set; }
    public string Text { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var records = ReadDataFromCSV("D:/BYU 3 SEMESTER/cse210-project/prove/Develop03/bible.csv");

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Show specific data");
        Console.WriteLine("2. Show random data");
        Console.Write("Option: ");

        if (int.TryParse(Console.ReadLine(), out int option))
        {
            switch (option)
            {
                case 1:
                    ShowSpecificData(records);
                    break;
                case 2:
                    ShowRandomData(records);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static List<DataClass> ReadDataFromCSV(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            return csv.GetRecords<DataClass>().ToList();
        }
    }

    static void ShowSpecificData(List<DataClass> records)
    {
        Console.Write("Enter the name of the book (e.g., '1 Kings'): ");
        string book = Console.ReadLine();
        Console.Write("Enter the chapter number: ");
        if (int.TryParse(Console.ReadLine(), out int chapter))
        {
            Console.Write("Enter the verse number: ");
            if (int.TryParse(Console.ReadLine(), out int verse))
            {
                var specificData = records.FindAll(d => d.Book == book && d.Chapter == chapter && d.Verse == verse);
                if (specificData.Count > 0)
                {
                    foreach (var data in specificData)
                    {
                        Console.WriteLine($"{data.Field1}, {data.Book}, {data.Chapter}, {data.Verse}, {data.Field5}, {data.Text}");
                    }
                }
                else
                {
                    Console.WriteLine("No data found for the specified input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid verse input.");
            }
        }
        else
        {
            Console.WriteLine("Invalid chapter input.");
        }
    }

    static void ShowRandomData(List<DataClass> records)
    {
        var random = new Random();
        int randomIndex = random.Next(records.Count);
        var randomData = records[randomIndex];
        Console.WriteLine($"{randomData.Field1}, {randomData.Book}, {randomData.Chapter}, {randomData.Verse}, {randomData.Field5}, {randomData.Text}");
    }
}

