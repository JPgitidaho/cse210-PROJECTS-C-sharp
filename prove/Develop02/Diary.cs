using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiaryApp
{
    // This class represents the diary and contains methods for diary operations.
    public class Diary
    {
        private List<Entry> entries = new List<Entry>();

        // Add a new diary entry with a question and response.
        public void AddEntry(string question, string response)
        {
            DateTime currentDate = DateTime.Now;
            Entry newEntry = new Entry(currentDate, question, response);
            entries.Add(newEntry);
            Console.WriteLine("Entry added to the diary.");
        }

        // Display all entries in the diary.
        public void ShowDiary()
        {
            Console.WriteLine("Diary Entries:");
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.GetFormattedEntry());
            }
        }

        // Save the diary entries to a specified file.
        public void SaveDiaryToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    // Use double-quoting to encapsulate content and escape existing double-quotes
                    //these modifications, the code handles quotation marks and commas within the 
                    //content of diary entries correctly, making the CSV format suitable for Excel.
                    string formattedQuestion = entry.Question.Replace("\"", "\"\"");
                    string formattedResponse = entry.Response.Replace("\"", "\"\"");
                    writer.WriteLine($"\"{entry.Date}\",\"{formattedQuestion}\",\"{formattedResponse}\"");
                
                }
            }

            Console.WriteLine($"Diary saved to the file: {fileName}");
        }

        // Load diary entries from a specified file.
        public void LoadDiaryFromFile(string fileName)
        {
            entries.Clear();

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] entryData = reader.ReadLine().Split(',');
                        if (entryData.Length == 3)
                        {
                            DateTime date = DateTime.Parse(entryData[0]);
                            string question = entryData[1];
                            string response = entryData[2];
                            Entry loadedEntry = new Entry(date, question, response);
                            entries.Add(loadedEntry);
                        }
                    }
                }

                Console.WriteLine($"Diary loaded from the file: {fileName}");
            }
            else
            {
                Console.WriteLine($"The file {fileName} does not exist.");
            }
        }

        // Search for diary entries containing a keyword in the response.
        public List<Entry> SearchEntries(string keyword)
        {
            return entries.Where(entry => entry.Response.Contains(keyword)).ToList();
        }
    }

    // This class generates prompts for diary entries.
    public class PromptGenerator
    {
        private List<string> prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you could do one thing today, what would it be?"
        };

        // Generate a random prompt.
        public string GeneratePrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
