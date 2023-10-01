using System;

namespace DiaryApp
{
    class Program
    {
        private static Diary diary;
        private static System.Timers.Timer autoSaveTimer;

        static void Main(string[] args)
        {
            // Initialize the Diary and PromptGenerator.
            diary = new Diary();
            PromptGenerator promptGenerator = new PromptGenerator();
            bool exit = false;

            // This do-while loop allows the user to perform various operations in the program until they choose to exit.
            do
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Write a new entry");  // Option to add a new diary entry.
                Console.WriteLine("2. Show diary");         // Option to display all diary entries.
                Console.WriteLine("3. Save diary to a file");  // Option to save diary entries to a file.
                Console.WriteLine("4. Load diary from a file");  // Option to load diary entries from a file.
                Console.WriteLine("5. Search diary entries by keyword");  // Option to search diary entries.
                Console.WriteLine("6. Exit");  // Option to exit the program.

                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = promptGenerator.GeneratePrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        diary.AddEntry(prompt, response); // Calls the AddEntry method to add a new diary entry.
                        break;
                    case "2":
                        diary.ShowDiary();// Calls the ShowDiary method to display all diary entries.
                        break;
                    case "3":
                        Console.Write("Enter the file name to save the diary: ");
                        string saveFileName = Console.ReadLine();
                        diary.SaveDiaryToFile(saveFileName);// Calls the SaveDiaryToFile method to save diary entries to a file.
                        break;
                    case "4":
                        Console.Write("Enter the file name to load the diary from: ");
                        string loadFileName = Console.ReadLine();
                        diary.LoadDiaryFromFile(loadFileName);// Calls the LoadDiaryFromFile method to load diary entries from a file.
                        break;
                    case "5":
                        Console.Write("Enter a keyword to search for in diary entries: ");
                        string keyword = Console.ReadLine();
                        var searchResults = diary.SearchEntries(keyword);// Calls the SearchEntries method to search for diary entries.
                        if (searchResults.Count > 0)
                        {
                            Console.WriteLine($"Search results for '{keyword}':");
                            foreach (var result in searchResults)
                            {
                                Console.WriteLine($"Date: {result.Date}");
                                Console.WriteLine($"Question: {result.Question}");
                                Console.WriteLine($"Response: {result.Response}");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No entries found containing '{keyword}'.");
                        }
                        break;
                    case "6":
                        exit = true;// Sets the 'exit' variable to true to exit the loop and end the program.
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            } while (!exit);// Continues the loop as long as 'exit' is false.

            Console.WriteLine("Goodbye!");
        }

        // This method handles the timer event for auto-saving the diary.
        private static void AutoSaveTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string autoSaveFileName = "autosave.csv";
            diary.SaveDiaryToFile(autoSaveFileName);
            Console.WriteLine($"Autosaved diary to: {autoSaveFileName}");
        }
    }
}
